using System;

namespace Task1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество жителей в государстве");
            int residents = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите площадь (в км^2)");
            double square = double.Parse(Console.ReadLine());
            Console.WriteLine("Плотность составляет {0:f3} чел/км^2", residents / square);
            Console.ReadKey();
        }
    }

}