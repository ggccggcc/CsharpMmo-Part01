using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    internal class _03_01_if_else_01
    {
        public void Run()
        {
            int hp = 100;
            bool isDead = (hp <= 0);

            if (isDead)
            {
                Console.WriteLine("you are dead");

            }

            if (isDead == false)
            {
                Console.WriteLine("You ard alive");
            }
        }
    }
}
