//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section05
//{
//    internal class S05_01_OOP_start
//    {
//        //기사
//        // 속성 : hp, attack, pos
//        // 기능 : 무드, 어택, 다이

//        class Knight //클래스는 붕어빵 틀이고, 여기에 재료를 넣기만 하면 된다
//        {
//            public int hp;
//            public int attack;

//            public void Move()
//            {
//                Console.WriteLine("Knight Move");
//            }

//            public void Attack()
//            {
//                Console.WriteLine("Knight Attack");
//            }
//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Knight knight = new Knight(); //객체 생성
//                knight.hp = 100;
//                knight.attack = 10;

//                knight.Move();
//                knight.Attack();
//            }
//        }

//    }
//}
