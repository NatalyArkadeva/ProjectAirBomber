using ProjectAirBomber.Drawnings;

namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Абстракция компании, хранящий коллекцию автомобилей
    /// </summary>
    public abstract class AbstractCompany
    {
        /// <summary>
        /// Размер места (ширина)
        /// </summary>
        protected readonly int _placeSizeWidth = 105;
        /// <summary>
        /// Размер места (высота)
        /// </summary>
        protected readonly int _placeSizeHeight = 96;
        /// <summary>
        /// Ширина окна
        /// </summary>
        protected readonly int _pictureWidth;
        /// <summary>
        /// Высота окна
        /// </summary>
        protected readonly int _pictureHeight;
        /// <summary>
        /// Коллекция самолетов
        /// </summary>
        protected ICollectionGenericObjects<DrawningAirplane>? _collection = null;
        /// <summary>
        /// Вычисление максимального количества элементов, который можно разместить в окне
        /// </summary>
        private int GetMaxCount => _pictureWidth * _pictureHeight*5/6 / ((_placeSizeWidth * (_placeSizeHeight*3/2)));
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Ширина окна</param>
        /// <param name="picHeight">Высота окна</param>
        /// <param name="collection">Коллекция автомобилей</param>
        public AbstractCompany (int picWidth, int picHeight, ICollectionGenericObjects<DrawningAirplane> collection)
        {
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _collection = collection;
            _collection.SetMaxCount = GetMaxCount;
        }
        /// <summary>
        /// Перегрузка оператора сложения для класса
        /// </summary>
        /// <param name="company">Компания</param>
        /// <param name="airplane">Добавляемый объект</param>
        /// <returns></returns>
        public static bool operator +(AbstractCompany company, DrawningAirplane airplane)
        {
            return company._collection?.Insert(airplane) ?? false;
        }
        /// <summary>
        /// Перегрузка оператора удаления для класса
        /// </summary>
        /// <param name="company">Компания</param>
        /// <param name="position">Номер удаляемого объекта</param>
        /// <returns></returns>
        public static bool operator -(AbstractCompany company, int position)
        {
            return company._collection?.Remove(position) ?? false;
        }
        /// <summary>
        /// Получение случайного объекта из коллекции
        /// </summary>
        /// <returns></returns>
        public DrawningAirplane? GetDrawningObject()
        {
            Random rnd = new();
            return _collection?.Get(rnd.Next(GetMaxCount));
        }
        /// <summary>
        /// Вывод всей коллекции
        /// </summary>
        /// <returns></returns>
        public Bitmap? Show()
        {
            Bitmap bitmap = new(_pictureWidth, _pictureHeight);
            Graphics graphics = Graphics.FromImage(bitmap);
            DrawBackgound(graphics);
            SetObjectsPosition();
            for (int i = 0; i < (_collection?.Count ?? 0); ++i)
            {
                DrawningAirplane? obj = _collection?.Get(i);
                if (obj == null) continue;
                obj?.Draw(graphics);
            }
            return bitmap;
        }
        /// <summary>
        /// Вывод заднего фона
        /// </summary>
        /// <param name="g"></param>
        protected abstract void DrawBackgound(Graphics g);
        /// <summary>
        /// Расстановка объектов
        /// </summary>
        protected abstract void SetObjectsPosition();
    }
}
