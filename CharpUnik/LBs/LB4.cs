using System;
using System.Security.Cryptography;


namespace CharpUnik
{
    public class LB4{

        public void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота 4\n");

            Task2();

            Task3();

            Task4();
        }

        private static void Task2(){
            Console.WriteLine("Завдання 2\nВикористовуючи теорему Де Моргана, перетворіть вираз `A | B` у відповідний еквівалентний вираз.");
            string vir = "A | B";

            vir = vir.Insert(vir.Length,")").Insert(0,"(").Insert(0,"!").Replace('|', '&');

            Console.WriteLine(vir);

            Console.ReadKey();
            Console.Clear();
        }
    
        private static void Task3(){
            Console.WriteLine("Завдання 3\nНапишіть програму для перевірки чисел на четність.");
            int num = Convert.ToInt16(Console.ReadLine());
            
            if(num %2 == 0){
                Console.WriteLine("Число четне.");
            }
            else{
                Console.WriteLine("Число непарне.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        private static void Task4(){
            Console.WriteLine("Завдання 4\nНапишіть програму для розрахунку премій для співробітників, враховуючи їхню ви слугу в роках.");

            Console.Write("Введіть премію за рок: ");
            int premia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть кількість років: ");
            int krok = Convert.ToInt32(Console.ReadLine());

            int zp = premia * krok;

            Console.WriteLine("Заробітна плата: " + zp);

            Console.ReadKey();
            Console.Clear();
        }
    }
}