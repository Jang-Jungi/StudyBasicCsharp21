using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();

            Console.Write("나이를 입력하세요 : ");
            string Age = Console.ReadLine();

            Console.Write("주소을 입력하세요 : ");
            string Address = Console.ReadLine();

            Console.WriteLine($"반갑습니다. 저는 {Address}에 살고 있는 {Age}살 {name}입니다.");
            string input = Console.ReadLine();
        }
    }
}