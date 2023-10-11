using System;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Net;

namespace CharpUnik
{
    public class LB6{

        public void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Лабораторна робота 6\n");

            Task2();

            Task3();
        }

        private static void Task2(){
            Console.WriteLine("Завдання 2\nКонвертер валют\n");

            Console.Write("Введіть сумму UAH: ");
            int UAH = Convert.ToInt32(Console.ReadLine());

            
            var json = new WebClient().DownloadString("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");

            var valut = JsonConvert.DeserializeObject<NBUStatService[]>(json);

            for (int i = 0; i < valut.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + valut[i].txt);
            }
            Console.WriteLine();
            

            Console.Write("Виберіть валюту: ");
            int selected = Convert.ToInt16(Console.ReadLine()) - 1;

            Console.Clear();

            Console.WriteLine("Валюта: " + valut[selected].txt);
            Console.WriteLine("Курс: " + valut[selected].rate);
            Console.WriteLine("Cкiльки ви отримаєте: " + Math.Round(UAH / valut[selected].rate, 3) + " " + valut[selected].cc);

            Console.ReadKey();
            Console.Clear();
        }
    
        private static void Task3(){
            Console.WriteLine("Завдання 3\nМетод для визначення властивостей числа");
            Console.WriteLine(@"Напишіть метод, який буде визначати такі властивості числа:
            1) Чи є число додатним чи від'ємним.
            2) Чи є число простим (використовуйте техніку перебору значень).
            3) Чи ділиться число на 2, 5, 3, 6, 9 без залишку.");

            Console.Write("Введіть число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool positive = num > 0;

            bool simple = true;
            if (num > 1)
            {
                for (var i = 2u; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        simple = false;
                        break;
                    }
                }
            }
            else
            {
                simple = false;
            }

            bool divisor = num % 2 == 0 && num % 5 == 0 && num % 3 == 0 && num % 6 == 0 && num % 9 == 0;

            Console.WriteLine("Число додатним: " + positive);
            Console.WriteLine("Число простим: " + simple);
            Console.WriteLine("Число ділиться на 2, 5, 3, 6, 9 без залишку: " + divisor);

            Console.ReadKey();
            Console.Clear();
        }
    }

    public class NBUStatService{
        public string txt {get; set;}
        public double rate {get; set;}
        public string cc {get; set;}
    }
}