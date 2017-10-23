using System;

namespace raupjc_hw1
{
    public class GenericList <X> :IGenericList <X>
    {
        
        private X[] _internalStorage;
        private int? _top;
        
        public GenericList()
        {
            _internalStorage = new X[4];   
            Console.WriteLine(_internalStorage[1]);
        }

        public GenericList(int initialSize)
        {
            if (initialSize > 0)
            {
                _internalStorage = new X[initialSize];
            }
            else
            {
                System.Console.WriteLine("Use positive initialSize.");
            }
        }
        
        public void Add(X item)
        {
            if (_top != null && _internalStorage.Length <= _top + 1)
            {
                var oldSize = _internalStorage.Length;
                X[] old = _internalStorage;
                _internalStorage = new X[oldSize * 2];
                for (int i = 0; i < oldSize; i++)
                {
                    _internalStorage[i] = old[i];
                }
            }

            _top = (_top == null) ? 0 : _top+1;
            _internalStorage[(int) _top] = item;
        }

        public bool Remove(X item)
        {
            for (int i = 0; i<= _top; i++) {
                if (_internalStorage[i].Equals(item))
                {
                    return RemoveAt(i);
                }
            }

            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index > _top)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i <= _top; i++)
            {
                _internalStorage[i] = _internalStorage[i+1];
            }

            _top--;
            return true;
        }

        public X GetElement(int index)
        {
            if (index >= 0 && index <= _top)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < _top; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public int Count => (_top != null) ? (int) _top + 1 : 0;
        
        public void Clear()
        {
            _top = null;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i <= _top; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}