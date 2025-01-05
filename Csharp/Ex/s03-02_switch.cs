using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    public class s03_02_switch
    {
        public void Run()
        {
            int choice = 0;

            switch (choice)
            {
                case 0:
                    Console.WriteLine("가위입니다");
                    break;

                case 1:
                    Console.WriteLine("바위입니다");
                    break;

                case 2:
                    Console.WriteLine("보입니다");
                    break;

                default:
                    Console.WriteLine("전부 실패");
                    break;
            }
        }
    }
}
