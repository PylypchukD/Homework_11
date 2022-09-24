using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, 
             * переберите данную коллекцию с помощью, цикла for. С какой проблемой вы столкнулись?
             */

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");

            ArrayList array = new ArrayList();
            array.Add("Привет");
            array.Add(2);
            array.Add('s');
            array.Add(2.5);
            array.Add(null);
            array.Add(myQ);

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Проблема состоит в том, что необходимо заранее знать к какому типу нужно приводить элементы этого ArrayList.
            // Все элементы массива будут UpCast к классу Object

            Console.ReadKey();  
        }
    }
}
