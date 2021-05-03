using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("원의 반지름을 입력하세요 :");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"원의 넓이는 {input * input * Math.PI}");
        }
    }
}
