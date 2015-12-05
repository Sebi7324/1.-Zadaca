using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.zadatak;
using System.Collections;

namespace _4.zadatak
{
    class GenericListEnumerator<T> : IEnumerator<T>
    {
        private IGenericList<T> _collection;
        private int _currentPosition = 0;

        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
        }


        public T Current
        {
            get { return _collection.GetElement(_currentPosition); }
        }

        public void Dispose()
        {
            //Potrebno ignorirati.
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            if ((++_currentPosition) >= _collection.Count)
                return false;
            else return true;
        }

        public void Reset()
        {
            //Potrebno ignorirati.
            throw new NotImplementedException();
        }

    }
}
