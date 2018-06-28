using System;

namespace Task_766
{
    class Program766
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            if (int.Parse(tokens[0]) * int.Parse(tokens[1]) < int.Parse(tokens[2]))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
