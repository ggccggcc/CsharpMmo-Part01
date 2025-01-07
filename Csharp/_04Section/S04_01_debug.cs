using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._04Section
{
    internal class S04_01_debug
    {
        static int Add(int a, int b)
        {
            int ret = a + b;
            return ret;
            }
        public void Run()
        {
            int ret = S04_01_debug.Add(10, 20);
            Console.WriteLine(ret);

        }
    }
}
