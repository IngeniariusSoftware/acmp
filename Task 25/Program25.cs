using System;

namespace Task_25
{
    class Program25
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(">");
            }
            else
            {
                if (number1 < number2)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}
