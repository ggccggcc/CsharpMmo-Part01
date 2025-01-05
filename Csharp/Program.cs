namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hp;
            hp = 100;

            int maxHp = hp;

            string message = $"당신의 HP는 {hp} / {maxHp} 입니다.";

            Console.WriteLine(message);
        }
    }
}
