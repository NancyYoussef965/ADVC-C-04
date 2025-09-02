using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_C_04
{

    public class MyList<T>
    {
        private T[] _items;
        private int _count;

        public MyList()
        {
            _items = new T[4]; 
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
                Array.Resize(ref _items, _items.Length * 2);

            _items[_count++] = item;
        }

        public int Count => _count;

        public bool Exists(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
                if (match(_items[i])) return true;
            return false;
        }

        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
                if (match(_items[i])) return _items[i];
            return default;
        }

        public MyList<T> FindAll(Predicate<T> match)
        {
            MyList<T> result = new MyList<T>();
            for (int i = 0; i < _count; i++)
                if (match(_items[i])) result.Add(_items[i]);
            return result;
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
                if (match(_items[i])) return i;
            return -1;
        }

        public T FindLast(Predicate<T> match)
        {
            for (int i = _count - 1; i >= 0; i--)
                if (match(_items[i])) return _items[i];
            return default;
        }

        
        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = _count - 1; i >= 0; i--)
                if (match(_items[i])) return i;
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < _count; i++)
                action(_items[i]);
        }

        public bool TrueForAll(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
                if (!match(_items[i])) return false;
            return true;
        }
    }

}
