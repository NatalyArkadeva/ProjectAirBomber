﻿
using ProjectAirBomber.Drawnings;
using ProjectAirBomber.Exceptions;

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
                throw new PositionOutOfCollectionException(position);
            }
            return _collection[position];
        }

        public bool Insert(T obj, IEqualityComparer<T?>? comparer = null)
        {
            if (Count == _maxCount)
            {
                throw new CollectionOverflowException(_maxCount);
            }
            if (_collection.Contains(obj, comparer))
            {
                throw new NotUniqueElementException();
            }
            _collection.Add(obj);
            return true;
        }

        public bool Insert(T obj, int position, IEqualityComparer<T?>? comparer = null)
        {
            if (position < 0 || position >= _maxCount)
            {
                throw new PositionOutOfCollectionException(position);
            }
            if (Count == _maxCount)
            {
                throw new CollectionOverflowException(_maxCount);
            }
            if (_collection.Contains(obj, comparer))
            {
                throw new NotUniqueElementException();
            }
            _collection.Insert(position, obj);
            return true;
        }

        public bool Remove(int position)
        {
            if (_collection.Count == 0 || position < 0 || position >= _collection.Count)
            {
                throw new PositionOutOfCollectionException(position);
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

        public void CollectionSort(IComparer<T?> comparer)
        {
            _collection.Sort(comparer);
        }
    }
}
