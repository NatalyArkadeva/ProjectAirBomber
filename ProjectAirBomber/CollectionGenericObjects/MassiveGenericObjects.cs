namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Параметризованный набор объектов
    /// </summary>
    /// <typeparam name="T">Параметр: ограничение - ссылочный тип</typeparam>
    public class MassiveGenericObjects<T> : ICollectionGenericObjects<T>
        where T : class
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private T?[] _collection;
        public int Count => _collection.Length;
        /// <summary>
        /// Конструктор
        /// </summary>
        public int SetMaxCount { set { if (value > 0) { _collection = new T?[value]; } } }

        public MassiveGenericObjects()
        {
            _collection = Array.Empty<T>();
        }

        public T? Get(int position)
        {
            if(position < 0 || position >= _collection.Length - 1) return null;
            return _collection[position];
        }

        public bool Insert(T obj)
        {
            if (obj != null)
            {
                for (int i = 0; i < _collection.Length; i++)
                {
                    if (_collection[i] == null)
                    {
                        _collection[i] = obj;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Insert(T obj, int position)
        {
            if (obj != null && position < _collection.Length) 
            {
                if (_collection[position] == null)
                {
                    _collection[position] = obj;
                    return true;
                }
                for (int i = ++position; i < _collection.Length; i++)
                {
                    if (_collection[i] == null)
                    {
                        _collection[i] = obj;
                        return true;
                    }
                }
                for (int i = --position; i >= 0; i--)
                {
                    if (_collection[i] == null)
                    {
                        _collection[i] = obj;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Remove(int position)
        {
            if (position < 0 || position >= _collection.Length || _collection[position] == null)
            {
                return false;
            }
            _collection[position] = null;
            return true;
        }
    }
}
