using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++) // 피라미드
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                if (i == 5)
                {
                    Console.Write("\n");
                    continue;
                }
            }
        }
    }
}