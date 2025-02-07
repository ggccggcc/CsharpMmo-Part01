using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section08
{
    internal class S08_08_Reflection
    {

        class Important : System.Attribute
        {
            string message;

            public Impontant(string message) { this.message = message; }
        }
        class Monster
        {
            [Important("Very Important")]
            public int hp;
            protected int attack;
            private float speed;

            void Attack() { }

        }

        static void Main(string[] args)
        {
            // Reflection : X-Ray

            Monster monster = new Monster();

            Type type = monster.GetType();

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                |System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach (FieldInfo field in fields) 
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access}{field.FieldType.Name}{field.Name}");
            }
        }
    }
}
