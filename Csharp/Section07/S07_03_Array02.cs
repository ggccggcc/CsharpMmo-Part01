using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section07
{
    internal class S07_03_Array02
    {

        class Map
        {
            int[,] tiles =
            {
                {1,1,1,1,1 },
                {1,0,0,0,1 },
                {1,0,0,0,1 },
                {1,0,0,0,1 },
                {1,1,1,1,1 }
            };

            public void Render()
            {
                var defaultColor = Console.ForegroundColor;

                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[x, y] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor=defaultColor;
            }
        }



        static void Main(string[] args) { 
        int[] scores = new int[5] { 10, 30, 40, 20, 50 };

        //int[,] arr = new int[2, 3]; //2층, 호실 3개씩
            int[,] arr = new int[2, 3] { { 1, 2, 3, }, { 1, 2, 3, } };
            
            Map map = new Map();
            map.Render();

        }

    }
}
