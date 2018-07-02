using System;

namespace Task_192
{
    class Program192
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split(' ');
            int[] sequence = new int[length];
            for (int index = 0; index < length; index++)
            {
                sequence[index] = int.Parse(tokens[index]);
            }

            bool wasExchange = false;
            if (length > 1)
            {
                for (int index = length - 1; index > 0 && !wasExchange; index--)
                {
                    if (sequence[index] > sequence[index - 1])
                    {
                        int shelf = sequence[index - 1];
                        int min = index;
                        for (int indexExchange = index + 1; indexExchange < length; indexExchange++)
                        {
                            if (sequence[min] > sequence[indexExchange]
                                && sequence[indexExchange] > sequence[index - 1])
                            {
                                min = indexExchange;
                            }
                        }

                        sequence[index - 1] = sequence[min];
                        sequence[min] = shelf;
                        for (int indexInvert = index; indexInvert < (length - index) / 2 + index; indexInvert++)
                        {
                            int changeShelf = sequence[indexInvert];
                            sequence[indexInvert] = sequence[length - 1 - indexInvert + index];
                            sequence[length - 1 - indexInvert + index] = changeShelf;
                        }

                        wasExchange = true;
                    }
                }

                if (!wasExchange)
                {
                    for (int indexInvert = 0; indexInvert < length / 2; indexInvert++)
                    {
                        int changeShelf = sequence[indexInvert];
                        sequence[indexInvert] = sequence[length - 1 - indexInvert];
                        sequence[length - 1 - indexInvert] = changeShelf;
                    }
                }

                foreach (int element in sequence)
                {
                    Console.Write("{0} ", element);
                }
            }
            else
            {
                Console.WriteLine(sequence[0]);
            }
        }
    }
}
