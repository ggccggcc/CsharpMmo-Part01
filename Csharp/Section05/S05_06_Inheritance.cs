//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section05
//{
//    internal class S05_06_Inheritance
//    {
//        //OOP 은닉성 상속성 다형성

//        class Player // 부모 클래스, 기반 클래스
//        {
//            static public int counter = 1; //이거는 오로지 한개만 존재한다(스태틱)

//            public int id;
//            public int hp;
//            public int attack;


//            public void Move()
//            {
//                Console.WriteLine("Player Move");
//            }

//            public void Attack()
//            {
//                Console.WriteLine("Player Attack");
//            }


//            //public Player()
//            //{
//            //    Console.WriteLine("Player 생성자 호출");
//            //}

//            //public Player(int hp)
//            //{
//            //    Console.WriteLine("Player hp 생성자 호출");
//            //}

//        }

//        class Mage : Player //플레이어의 틀을 상속 받는다(카운터, id, hp, attack같이 공용으로 쓸 것을)
//        {

//        }

//        class Archer : Player // 자식 클래스, 파생 클래스
//        {

//        }


//        // 클래스는 REF 참조
//        class Knight : Player //클래스는 붕어빵 틀이고, 여기에 재료를 넣기만 하면 된다 //자식 / 파생 클래스
//        {

//            //int c;

//            //public Knight() : base(100)
//            //{
//            //    //this.c = 10;
//            //    //base.hp = 100;
//            //    Console.WriteLine("Knight 생성자 호출");
//            //}

//            //static public Knight CreateKnight()
//            //{
//            //    Knight knight = new Knight();
//            //    knight.hp = 100;
//            //    knight.attack = 1;
//            //    return knight;
//            //}





//        }



//        class Program
//        {

//            static void Main(string[] args)
//            {

//                Knight knight = new Knight();
//                knight.Move();


//                //Knight knight1 = new Knight();
//                //Knight knight2 = new Knight();
//                //knight2.hp = 80;
//                //Knight knight3 = new Knight();
//                //knight3.hp = 200;



//            }
//        }
//    }
//}
