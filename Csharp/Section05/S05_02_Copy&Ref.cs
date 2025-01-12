//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section05
//{
//    internal class S05_02_Copy_Ref
//    {

//        // 클래스는 REF 참조
//        class Knight //클래스는 붕어빵 틀이고, 여기에 재료를 넣기만 하면 된다
//        {
//            public int hp;
//            public int attack;

//            public Knight Clone()
//            {
//                Knight knight = new Knight(); //독립된 객체로 신규 생성
//                knight.hp = hp;
//                knight.attack = attack;
//                return knight;

//            }


//            public void Move()
//            {
//                Console.WriteLine("Knight Move");
//            }

//            public void Attack()
//            {
//                Console.WriteLine("Knight Attack");
//            }
//        }


//        // 구조체는 복사
//        struct Mage
//        {
//            public int hp;
//            public int attack;
//        }

//        class Program
//        {

//            static void KillMage(Mage mage)
//            {
//                mage.hp = 0;
//            }
//            static void KillKnight(Knight knight)
//            {
//                knight.hp = 0;
//            }

//            static void Main(string[] args)
//            {
//                Mage mage;
//                mage.hp = 100;
//                mage.attack = 50;

//                //KillMage(mage);
//                //구조체는 복사값(짝퉁)으로 연산을 하니까 HP가 0이 아니다

//                Mage mage2 = mage;
//                mage2.hp = 0;

//                Knight knight = new Knight(); //객체 생성
//                knight.hp = 100;
//                knight.attack = 10;

//                //KillKnight(knight);

//                //클래스는 참조하여 연산이며, 진퉁으로 작업하기 때문에 HP가 0이다


//                //Knight knight2 = new Knight(); //독립된 객체로 신규 생성
//                //knight2.hp = knight.hp;
//                //knight2.attack = knight.attack;
                
//                Knight knight2 = knight.Clone();
//                knight2.hp = 0;


//            }
//        }

//    }
//}
