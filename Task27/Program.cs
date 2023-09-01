/*Задача 27: Напишите программу, которая 
принимает на вход число и выдаёт сумму цифр в числе.*/


using System;

namespace Task27
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int summResult = Summ(number);
            System.Console.WriteLine("Результат сложения всех цифр в числе: " + summResult);
        }

        public static int Summ(int number)
        {
            int result  = 0;
            while(number > 0)
            {
                result += number % 10;
                number = number / 10; 
            }
            return result;
        }
    }
}    