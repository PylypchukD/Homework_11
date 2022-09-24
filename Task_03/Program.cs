using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично 
             * экземпляру класса ArrayList из пространства имен System.Collections. 
             */

            ArrayList array = new ArrayList();

            array.Add(1);   
            array.Add("hello");   
            array.Add(null);
            array.Add(7.7);
            array.Add('f');

            Console.WriteLine("Элементы массива" + array.ToString());
            Console.WriteLine(array.ToString());

            Console.WriteLine($"Найдем 2й элемент массива: {array[1]}");

            Console.ReadKey();
        }
    }
}
