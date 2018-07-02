using System;

namespace Task_072
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sequence = Console.ReadLine().ToCharArray();
            int length = sequence.Length;
            bool wasExchange = false;
            if (length > 1)
            {
                for (int index = length - 1; index > 0 && !wasExchange; index--)
                {
                    if (sequence[index] > sequence[index - 1])
                    {
                        char shelf = sequence[index - 1];
                        int min = index;
                        for (int indexExchange = index + 1; indexExchange < length; indexExchange++)
                        {
                            if (sequence[min] >= sequence[indexExchange]
                                && sequence[indexExchange] > sequence[index - 1])
                            {
                                min = indexExchange;
                            }
                        }

                        sequence[index - 1] = sequence[min];
                        sequence[min] = shelf;
                        for (int indexInvert = index; indexInvert < (length - index) / 2 + index; indexInvert++)
                        {
                            char changeShelf = sequence[indexInvert];
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
                        char changeShelf = sequence[indexInvert];
                        sequence[indexInvert] = sequence[length - 1 - indexInvert];
                        sequence[length - 1 - indexInvert] = changeShelf;
                    }
                }

                foreach (char element in sequence)
                {
                    Console.Write(element);
                }
            }
            else
            {
                Console.WriteLine(sequence[0]);
            }
        }
    }
}
