namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Класс-хранилище коллекций
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class StorageCollection<T>
        where T : class
    {
        /// <summary>
        /// Словарь (хранилище) с коллекциями
        /// </summary>
        readonly Dictionary<string, ICollectionGenericObjects<T>> _storages;
        /// <summary>
        /// Возвращение списка названий коллекций
        /// </summary>
        public List<string> Keys => _storages.Keys.ToList();
        /// <summary>
        /// Конструктор
        /// </summary>
        public StorageCollection()
        {
            _storages = new Dictionary<string, ICollectionGenericObjects<T>>();
        }
        /// <summary>
        /// Добавление коллекции в хранилище
        /// </summary>
        /// <param name="name">Название коллекции</param>
        /// <param name="collectionType">тип коллекции</param>
        public void AddCollection(string name, CollectionType collectionType)
        {
            if (name == null || Keys.Contains(name))
            {
                return;
            }
            switch (collectionType)
            {
                case CollectionType.Massive:
                    _storages.Add(name, new MassiveGenericObjects<T>());
                    break;
                case CollectionType.List:
                    _storages.Add(name, new ListGenericObjects<T>());
                    break;
                case CollectionType.None:
                    break;
            }
            // TODO проверка, что name не пустой и нет в словаре записи с таким ключом
            // TODO Прописать логику для добавления
        }
        /// <summary>
        /// Удаление коллекции
        /// </summary>
        /// <param name="name">Название коллекции</param>
        public void DelCollection(string name)
        {
            if (name == null || !Keys.Contains(name))
            {
                return;
            }
            _storages.Remove(name);
            // TODO Прописать логику для удаления коллекции
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
                // TODO Продумать логику получения объекта
                return _storages.GetValueOrDefault(name, null);
            }
        }
    }
}
