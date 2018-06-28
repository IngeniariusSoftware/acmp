using System;

namespace Task_1
{
    class Program1
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1]));
        }
    }
}
