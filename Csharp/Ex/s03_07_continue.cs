using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    internal class s03_07_continue
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                if ((i % 3) != 0)

                    continue;
                    Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
                
            }
        }
    }
}
