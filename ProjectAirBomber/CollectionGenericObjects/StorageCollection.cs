using ProjectAirBomber.Drawnings;
using ProjectAirBomber.Exceptions;
using System.Text;

namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Класс-хранилище коллекций
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class StorageCollection<T>
        where T : DrawningAirplane
    {
        /// <summary>
        /// Словарь (хранилище) с коллекциями
        /// </summary>
        readonly Dictionary<CollectionInfo, ICollectionGenericObjects<T>> _storages;
        /// <summary>
        /// Возвращение списка названий коллекций
        /// </summary>
        public List<CollectionInfo> Keys => _storages.Keys.ToList();
        /// <summary>
        /// Ключевое слово, с которого должен начинаться файл
        /// </summary>
        private readonly string _collectionKey = "CollectionsStorage";
        /// <summary>
        /// Разделитель для записи ключа и значения элемента словаря
        /// </summary>
        private readonly string _separatorForKeyValue = "|";
        /// <summary>
        /// Разделитель для записей коллекции данных в файл
        /// </summary>
        private readonly string _separatorItems = ";";
        /// <summary>
        /// Конструктор
        /// </summary>
        public StorageCollection()
        {
            _storages = new Dictionary<CollectionInfo, ICollectionGenericObjects<T>>();
        }
        /// <summary>
        /// Добавление коллекции в хранилище
        /// </summary>
        /// <param name="name">Название коллекции</param>
        /// <param name="collectionType">тип коллекции</param>
        public void AddCollection(string name, CollectionType collectionType)
        {
            CollectionInfo collectionInfo = new CollectionInfo(name, collectionType, string.Empty);
            if (name == null || Keys.Contains(collectionInfo))
            {
                return;
            }
            _storages.Add(collectionInfo, collectionType.Equals(CollectionType.Massive) ? new MassiveGenericObjects<T>() : new ListGenericObjects<T>());
        }
        /// <summary>
        /// Удаление коллекции
        /// </summary>
        /// <param name="name">Название коллекции</param>
        public void DelCollection(string name)
        {
            CollectionInfo collectionInfo = new CollectionInfo(name, CollectionType.None, string.Empty);
            if (name == null || !Keys.Contains(collectionInfo))
            {
                return;
            }
            _storages.Remove(collectionInfo);
        }
        /// <summary>
        /// Доступ к коллекции
        /// </summary>
        /// <param name="name">Название коллекции</param>
        /// <returns></returns>
        public ICollectionGenericObjects<T>? this[string name]
        {
            get
            {
                return _storages.GetValueOrDefault(new CollectionInfo(name, CollectionType.Massive, string.Empty), null);
            }
        }

        /// <summary>
        /// Сохранение информации по самолетам в хранилище в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        public void SaveData(string filename)
        {
            if (_storages.Count == 0)
            {
                throw new Exception("В хранилище отсутствуют коллекции для сохранения");
            }
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            StringBuilder sb = new();
            sb.Append(_collectionKey);
            foreach (KeyValuePair<CollectionInfo, ICollectionGenericObjects<T>> value in _storages)
            {
                sb.Append(Environment.NewLine);
                // не сохраняем пустые коллекции
                if (value.Value.Count == 0)
                {
                    continue;
                }
                sb.Append(value.Key);
                sb.Append(_separatorForKeyValue);
                sb.Append(value.Value.MaxCount);
                sb.Append(_separatorForKeyValue);
                foreach (T? item in value.Value.GetItems())
                {
                    string data = item?.GetDataForSave() ?? string.Empty;
                    if (string.IsNullOrEmpty(data))
                    {
                        continue;
                    }
                    sb.Append(data);
                    sb.Append(_separatorItems);
                }
            }
            using FileStream fs = new(filename, FileMode.Create);
            byte[] info = new UTF8Encoding(true).GetBytes(sb.ToString());
            fs.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Загрузка информации по самолетам в хранилище из файла
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new Exception("Файл не существует");
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            string[] strs = bufferTextFromFile.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            if (strs == null || strs.Length == 0)
            {
                throw new Exception("В файле нет данных");
            }
            if (!strs[0].Equals(_collectionKey))
            {
                //если нет такой записи, то это не те данные
                throw new Exception("В файле неверные данные");
            }
            _storages.Clear();
            foreach (string data in strs)
            {
                string[] record = data.Split(_separatorForKeyValue, StringSplitOptions.RemoveEmptyEntries);
                if (record.Length != 3)
                {
                    continue;
                }
                CollectionInfo? collectionInfo = CollectionInfo.GetCollectionInfo(record[0]) ??
                    throw new Exception("Не удалось определить информацию коллекции:" + record[0]);
                ICollectionGenericObjects<T>? collection = StorageCollection<T>.CreateCollection(collectionInfo.CollectionType);
                if (collection == null)
                {
                    throw new Exception("Не удалось создать коллекцию");
                }
                collection.MaxCount = Convert.ToInt32(record[1]);
                string[] set = record[2].Split(_separatorItems, StringSplitOptions.RemoveEmptyEntries);
                foreach (string elem in set)
                {
                    if (elem?.CreateDrawningAirplane() is T airplane)
                    {
                        if (!collection.Insert(airplane))
                        {
                            try
                            {
                                if (!collection.Insert(airplane))
                                {
                                    throw new Exception("Объект не удалось добавить в коллекцию: " + record[2]);
                                }
                            }
                            catch (CollectionOverflowException ex)
                            {
                                throw new Exception("Коллекция переполнена", ex);
                            }
                        }
                    }
                }
                _storages.Add(collectionInfo, collection);
            }
        }
        /// <summary>
        /// Создание коллекции по типу
        /// </summary>
        /// <param name="collectionType"></param>
        /// <returns></returns>
        private static ICollectionGenericObjects<T>? CreateCollection(CollectionType collectionType)
        {
            return collectionType switch
            {
                CollectionType.Massive => new MassiveGenericObjects<T>(),
                CollectionType.List => new ListGenericObjects<T>(),
                _ => null,
            };
        }
    }
}
