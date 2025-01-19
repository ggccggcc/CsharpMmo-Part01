//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section07
//{
//    internal class S07_04_List
//    {

//        static void Main(string[] args)
//        {

//            int[] arr = new int[10];
//            arr[0] = 1;

//            //List <- 동적 배열
//            List<int> list = new List<int>();
//            for (int i = 0; i<5; i++)
//                list.Add(i);

//            //삽입 삭제
//            //list.Insert(2, 999);
//            list.RemoveAt(0);
//            bool success = list.Remove(3);
//            list.Clear();

//            for (int i = 0; i < list.Count; i++)
//                Console.WriteLine(list[i]);

//            foreach(int num in list)
//                Console.WriteLine(num);
//        }
//    }
//}
