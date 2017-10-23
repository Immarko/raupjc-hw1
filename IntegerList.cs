namespace raupjc_hw1
{
    public class IntegerList : IIntegerList
    {

        private int[] _internalStorage;
        
        public IntegerList()
        {
            _internalStorage = new int[4];   
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
            throw new System.NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public int GetElement(int index)
        {
            throw new System.NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new System.NotImplementedException();
        }

        public int Count { get; }
        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new System.NotImplementedException();
        }
    }
}