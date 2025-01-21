//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section08
//{
//    internal class S08_04_Delegate
//    {


//        delegate int OnClicekd();
//        // delegate -> 형식인데, 함수 자체를 인자로 넘겨주는 형식
//        // 반환 : int // 입력 :void
//        // Onclicked 이 delegate 형식의 이름이다


//        static void ButtonPressed(OnClicekd clickedFunction)// 함수 자체를 인자로 넘겨줌
//        {
//            clickedFunction();
//        }





//        static int TestDelegate()
//        {
//            Console.WriteLine("hello delegate");
//            return 0;
//        }

//        static int TestDelegate2()
//        {
//            Console.WriteLine("22222");
//            return 0;
//        }

//        static void Main(string[] args)
//        {

//            OnClicekd clicked = new OnClicekd(TestDelegate);
//            clicked += TestDelegate2;

//            ButtonPressed(clicked);
//        }
//    }
//}
