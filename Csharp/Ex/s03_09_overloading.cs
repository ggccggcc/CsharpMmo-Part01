using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Ex
{
    public class s03_09_overloading
    {
        //오버로딩은 함수 이름의 재사용이다
        public int Add(int a, int b)
        {
            Console.WriteLine("int 호출");
            return a + b;
        }

        public float Add(float a, int b)
        {
            Console.WriteLine("float호출");
            return a + b;
        }



        public void Run()
        {
            int ret = Add(2, 3);
            float ret2 = Add(3.0f, 4);
            Console.WriteLine(ret);
            Console.WriteLine(ret2);
        }
    }
}
