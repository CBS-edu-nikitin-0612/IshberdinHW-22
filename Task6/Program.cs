using System;
/*
Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте обобщенный класс MyClass, содержащий статический фабричный метод – T FacrotyMethod(), 
который будет порождать экземпляры типа, указанного в качестве параметра типа 
(указателя места заполнения типом – Т). Каким должен быть тип, подставляемый под T?
 */
namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( MyClass.FacrotyMethod<string>().GetType());
            //Console.WriteLine(MyClass.FacrotyMethod<int[]>().GetType());
            //Console.WriteLine(MyClass.FacrotyMethod<object>().GetType());

            Console.WriteLine(MyClass.FacrotyMethod<int>().GetType());
            Console.WriteLine(MyClass.FacrotyMethod<DateTime>().GetType());

            //delay
            Console.ReadKey();
        }
    }
    static class MyClass
    {
        public static T FacrotyMethod<T>()
        {
            return default(T);
        }
    }
}
