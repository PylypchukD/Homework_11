using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class CarCollection<T> : ICar<T>
    {
        private T[] array;

        public CarCollection()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            T[] temp = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[array.Length] = item;
            array = temp;
        }

        public void Clear()
        {
            array = new T[0];
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int Amount
        {
            get { return array.Length; }
        }

    }
}
