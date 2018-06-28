using System;

namespace Task_162
{
    class Program162
    {
        static void Main(string[] args)
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

            if (number2 % 2 == 0 && number1 >= number2)
            {
                Console.WriteLine((number1 + 2) * number2 + number1 * (number2 + 2));
            }
            else
            {
                Console.WriteLine((number1 + 2) * number2 + number1 * (number2 + 2) - 2);
            }
        }
    }
}
