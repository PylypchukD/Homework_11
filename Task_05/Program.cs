using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте обобщенный класс MyClass, содержащий статический фабричный метод – T FacrotyMethod(), 
             * который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т). 
             * Каким должен быть тип, подставляемый под T?
             */

            // Ответ: Тип T должен быть таким типом, который может иметь конструктор по-умолчанию.

            var a = MyClass<int>.FactoryMethod();
            var b = MyClass<Queue<int>>.FactoryMethod();
            // var c = MyClass<string>.FactoryMethod();

            Console.WriteLine(a.GetType().ToString());
            Console.WriteLine(b.GetType().ToString());

            Console.ReadKey();
        }
    }

    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }

}
