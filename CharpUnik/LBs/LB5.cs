using System;
using System.Security.Cryptography;


namespace CharpUnik
{
    public class LB5{

        public void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Лабораторна робота 5\n");

            Task2();

            Task3();

            Task4();
        }

        private void Task2(){
            Console.WriteLine("Завдання 2\nЗадано два числа A і B (A  B). Виведіть суму всіх чисел, розташованих між цими числами на екран.");
            Console.Write("A: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("B: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            int sum = 0;
            for (int i = Math.Min(num1, num2) + 1; i < Math.Max(num1, num2); i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);

            Console.ReadKey();
            Console.Clear();
        }
    
        private void Task3(){
            Console.WriteLine("Завдання 3\n");

            // Rectangle
            Console.WriteLine("Rectangle");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Right-angled triangle
            Console.WriteLine("Right-angled triangle");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Equilateral triangle
            Console.WriteLine("Equilateral triangle");
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Rhombus
            Console.WriteLine("Rhombus");
            int rows = 5;
            int spaces = rows - 1;
            int stars = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < stars; k++)
                {
                    Console.Write("*");
                }

                if (i < rows / 2)
                {
                    spaces--;
                    stars += 2;
                }
                else
                {
                    spaces++;
                    stars -= 2;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();
        }
    
        private void Task4(){
            Console.WriteLine("Завдання 4\nЗадано N клієнтів, яким компанія-виробник повинна доставити товар. Порахуйте, скільки існує можливих маршрутів доставки товару, з урахуванням того, що товар буде доставляти одна машина.");
        
            int N = 5; 
            
            int factorial = 1;
            int i = 1;
            
            do
            {
                factorial *= i;
                i++;
            } while (i <= N);
            
            Console.WriteLine("Факторіал: " + factorial);

            Console.ReadKey();
            Console.Clear();
        }
    }
}