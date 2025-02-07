using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section08
{
    internal class S08_09_nullable
    {

        class Monster
        {
            
        }

        static Monster FindMonster(int id)
        {
            return null;
        }
        static void Main(string[] args)
        {
            Monster monster = FindMonster(101);
            if(monster != null)
            {

            }

            int? number = null;

            number = 3;

            int a = number.Value;
            Console.WriteLine("a");
        }
    }
}
