//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section08
//{
//    public class S08_05_Event
//    {

//        static void OnInputTest()
//        {
//            Console.WriteLine("Input Received");
//        }

//        static void Main(string[] args)
//        {
//            InputManager inputManager = new InputManager();

//            inputManager.InputKey += OnInputTest;

//            while (true)
//            {
//                inputManager.Update();
//            }
//        }
//    }
//}
