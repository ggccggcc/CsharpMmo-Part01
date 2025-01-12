using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section05
{
    internal class S05_04_Constructor
    {


        // 클래스는 REF 참조
        class Knight //클래스는 붕어빵 틀이고, 여기에 재료를 넣기만 하면 된다
        {
            public int hp;
            public int attack;

            public Knight() //생성자는 클래스와 이름이 같아야 한다
            {
                hp = 100;
                attack = 10;
                Console.WriteLine("생성자 호출");

            }

            public Knight(int hp) : this() //this()는 내 자신에서 빈 애들을 채워줘
            {
                this.hp = hp;
                Console.WriteLine("int 생성자 호출");


            }

            public Knight(int hp, int attack) : this() //this()는 내 자신에서 빈 애들을 채워줘
            {
                this.hp = hp;
                this.attack = attack;
                Console.WriteLine("int, int 생성자 호출");


            }

            public Knight Clone()
            {
                Knight knight = new Knight(); //독립된 객체로 신규 생성
                knight.hp = hp;
                knight.attack = attack;
                return knight;

            }


            public void Move()
            {
                Console.WriteLine("Knight Move");
            }

            public void Attack()
            {
                Console.WriteLine("Knight Attack");
            }
        }


        // 구조체는 복사
        struct Mage
        {
            public int hp;
            public int attack;
        }

        class Program
        {

            static void Main(string[] args)
            {
                Mage mage;
                mage.hp = 100;
                mage.attack = 50;

                //KillMage(mage);
                //구조체는 복사값(짝퉁)으로 연산을 하니까 HP가 0이 아니다

                Mage mage2 = mage;
                mage2.hp = 0;

                Knight knight = new Knight(50, 5); //객체 생성


            }
        }
    }
}
