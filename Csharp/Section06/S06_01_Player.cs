using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section06
{
    internal class S06_01_Player
    {
        class Program
        {
            static void Main(string[] args)
            {

                Game game = new Game();

                while (true)
                {
                    game.Process();
                }



                //while (true)
                //{

                //}

                //Player player = new Knight();
                //Player player2 = new Archer();
                //Monster monster = new Orc();

                //int damage = player.GetAttack();
                //monster.OnDamaged(damage);

            }

        }
    }
}
