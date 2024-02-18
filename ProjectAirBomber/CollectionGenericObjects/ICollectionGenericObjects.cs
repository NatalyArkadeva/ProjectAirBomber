using ProjectAirBomber.Drawnings;

namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Интерфейс описания действий для набора хранимых объектов
    /// </summary>
    /// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
    public interface ICollectionGenericObjects<T>
        where T : class
    {
        /// <summary>
        /// Количество объектов в коллекции
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Установка максимального количества элементов
        /// </summary>
        int MaxCount { get;  set; }
        /// <summary>
        /// Добавление объекта в коллекцию
        /// </summary>
        /// <param name="obj">Добавляемый объект</param>
        /// <param name="comparer">Cравнение двух объектов</param>
        /// <returns>true - вставка прошла удачно, false - вставка не удалась</returns>
        bool Insert(T obj, IEqualityComparer<T?>? comparer = null);
        /// <summary>
        /// Добавление объекта в коллекцию на конкретную позицию
        /// </summary>
        /// <param name="obj">Добавляемый объект</param>
        /// <param name="position">Позиция</param>
        /// <param name="comparer">Cравнение двух объектов</param>
        /// <returns>true - вставка прошла удачно, false - вставка не удалась</returns>
        bool Insert(T obj, int position, IEqualityComparer<T?>? comparer = null);
        /// <summary>
        /// Удаление объекта из коллекции с конкретной позиции
        /// </summary>
        /// <param name="position">Позиция</param>
        /// <returns>true - удаление прошло удачно, false - удаление не удалось</returns>
        bool Remove(int position);
        /// <summary>
        /// Получение объекта по позиции
        /// </summary>
        /// <param name="position">Позиция</param>
        /// <returns>Объект</returns>
        T? Get(int position);
        /// <summary>
        /// Получение типа коллекции
        /// </summary>
        CollectionType GetCollectionType { get; }
        /// <summary>
        /// Получение объектов коллекции по одному
        /// </summary>
        /// <returns>Поэлементый вывод элементов коллекции</returns>
        IEnumerable<T?> GetItems();
        /// <summary>
        /// Сортировка коллекции
        /// </summary>
        /// <param name="comparer">Сравнитель объектов</param>
        void CollectionSort(IComparer<T?> comparer);
    }
}
