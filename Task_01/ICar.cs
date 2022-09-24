using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal interface ICar<T>
    {
        void Add(T item);
        T this[int index] { get; }
        int Amount { get; }
        void Clear();
    }
}
