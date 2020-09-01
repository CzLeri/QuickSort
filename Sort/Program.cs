using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Pole pole = new Pole(10000);
            pole.QuickSort(0,pole.velikostPole);
            Console.WriteLine(pole);
            Console.ReadKey();
        }
    }
}
