/*Задача 25. Напишите цикл, который принимает на вход два числа (А и В)
и возводит А в натуральную степень числа В*/
using System;

namespace Task25
{
    class Program
    {
        static void Main()
        {   
            PrintBase();  
            double numberA = Convert.ToDouble(Console.ReadLine());
            PrintExponentiation();
            double numberB = Convert.ToDouble(Console.ReadLine());
            
            RaiseToThePower(numberA, numberB);
        }

        public static void RaiseToThePower (double numberX, double numberY)
        {
            double result = Math.Pow(numberX,numberY);
            Console.WriteLine("Результат возведения в степень: " + result);
        }

        public static void PrintBase()
        {
            Console.Write("Введите число основание: ");
        }
        public static void PrintExponentiation()
        {
            Console.Write("Введите число множитель: ");
        }       
    }

}