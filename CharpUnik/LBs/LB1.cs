using System;
using System.Security.Cryptography;


namespace CharpUnik
{
    public class LB1{

        public void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Лабораторна робота 1\n");

            Task1();
        }

        private static void Task1(){
            Console.WriteLine("Завдання 1\nВивести pi, e\n");
            
            double pi = Math.PI, e = Math.E;

            Console.WriteLine(pi);
            Console.WriteLine(e);

            Console.ReadKey();
            Console.Clear();
        }

        private static void Task2(){
            string text1 = "\nмоя строка 1", text2 = "\tмоя строка 2", text3 = "\aмоя строка 3";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);

            Console.ReadKey();
            Console.Clear();
        }
    }
}