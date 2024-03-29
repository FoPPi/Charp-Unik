using System;
using System.Security.Cryptography;


namespace CharpUnik
{
    public class LB3{

        public void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Лабораторна робота 3\n");

            Task2();

            Task3();
        }

        private static void Task2(){
            Console.WriteLine("Завдання 2\nНапишіть програму-калькулятор.");
            int operator1 = 5, operator2 = 6;

            Console.WriteLine(operator1 + " ? " + operator2);
            Console.Write("Ввести знак арифметичної операції: ");
            string? sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine(operator1 + operator2);
                    break;
                case "-":
                    Console.WriteLine(operator1 - operator2);
                    break;
                case "*":
                    Console.WriteLine(operator1 * operator2);
                    break;
                case "/":
                    Console.WriteLine(operator1 / operator2);
                    break;
                default:
                    Console.WriteLine("Невідома операція.");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
        }
    
        private static void Task3(){
            Console.WriteLine("Завдання 3\nНапишіть програму для визначення, чи потрапляє вказане користувачем число в діапазон від 0 до 100 та до якого саме числового проміжку воно належить.");

            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 100){
                Console.WriteLine("Число в діапазоні від 0 до 100.");
            }
            else{
                Console.WriteLine("Число не в діапазоні від 0 до 100.");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}