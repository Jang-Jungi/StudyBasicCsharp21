using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9!  3,6,9!  3,6,9!  3,6,9!");
            Console.WriteLine("\n");
            for (int j = 0; j < 10; j++)

                if (j % 3 == 0)
                {
                    Console.Write("짝!\t");
                }

                else
                {
                    Console.Write($"{j}\t");
                }
            for (int i = 10; i <= 100; i++)

                if (i % 10 == 3 || i % 10 == 6 || i % 10 == 9)
                {
                    Console.Write("짝!\t");
                }
                else if (i / 10 == 3 || i / 10 == 6 || i / 10 == 9)
                {
                    Console.Write("짝!\t");
                }
                else
                {
                    Console.Write($"{i}\t");
                }

        }
    }
}