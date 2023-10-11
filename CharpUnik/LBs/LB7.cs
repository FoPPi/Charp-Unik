using System;


namespace CharpUnik
{
    public class LB7
    {
        public void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Лабораторна робота 7\n");

            Task2();

            Task3();
        }

        private static void Task2()
        {
            Console.WriteLine("Завдання 2\nКількість можливих варіантів доставки товару\n");
            
            Console.Write("Введіть кількість клієнтів: ");
            int N = Convert.ToInt16(Console.ReadLine());

            int count = Permutation(N);
            Console.WriteLine("Кількість можливих варіантів доставки товару: " + count);
            
            Console.ReadKey();
            Console.Clear();
        }
        private static int Permutation(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count += Permutation(n - 1) * (n - i);
            }

            return count;
        }

        private static void Task3()
        {
            Console.WriteLine("Run programme: Error");
        }
    }
}