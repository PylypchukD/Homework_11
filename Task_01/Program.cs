using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте класс CarCollection. Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин. 
             * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, 
             * индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов. 
             * Создайте метод удаления всех машин автопарка. 
             */

            Car car1 = new Car("Audi", 2017);
            Car car2 = new Car("BMW", 2021);
            Car car3 = new Car("Ford", 2014);
            Car car4 = new Car("Mazda", 2020);

            CarCollection<Car> cars = new CarCollection<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);

            for (int i = 0; i < cars.Amount; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }

            Console.Write("Пример поиска 3й машины в коллекции: ");    
            Console.WriteLine( cars[2].ToString());
            
            Console.ReadKey();
        }
    }
}
