using System;

namespace _11_3_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 numbers (sheerit test))");

            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());



            if (a % b == 0)
            {
                Console.WriteLine("no sheerit");
            }
            else
            {
                Console.WriteLine("sheerit");
            }
            Console.ReadKey();
        }
    }
}