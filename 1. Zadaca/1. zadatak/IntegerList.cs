using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.zadatak
{
    class IntegerList : IIntegerList
    {

        private int[] _internalStorage;
        private int _storageElementsCount = 0;

        //Constructors
        public IntegerList()
        {
            _internalStorage = new int[4];
            
        }

        public IntegerList(int InitialSize)
        {
            _internalStorage = new int[InitialSize];
        }

        
        //IIntegerList methods
        public void Add(int item)
        {
            if (_internalStorage.Length == _storageElementsCount)
            {
                int[] TemporaryStorage = new int[_internalStorage.Length * 2];
                _internalStorage.CopyTo(TemporaryStorage, 0);
                _internalStorage = TemporaryStorage;
            }

            _internalStorage[_storageElementsCount] = item;
            ++_storageElementsCount;
        }

        public bool Remove(int item)
        {
            int StoragePosition = IndexOf(item);
            if (StoragePosition == -1)
                return false;
            else
                return RemoveAt(StoragePosition);
        }

        public bool RemoveAt(int index)
        {
            if (index > (_internalStorage.Length - 1))
                return false;

            if (_internalStorage[index] == 0) return false;
            else
            {
                _internalStorage[index] = 0; //je li ovo valjano?
                for (int i = index + 1; i < _internalStorage.Length; ++i)
                    _internalStorage[i - 1] = _internalStorage[i];
                --_storageElementsCount;
                return true;
            }
        }

        public int GetElement(int index)
        {
            if (index <= _internalStorage.Length)
                return _internalStorage[index];
            else
                throw new IndexOutOfRangeException();
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
            {
                if (_internalStorage[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public int Count
        {
            get 
            {
                return _storageElementsCount;
            }
        }

        public void Clear()
        {
            _internalStorage = new int[_internalStorage.Length];
            _storageElementsCount = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
                if (_internalStorage[i].Equals(item))
                    return true;
            return false;
        }
    }
}
