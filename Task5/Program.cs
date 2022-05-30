using System;
using System.Collections;
/*
 Используя Visual Studio, создайте проект по шаблону Console Application. 
В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, 
переберите данную коллекцию с помощью, цикла for. С какой проблемой вы столкнулись?
 */

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            a.Add(1);
            a.Add("Hi");

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("{0} {1}", a[i], a[i].GetType());
            }

            Console.ReadKey();
        }
    }
}
