using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section07
{
    internal class S07_05_Dictionary
    {
        class Monster
        {
            public int id;

            public Monster(int id) { this.id = id; }
        }

        static void Main(string[] args)
        {
            List<int> ints = new List<int>();



            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for(int i = 0; i<10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            bool found = dic.TryGetValue(7777, out mon);

            dic.Remove(7777);
            dic.Clear();

            //Monster mon = dic[5000];

            //dic.Add(1, new Monster(1)); // 1번 아이디를 갖는 몬스터를 추가해줌
            //dic[5] = new Monster(5);

        }
    }
}
