using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section05
{
    internal class S05_09_Polymorphism
    {         

        class Program
        {

            }

            static void Main(string[] args)
            {
                string name = "Harry Porter";

                //1.찾기
                   bool found = name.Contains("Harry");
                int index = name.IndexOf('P');

                //2. 변형
                name = name + " Junior";

                string lowerCaseName = name.ToLower();
                string upperCaseName = name.ToUpper();
                string newName = name.Replace('r', 'l');


            //3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);




        }
    }
    }

