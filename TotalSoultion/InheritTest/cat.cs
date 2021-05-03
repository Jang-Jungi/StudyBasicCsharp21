using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class cat : Animal
    {

        // 객체의 특성 ->속성

        //public int Age { get; set; }

        public cat() { this.Age = 0; }  // 생성자 Age=0;으로 초기화

        // 객체의 액션 -> 메서드
        /*public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }*/
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}
