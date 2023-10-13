using System;
using System.Diagnostics;
using System.Security.Cryptography;


namespace CharpUnik
{
    public class LB2
    {
        public void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Лабораторна робота 2\n");

            Task1();

            Task2();

            Task3();

            Task4();

            Task5();
        }

        private static void Task1(){
            Console.WriteLine("Завдання 1\n");
            
            int x = 10, y = 12, z = 3;

            x += y - x++ * z;
            z = --x - y * 5;
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;

            Console.ReadKey();
            Console.Clear();
        }
    
        private static void Task2(){
            Console.WriteLine("Завдання 2\nВирахувати середне значення трьох чисел.\n");

            double num1, num2, num3, avg;
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            avg = (num1 + num2 + num3) / 3;

            Console.WriteLine("AVG = " + avg);

            Console.ReadKey();
            Console.Clear();
        }

        private static void Task3(){
            Console.WriteLine("Завдання 3\n");

            const double pi = Math.PI;

            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Circumference = " + 2 * pi * radius);

            Console.ReadKey();
            Console.Clear();
        }

        private static void Task4(){
            Console.WriteLine("Завдання 4\n Об'єм та площа поверхні циліндра\n");

            double R, h;

            Console.WriteLine("Enter R: ");
            R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter h: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("V = " + 3.14 * Math.Pow(R, 2) * h);

            Console.WriteLine("S = " + 2 * 3.14 * R * (R + h));

            Console.ReadKey();
            Console.Clear();
        }
        
        private static void Task5(){
            Console.WriteLine("Завдання 5\n");

            // int uberflu?, _Identifier, \u006fIdentifier, &amp;myVar, myVariab1le;

            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=PkT0PJwy8mI",
                UseShellExecute = true
            });
        }
    }
}