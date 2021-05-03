using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    // Access Modifier :public, protected, private
    // private은 상속 불가
    // protected는 상속 받은 부분에서는 작동 가능

    class Animal
    {
        public int Age { get; set; }

        public Animal() { this.Age = 0; }

        public void Eat() 
        {
            Console.WriteLine("냠냠 밥을 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다");
        }
    }
}
