using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Car
    {
        private string name;
        private int year;

        public string Name { get; set; }
        public int Year { get; set; }

        public Car(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public override string ToString()
        {
            return $"{name} - {year}";
        }
    }
}
