using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            while (true) //цикл проверки верного ввода первого числа
            {
                Console.WriteLine("Введите первое целое число");
                if (int.TryParse(Console.ReadLine(), out int x)) //условие проверки
                {
                    a = x;
                    break;
                }
            }
            
            while (true) //цикл проверки верного ввода второго числа
            {
                Console.WriteLine("Введите второе целое число");
                if (int.TryParse(Console.ReadLine(), out int y)) //условие проверки
                {
                    b = y;
                    break;
                }
            }
            
            int sum, dif;
            sum = a + b;
            dif = a - b;

            double mean;
            if (a < 0)
            {
                a = a*(-1);

            }
            if (b < 0)
            {
                b = b * (-1);

            }
            mean = (a + b) / 2;

            int mulon = a * b;
            double divon = 0.00f;
            divon = ((double)a / b);


            Console.WriteLine($"Сумма введенных чисел равна {sum}");
            Console.WriteLine($"Разность введенных чисел равна {dif}");
            Console.WriteLine($"Среднее арифметическое модулей введенных чисел равно {mean}");
            Console.WriteLine($"Произведение введенных чисел равно {mulon}");
            Console.WriteLine($"Частное введенных чисел равно {divon}");

            Console.ReadLine(); // чтобы консоль не закрывалась автоматически
        }
    }
}
