using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.zadatak
{
    class GenericList<X> : IGenericList<X>
    {

        private X[] _internalStorage;
        private int _storageElementsCount = 0;

        //Constructors
        public GenericList()
        {
            _internalStorage = new X[4];
            
        }

        public GenericList(int InitialSize)
        {
            _internalStorage = new X[InitialSize];
        }

        //IGenericList methods
        public void Add(X item)
        {
            if (_internalStorage.Length == _storageElementsCount)
            {
                X[] TemporaryStorage = new X[_internalStorage.Length * 2];
                _internalStorage.CopyTo(TemporaryStorage, 0);
                _internalStorage = TemporaryStorage;
            }

            _internalStorage[_storageElementsCount] = item;
            ++_storageElementsCount;
        }

        public bool Remove(X item)
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

            if (_internalStorage[index].Equals(default(X))) return false;
            else
            {
                _internalStorage[index] = default(X); //je li ovo valjano?
                for (int i = index + 1; i < _internalStorage.Length; ++i)
                    _internalStorage[i - 1] = _internalStorage[i];
                --_storageElementsCount;
                return true;
            }
        }

        public X GetElement(int index)
        {
            if (index <= _internalStorage.Length)
                return _internalStorage[index];
            else
                throw new IndexOutOfRangeException();
        }

        public int IndexOf(X item)
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
            _internalStorage = new X[_internalStorage.Length];
            _storageElementsCount = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < _internalStorage.Length; ++i)
                if (_internalStorage[i].Equals(item))
                    return true;
            return false;
        }
    }
}
