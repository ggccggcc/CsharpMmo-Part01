//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section05
//{
//    internal class S05_07_Hiding
//    {

//        //OOP 은닉성 상속성 다형성
//        // 자동차
//        // 핸들 페달 차문
//            //전기장치, 엔진 <-> 외부 노출

//        class Knight
//        {
//            // 접근 한정자 public / protected / private
//            //private int hp;
//            protected int hp; // 프로텍티드는 상속받는 자식에게는 접근할 수 있게 해주겠다는 것!

//            //public void SetHp(int hp)
//            //{
//            //    this.hp = hp;

//            //}

//            class SuperKnight : Knight
//            {
//                void Test()
//                {
//                    hp = 10;
//                }

//            }

//        }


//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Knight knight = new Knight();
//                knight.SetHp(100);
//            }
//        }

//    }
//}
