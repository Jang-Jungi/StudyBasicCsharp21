using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List <dog> dogs = new List <dog>
            {
                new dog(), new dog()
            };
            List <cat> cats = new List <cat>
            {
                new cat(), new cat()
            };
            foreach(var item in dogs)
            {
                item.Age = 10;
                item.color = "흰색";
                item.Eat();
                item.Sleep();
                item.Bark();
                Console.WriteLine(item.Age + "" + item.color);
            }
            foreach (var item in cats)
            {
                item.Age = 10;
                item.Eat();
                item.Sleep();
                item.Meow();
                Console.WriteLine(item.Age );

            }
        }
    }
}
