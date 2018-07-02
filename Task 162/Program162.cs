using System;

namespace Task_162
{
    class Program162
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split();
            int number1 = int.Parse(tokens[0]);
            int number2 = int.Parse(tokens[1]);
            if (number1 < number2)
            {
                int shelf = number1;
                number1 = number2;
                number2 = shelf;
            }

            if (number1 == 1 || number2 == 1)
            {
                Console.WriteLine(number1 * number2 * 4);
            }
            else
            {
                if (number1 % 2 == 1 && number2 % 2 == 1)
                {
                    Console.WriteLine((number2 + 2) * number1 + number2 * (number1 + 2) - 2);
                }
                else
                {
                    Console.WriteLine((number2 + 2) * number1 + number2 * (number1 + 2));
                }
            }
        }
    }
}
