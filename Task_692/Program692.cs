using System;

namespace Task_692
{
    class Program692
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            if (number >= 1 && (number & (number - 1)) == 0)
            {
               Console.WriteLine("YES"); 
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
