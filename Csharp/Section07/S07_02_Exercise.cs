//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp.Section07
//{
    
//    public class S07_02_Exercise
//    {
//        static int GetHighestScore(int[] scores)
//        {
//            int maxValue = 0;

//            foreach (int score in scores)
//            {
//                if(score > maxValue) 
//                    maxValue = score;

                
//            }
//            return maxValue;
//        }

//        static int GetAverageScore(int[] scores)
//        {
//            int sum = 0;

//            foreach (int score in scores) 
//            {
//                sum += score;

//            }
//            return sum/scores.Length;
//        }

//        static int GetIndexOf(int[] scores, int value)
//        {
//            for(int i = 0; i < scores.Length; i++)
//            {
//                if(scores[i] == value)
//                    return i;
//            }
//            return -1;
//        }

//        static void Sort(int[] scores)
//        {
//            for(int i = 0; i < scores.Length;i++)
//            {
//                int minIndex = i;
//                for (int j = i; j < scores.Length; j++)
//                {
//                    if(scores[j] < scores[minIndex])
//                        minIndex = j;
//                }

//                int temp = scores[i];
//                scores[i] = scores[minIndex];
//                scores[minIndex] = temp;

//            }
//        }

//        static void Main(string[] args) {

//            int[] scores = new int[5] { 10, 30, 40, 20, 50 };
//            int highestScore = GetHighestScore(scores);
//            Console.WriteLine(highestScore);

//            int averageScore = GetAverageScore(scores);
//            Console.WriteLine(averageScore);

//            int index = GetIndexOf(scores, 20);
//            Console.WriteLine(index);

//            Sort(scores);

//        }
//    }
//}
