using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    internal class s03_05_while
    {
        public void Run()
        {
            //int count = 5;

            //while (count > 0)
            //{
            //    Console.WriteLine("hello world");
            //    count--;
            //}
            string answer;

            do
            {
                Console.WriteLine("님은 잘 생겼나요? (y/n)");
                answer = Console.ReadLine();
            }
            while (answer != "y");

            Console.WriteLine("정답");
        }
    }
}
