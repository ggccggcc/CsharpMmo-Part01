using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section08
{
    internal class S08_02_Interface
    {

        abstract class Monster
        {
            public abstract void Shout(); //몬스터 클래스를 상속받는 애들은 무조건 샤우트 함수를 오버라이드를 해야함 
        }


        interface IFlyable
        {
            void Fly ();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("오크 샤우팅");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("날아간다");
            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("스켈레톤 샤우팅");
            }

        }

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            FlyableOrc orc = new FlyableOrc();
            DoFly(orc); 
        }
    }
}
