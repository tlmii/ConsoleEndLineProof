using System;

namespace ConsoleEndLineProof
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                (int x, int y) = Console.GetCursorPosition();
                Console.SetCursorPosition(0, 0);
                Console.Write($"{x},{y}");
                Console.SetCursorPosition(x, y);
                var keyInfo = Console.ReadKey(intercept: true);
                Console.Write(keyInfo.KeyChar);
            }
        }
    }
}
