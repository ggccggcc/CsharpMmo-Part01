using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    internal class s03_07_breakContinue
    {
        public void Run()
        {
            int num = 10007; //1, 97로만 나뉘는 소수

            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    isPrime = false;

                    break;
                }

            }
                if (isPrime)
                {
                    Console.WriteLine("소수임다");
                }
                else
                {
                    Console.WriteLine("소수 아임다");
                
            }
        }
    }
}
