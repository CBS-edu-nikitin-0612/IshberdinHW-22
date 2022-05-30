using System;
/*
Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте класс ArrayList. 
Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса ArrayList 
из пространства имен System.Collections. 
 */
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new ArrayList();
            a.Add(1).Add(2).Add("Hi");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            //delay
            Console.ReadKey();
        }
    }
    class ArrayList
    {
        object[] array = Array.Empty<object>();

        public object this[int index] { get => array[index]; set => array[index] = value; }
        public int Count => array.Length;
        public ArrayList Add(object value)
        {
            object[] tempArray = new object[Count + 1];
            Array.Copy(array, 0, tempArray, 0, Count);
            tempArray[Count] = value;
            array = tempArray;
            return this;

        }
    }
}
