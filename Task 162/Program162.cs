using System;

namespace Task_162
{
    class Program162
    //hui
    {
        public static int PathLength;

        public static int Path;

        public static bool CheckMas(byte[,] mas)
        {
            for (int indexY = 0; indexY < mas.GetLength(0); indexY++)
            {
                for (int indexX = 0; indexX < mas.GetLength(1); indexX++)
                {
                    if (mas[indexY, indexX] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void SearchShortMasPath(byte[,] mas, int currentPositionY, int currentPositionX, int pathLength)
        {
            if ((pathLength < Path || Path == 0) && pathLength < PathLength)
            {
                if (currentPositionX == 0 && currentPositionY == 0 && CheckMas(mas))
                {
                    Path = pathLength;
                }
                else
                {
                    // ShowMas(graph);
                    byte[,] newMas;
                    if (currentPositionX < mas.GetLength(1) - 1)
                    {
                        newMas = (byte[,])mas.Clone();
                        newMas[currentPositionY, currentPositionX + 1] = 1;
                        SearchShortMasPath(newMas, currentPositionY, currentPositionX + 1, pathLength + 1);
                    }

                    if (currentPositionY < mas.GetLength(0) -1)
                    {
                        newMas = (byte[,])mas.Clone();
                        newMas[currentPositionY + 1, currentPositionX] = 1;
                        SearchShortMasPath(newMas, currentPositionY + 1, currentPositionX, pathLength + 1);
                    }

                    if (currentPositionX > 0)
                    {
                        newMas = (byte[,])mas.Clone();
                        newMas[currentPositionY, currentPositionX - 1] = 1;
                        SearchShortMasPath(newMas, currentPositionY, currentPositionX - 1, pathLength + 1);
                    }

                    if (currentPositionY > 0)
                    {
                        newMas = (byte[,])mas.Clone();
                        newMas[currentPositionY - 1, currentPositionX] = 1;
                        SearchShortMasPath(newMas, currentPositionY - 1, currentPositionX, pathLength + 1);
                    }
                }
            }
        }

        public static void ShowMas(byte[,] mas)
        {
            Console.WriteLine("\n\tМассив имеет вид:\n");
            for (int indexY = 0; indexY < mas.GetLength(0); indexY++)
            {
                for (int indexX = 0; indexX < mas.GetLength(1); indexX++)
                {
                    Console.Write("{0} ", mas[indexY, indexX]);
                }
                   
                Console.WriteLine();
            }
        }


        static void Main()
        { 
            string[] tokens = Console.ReadLine().Split();
            int sizeX = int.Parse(tokens[0]) + 1;
            int sizeY = int.Parse(tokens[1]) + 1;
            PathLength = (sizeX + 3) * sizeY + sizeX * (sizeY + 3);
            ShowMas(new byte[sizeY, sizeX]);
            SearchShortMasPath(new byte[sizeY, sizeX], 0, 0, 0);
            Console.WriteLine("\n\tМинимальный путь в массиве равен: {0}", Path);
            Console.WriteLine("\n\tДля завершения работы нажмите на любую клавишу . . .");    
            Console.ReadKey();
        }
    }
}
