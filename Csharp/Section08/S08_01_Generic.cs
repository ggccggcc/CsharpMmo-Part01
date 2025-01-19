//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section08
//{
//    internal class S08_01_Generic
//    {
//        class MyList<T>
//        {
//            //object[] arr = new object[10];
//            T[] arr = new T[10];

//            public T GetItem(int i)
//            {
//                return arr[i];
//            }
//        }

//        class Monster
//        {

//        }


//        static void Test<T>(T input)
//        {

//        }


//        static void Main(string[] args)
//        {

//            MyList<int> MyIntList = new MyList<int>();
//            int item = MyIntList.GetItem(0);
//            MyList<Monster> MyMonsterList = new MyList<Monster>();

//            Test<int>(3);


//            var obj3 = 3;
//            var obj4 = "hello world";


//            object obj = 3;
//            object obj2 = "hello world";

//            int num = (int)obj;
//            string str = (string)obj2;

//        }
//    }
//}
