using System;
using System.Collections.Generic;
/*
Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте класс CarCollection. 
Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин. 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать 
метод добавления машин с названием машины и года ее выпуска, 
индексатор для получения значения элемента по указанному индексу и 
свойство только для чтения для получения общего количества элементов. 
Создайте метод удаления всех машин автопарка. 
*/
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection cars = new CarCollection();

            Console.WriteLine(cars.Count);
            cars.Add("BMW", 2022);
            cars.Add("WV", 2022);
            Console.WriteLine(cars.Count);
            Console.WriteLine(cars.Cars[0].Name);
            cars.Reset();
            Console.WriteLine(cars.Count);

            //delay
            Console.ReadKey();
        }

        class CarCollection
        {
            List<Car> cars = new List<Car>();

            public int Count => cars.Count;
            public List<Car> Cars => cars;

            public void Add(string name, int year)
            {
                Car car = new Car(name, year);
                cars.Add(car);
            }

            public void Reset()
            {
                cars.Clear();
            }
        }
        class Car
        {
            public string Name { get; }
            public int Year { get; }

            public Car(string name, int year)
            {
                Name = name; Year = year;
            }
        }
    }

}
