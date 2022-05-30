using System;
using System.Collections.Generic;
/*
Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте класс Dictionary. 
Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary 
из пространства имен System.Collections.Generic. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, 
индексатор для получения значения элемента по указанному индексу и 
свойство только для чтения для получения общего количества пар элементов. 
 */
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task3.Dictionary<string, string> dictionary = new Task3.Dictionary<string, string>();

            Console.WriteLine(dictionary.Count);
            dictionary.Add("One", "Один");
            Console.WriteLine(dictionary.Count);

            Console.WriteLine(dictionary.Keys[0]);

            Console.ReadKey();
        }
    }
    class Dictionary<TKey, TValue>
    {
        List<TKey> keys = new List<TKey>();
        List<TValue> values = new List<TValue>();

        public int Count => keys.Count;
        public List<TKey> Keys => keys;
        public List<TValue> Values => values;

        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }
    }

}
