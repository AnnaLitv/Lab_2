using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series();

            menu();
            Console.WriteLine("Выберите пункт меню: ");
            int c = Convert.ToInt32(Console.ReadLine());
            while (c != 5)
            {
                switch (c)
                {
                    case 1:
                        {
                            Ellipse ellip = new Ellipse(16, 7);
                            series.add(ellip);
                            Hiperbola hip = new Hiperbola(4, 5);
                            series.add(hip);
                            Parabola par = new Parabola(1, 2, 1);
                            series.add(par);
                            break;
                        }
                    case 2://задать уравнение
                        {
                            Console.WriteLine("1. Эллипс");
                            Console.WriteLine("2. Гипербола");
                            Console.WriteLine("3. Парабола");
                            int d = Convert.ToInt32(Console.ReadLine());
                            switch (d)
                            {
                                case 1://Эллипс
                                    Console.WriteLine("Введите a:");
                                    double a = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Ellipse el = new Ellipse(a, b);
                                    series.add(el);
                                    break;
                                case 2://Гипербола
                                    Console.WriteLine("Введите a:");
                                    double a1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите b:");
                                    double b1 = Convert.ToDouble(Console.ReadLine());
                                    Hiperbola hiper = new Hiperbola(a1, b1);
                                    series.add(hiper);
                                    break;
                                case 3://Парабола
                                    Console.WriteLine("Введите a:");
                                    double a2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите b:");
                                    double b2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите c:");
                                    double c2 = Convert.ToDouble(Console.ReadLine());
                                    Parabola parab = new Parabola(a2, b2, c2);
                                    series.add(parab);
                                    break;
                            }
                            break;
                        }
                    case 3://посчитать в точке
                        {
                            double x = 0;
                            x = Convert.ToDouble(Console.ReadLine());
                            series.print(x);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("1. Эллипс");
                            Console.WriteLine("2. Гипербола");
                            Console.WriteLine("3. Парабола");
                            int d = Convert.ToInt32(Console.ReadLine());
                            switch (d)
                            {
                                case 1://Эллипс
                                    Console.WriteLine("Введите a:");
                                    double a = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Ellipse el = new Ellipse(a, b);
                                    if(series.equal(el))
                                    Console.WriteLine("Есть!");
                                    else Console.WriteLine("Нет!");
                                    break;
                                case 2://Гипербола
                                    Console.WriteLine("Введите a:");
                                    double a1 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите b:");
                                    double b1 = Convert.ToDouble(Console.ReadLine());
                                    Hiperbola hiper = new Hiperbola(a1, b1);
                                    if(series.equal(hiper))
                                    Console.WriteLine("Есть!");
                                    else Console.WriteLine("Нет!");
                                    break;
                                case 3://Парабола
                                    Console.WriteLine("Введите a:");
                                    double a2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите b:");
                                    double b2 = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Введите c:");
                                    double c2 = Convert.ToDouble(Console.ReadLine());
                                    Parabola parab = new Parabola(a2, b2, c2);
                                    if(series.equal(parab))
                                    Console.WriteLine("Есть!");
                                    else Console.WriteLine("Нет!");
                                    break;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого пункта нет в меню!");
                            break;
                        }
                }
                menu();
                Console.WriteLine("Выберите пункт меню: ");
                c = Convert.ToInt32(Console.ReadLine());
            }


        }
        private static void menu()
        {
            Console.WriteLine("1. Задать уравнения стандартно");
            Console.WriteLine("2. Задать уравнение");
            Console.WriteLine("3. Посчитать значение в точке х");
            Console.WriteLine("4. Проверить наличие уравнения");
            Console.WriteLine("5. Выйти");
        }
    }
}
