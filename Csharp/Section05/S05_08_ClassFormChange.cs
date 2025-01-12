//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section05
//{
//    internal class S05_08_ClassFormChange
//    {
//        class Player
//        {
//            protected int hp;
//            protected int attack;

//        }

//        class Knight : Player 
//        {

//        }

//        class Mage : Player
//        {
//            public int mp;
//        }


//        class Program
//        {
//            static void EnterGame(Player player)
//            {
//                //bool isMage = (player is Mage);
//                //if (isMage)
//                //{

//                //    Mage mage = (Mage)player;
//                //    mage.mp = 10;
//                //}

//                Mage mage = (player as Mage);
//                if (mage != null)
//                {
//                    mage.mp = 10;
//                }

//            }

//            //static void EnterGame(Mage mage)
//            //{
//            //    // 이건 너무 비효율적
//            //}


//            static void Main(string[] args)
//            {
//                Knight knight = new Knight();
//                Mage mage = new Mage();

//                //Player p1 = knight;
//                //Mage m1 = (Mage)p1;

//                // Mage타입 -> Player타입 변환 가능
//                // Player타입 -> Mage타입 변환 가능할려나??

//                //Player magePlayer = mage;
//                ////Mage mage2 = magePlayer;
//                //Mage mage2 = (Mage)magePlayer;


//                EnterGame(knight);
//                //EnterGame(mage);

//            }
//        }
//    }
//}
