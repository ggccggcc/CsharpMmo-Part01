using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    internal class s03_03_rockpaper
    {
        public void Run()
        {
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); //0~2사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("AI의 선택은 가위");
                    break;
                case 1:
                    Console.WriteLine("AI의 선택은 바위");
                    break;
                case 2:
                    Console.WriteLine("AI의 선택은 보");
                    break;
            }
            if (choice == 0)
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("무승부입니다");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("패배입니다");
                }
                else
                {
                    Console.WriteLine("승리입니다");
                }
            }
            else if (choice == 1) { 
                if (aiChoice == 0)
                {
                    Console.WriteLine("승리입니다");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("무승부입니다");
                }
                else
                {
                    Console.WriteLine("패배입니다");
                }
            }
            else 
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("패배입니다");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("승리입니다");
                }
                else
                {
                    Console.WriteLine("무승부입니다");
                }
            }
        }

        
    }
}
