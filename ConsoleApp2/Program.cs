using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /* static void Main(string[] args)
        {
            //запросить имя пользователя
            Console.Write("Введите имя пользователя и нажмите Enter:");


            //прочесть данные и присвоитьи мя переменной \"name\"
            string name = Console.ReadLine();

            // \"name\" можно использовать как обычную переменную
            Console.WriteLine("Hello, " + name + "!");

            // Используем ReadLine() с численными типами
             Console.Write("Введите свой возраст и нажмите Enter: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свой рост и нажмите Enter: ");


            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вам {0} лет, а рост {1}.", age, height);

                // А теперь попросим пользователя нажать \"Enter\" для выхода из программы
              Console.Write("Программа завершена. Нажмите Enter для выхода...");
              Console.ReadLine();
        }
        */


        static void Main()
        {
            /*
            //нахождение минимального числа
            Console.Write("Введите первое число и нажмите Enter: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число и нажмите Enter: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число и нажмите Enter: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите четвертое число и нажмите Enter: ");
            int v = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FindMin(x, y, z, v));
            Console.ReadKey();
        }
            static int FindMin(int x, int y, int z, int v)
        {
            return Math.Min(x, Math.Min(y, Math.Min(z, v)));
        }
        */
            //возведение в вкадрат
            {
                Console.WriteLine("возведение в квадрат");
                Console.Write("Ведите число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0} в квадрате {1}", a, Math.Pow(a, 2));
                Console.ReadLine();
            }
            //возведение в куб
            {
                Console.WriteLine("возведение в куб");
                Console.Write("Ведите число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0} в кубе {1}", a, Math.Pow(a, 3));
                Console.ReadLine();
            }
        }
    }
}

    

