/* Запишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

        int Prompt (string message)
        {
            System.Console.Write(message);
            string ReadInput = System.Console.ReadLine();
            int result = int.Parse(ReadInput);
            return result;
        }

        int[] GenerateArray (int minValue, int maxValue)
        {
            int[] array = new int[8];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        void PrintArray(int[] array)
        {
            System.Console.Write("[");
            for (int i = 0; i < 8 - 1; i++)
            {
                System.Console.Write($"{array[i]}, ");
            }
            System.Console.Write($"{array[8 - 1]}");
            System.Console.Write("]");
        }
            int min = Prompt("Минимальное значение случайного числа в массиве: ");
            int max = Prompt("Максимальное значение случайного числа в массиве: ");
            int[] array = GenerateArray(min, max);
            PrintArray(array);
