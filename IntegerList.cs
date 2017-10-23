using System;

namespace raupjc_hw1
{
    public class IntegerList : IIntegerList
    {

        private int[] _internalStorage;
        private int? _top;
        
        public IntegerList()
        {
            _internalStorage = new int[4];   
            Console.WriteLine(_internalStorage[1]);
        }

        public IntegerList(int initialSize)
        {
            if (initialSize > 0)
            {
                _internalStorage = new int[initialSize];
            }
            else
            {
                System.Console.WriteLine("Use positive initialSize.");
            }
        }

        public void Add(int item)
        {
            if (_top != null && _internalStorage.Length <= _top + 1)
            {
                var oldSize = _internalStorage.Length;
                int[] old = _internalStorage;
                _internalStorage = new int[oldSize * 2];
                for (int i = 0; i < oldSize; i++)
                {
                    _internalStorage[i] = old[i];
                }
            }

            _top = (_top == null) ? 0 : _top+1;
            _internalStorage[(int) _top] = item;
            printArray();
        }

        public bool Remove(int item)
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
            printArray();
            return true;
        }

        public int GetElement(int index)
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

        public int IndexOf(int item)
        {
            throw new System.NotImplementedException();
        }

        public int Count => (_top != null) ? (int) _top + 1 : 0;

        public void Clear()
        {
            _top = null;
        }

        public bool Contains(int item)
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

        private void printArray()
        {
            Console.Write("[");
            for (int i = 0; i <= _top; i++)
            {
                Console.Write(_internalStorage[i] + ", ");
            }
            Console.Write("]");
        }
    }
}