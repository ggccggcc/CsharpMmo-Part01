using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    internal class message
    {
        public void Run()
        {
            int hp;
            hp = 100;

            int maxHp = hp;

            string message = $"당신의 HP는 {hp} / {maxHp} 입니다.";

            Console.WriteLine(message);
        }
    }
}
