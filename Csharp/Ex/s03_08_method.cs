using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    internal class s03_08_method
    {

        // 한정자 반환형식 이름(매개변수목록)
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }


        public void Run()
        {
            int result = Add(4, 5);
            Console.WriteLine(result);
        }
    }
}
