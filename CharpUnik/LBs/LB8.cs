using System;

namespace CharpUnik
{
    public class LB8
    {
        public void Main(string[] args)
        {
            
            Console.Clear();

            Console.WriteLine("Лабораторна робота 8\n");
            
            Task2(Task1());
        }

        private static int[] Task1()
        {
            Console.WriteLine("Завдання 1\nВиведіть масив рандомних цілих чисел\n");
            
            Random rnd = new Random();
            
            Console.Write("Array size: ");
            int n = Convert.ToInt16(Console.ReadLine());
            
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,10);
            }
            
            Console.Write("Array: ");
            ShowArr(arr);
            
            Console.ReadKey();

            return arr;
        }

        private static void Task2(int[] arr)
        {
            Console.WriteLine("Завданя 2\n");
            
            int[] arr2 = MyRevers(arr);
            Console.Write("Reversed array: ");
            ShowArr(arr2);
            Console.Write("Substring array: ");
            ShowArr(SubstringArray(arr, index:0, count: 4));
            
            Console.ReadKey();
            Console.Clear();
        }
        private static int[] MyRevers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[arr.Length - 1 - i];
            }
            return arr;
        }
        private static int[] SubstringArray(int[] arr, int index, int count)
        {
            int[] result = new int[count];
            Array.Copy(arr, index, result, 0, count);
            return result;
        }


        private static void ShowArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}