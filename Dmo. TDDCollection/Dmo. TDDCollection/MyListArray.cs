using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Dmo._TDDCollection
{
    public class MyListArray<T> : IList<T>
    {

        #region private fields
        private T[] _arr;
        private int _count;

        #endregion
        #region .ctors

        public MyListArray(int startCapacity = 10)
        {
            _count = 0;
            _arr = new T[startCapacity];
        }

        #endregion
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count) throw new IndexOutOfRangeException();
                return _arr[index];
            }
            set
            {
                if (index < 0 || index >= _count) throw new IndexOutOfRangeException();
                _arr[index] = value;
            }

        }
        public int Count => _count;
        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (_count == _arr.Length)
            {
                Array.Resize(ref _arr, _count + 10);
            }
            _arr[_count++] = item;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
