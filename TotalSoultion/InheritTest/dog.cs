using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class dog : Animal
    {
        // 객체의 특성 ->속성

        //public int Age { get; set; } // get set이 없으면 메소드에서 값을 입력해도 오류가 나옵니당
        public string color { get; set; }

        public dog() { this.Age = 0; this.color = "흰색"; }  // 생성자 Age=0;으로 초기화

        // 객체의 액션 -> 메서드
        /*public void Eat () 
        { 
            Console.WriteLine( "냠냠 먹습니다." ); 
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }*/
        public void Bark () 
            { 
                Console.WriteLine("왈왈 짖습니다.");
            }
    }
}
