using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    public class _03_01_if_else
    {
        public void Run()
        {

            int choice = 0; // 0:가위 1:바위 2:보

            if (choice == 0 )
            {
                Console.WriteLine("가위입니다");
            }
            else if(choice == 1)
            {
                Console.WriteLine("바위입니다");
            }

            else
            {
                Console.WriteLine("보입니다.");
            }



        }
    }
}
