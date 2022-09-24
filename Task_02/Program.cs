using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте класс Dictionary. Реализуйте в простейшем приближении возможность использования 
             * его экземпляра аналогично экземпляру класса Dictionary из пространства имен System.Collections.Generic. 
             * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, 
             * индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов. 
             */

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Белый", "White");
            dictionary.Add("Серый", "Gray");
            dictionary.Add("Черный", "Black");
            dictionary.Add("Синий", "Blue");
            dictionary.Add("Красный", "Red");
            dictionary.Add("Желтый", "Yellow");
            dictionary.Add("Зеленый", "Green");

            Console.WriteLine($"Количество элементов в словаре: { dictionary.Lenght}");

            Console.WriteLine("Элементы словаря: ");
            for (int i = 0; i < dictionary.Lenght; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine($"Поищем значение \"Белый\": {dictionary["Белый"]}");

            Console.ReadKey();

        }
    }
}
