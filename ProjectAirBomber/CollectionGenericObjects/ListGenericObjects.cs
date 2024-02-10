
namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Параметризованный набор объектов
    /// </summary>
    /// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
    public class ListGenericObjects<T> : ICollectionGenericObjects<T>
        where T : class
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T?> _collection;
        /// <summary>
        /// Максимально допустимое число объектов в списке
        /// </summary>
        private int _maxCount;
        public int Count => _collection.Count;

        public int MaxCount 
        { 
            get => _maxCount;
            set 
            { 
                if (value > 0) 
                { 
                    _maxCount = value; 
                } 
            } 
        }

        public CollectionType GetCollectionType => CollectionType.List;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ListGenericObjects()
        {
            _collection = new();
        }
        public T? Get(int position)
        {
            if (position<0 || position>=_maxCount)
            {
                return null;
            }
            return _collection[position];
        }

        public bool Insert(T obj)
        {
            if (Count == _maxCount)
            {
                return false;
            }
            _collection.Add(obj);
            return true;
        }

        public bool Insert(T obj, int position)
        {
            if (position < 0 || position >= _maxCount || Count == _maxCount)
            {
                return false;
            }
            _collection.Insert(position, obj);
            return true;
        }

        public bool Remove(int position)
        {
            if (_collection.Count == 0 || position < 0 || position >= _collection.Count)
            {
                return false;
            }
            _collection.RemoveAt(position);
            return true;
        }

        public IEnumerable<T?> GetItems()
        {
            for (int i = 0; i < _collection.Count; ++i)
            {
                yield return _collection[i];
            }
        }
    }
}
