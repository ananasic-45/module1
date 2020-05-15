using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using module1.OOP.Gear.Interfaces;

namespace module1.OOP.Gear
{
    public class Bag<T> : ICollection<T>
        where T : IItem
    {
        readonly ICollection<T> _collection;

        public int Count => _collection.Count;

        public bool IsReadOnly => _collection.IsReadOnly;

        public Bag() =>
            _collection = new Collection<T>();

        public Bag(ICollection<T> collections)
        {
            _collection = collections ??
                throw new ArgumentNullException(nameof(collections), "Value can`t be a null");
        }

        public void Add(T item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item), "Value can`t be a null");

            _collection.Add(item);
        }

        public void Clear() =>
            _collection.Clear();

        public bool Contains(T item) =>
            _collection.Contains(item);

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array), "Value can`t be null");

            _collection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator() =>
            _collection.GetEnumerator();

        public bool Remove(T item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item), "Value can`t be null");

            return _collection.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator() =>
            _collection.GetEnumerator();

        //TODO: add sort functionality
        public ICollection<T> Sort()
        {
            return default;
        }

    }
}