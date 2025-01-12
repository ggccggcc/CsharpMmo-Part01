//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section05
//{
//    internal class S05_05_Static
//    {


//        // 클래스는 REF 참조
//        class Knight //클래스는 붕어빵 틀이고, 여기에 재료를 넣기만 하면 된다
//        {
//            //필드
//            static public int counter = 1; //이거는 오로지 한개만 존재한다(스태틱)

//            public int id;
//            public int hp;
//            public int attack;

//            static public void Test() //나이트 클래스에 종속적이게 된다 (유일성 보장) : 스태틱으로 정의하면
//            {
//                //this.id = 23; 나이트 클래스 하위 종속되는 함수이기 때문에, 이거 상위에 있는 애들을 불러올 수 없다(연산할 수 없다)
//                counter++;
//            }

//            static public Knight CreateKnight()
//            {
//                Knight knight = new Knight();
//                knight.hp = 100;
//                knight.attack = 1;
//                return knight;
//            }

//            public Knight() //생성자는 클래스와 이름이 같아야 한다
//            {
//                id = counter;
//                counter++;

//                hp = 100;
//                attack = 10;
//                Console.WriteLine("생성자 호출");

//            }

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

//            static void Main(string[] args)
//            {

//                Knight knight = Knight.CreateKnight(); // static
//                knight.Move(); //Knight 클래스로는 못 불러와서 knight 객체를 불러오는 개념으로 써야 함

//                Console.WriteLine();

//                //Knight knight1 = new Knight();
//                //Knight knight2 = new Knight();
//                //knight2.hp = 80;
//                //Knight knight3 = new Knight();
//                //knight3.hp = 200;



//            }
//        }
//    }
//}
