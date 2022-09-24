using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class ArrayList
    {
        private object[] array;

        public ArrayList()
        {
            array = new object[0];
        }
        public void Add(object item)
        {

            object[] temp = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[array.Length] = item;
            array = temp;

        }

        public void Clear()
        {
            array = new object[0];
        }

        public object this[int index]
        {
            get { return array[index]; }
        }

        public int Amount
        {
            get { return array.Length; }
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                 str += array[i] + " ";
            }
            return str;
        }
    }
}
