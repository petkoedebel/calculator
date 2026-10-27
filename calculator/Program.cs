using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{



    public class DDS
    {
        public decimal SasDDS(decimal suma, decimal procent)
        {
            return Math.Round(suma + suma * procent / 100, 2);
        }

        public decimal BezDDS(decimal suma, decimal procent)
        {
            return Math.Round(suma / (1 + procent / 100), 2);
        }
    }

    public class Kalkulator
    {
        public double Sabirane(double a, double b)
        {
            return a + b;
        }

        public double Izvazhdane(double a, double b)
        {
            return a - b;
        }

        public double Umnozhenie(double a, double b)
        {
            return a * b;
        }

        public double Delenie(double a, double b)
        {
            return a / b;
        }

        public double Ostatak(double a, double b)
        {
            return a % b;
        }



        public static void Main()
        {
            Kalkulator k = new Kalkulator();
            DDS d = new DDS();

            while (true)
            {
                Console.WriteLine("\nМоят калкулатор");
                Console.WriteLine("1 - Калкулатор");
                Console.WriteLine("2 - ДДС калкулатор");
                Console.WriteLine("0 - Изход");

                int izbor = int.Parse(Console.ReadLine());

                if (izbor == 0)
                    break;

                if (izbor == 1)
                {
                    Console.WriteLine("Въведи първо число:");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Въведи действие (+, -, *, /, %):");
                    string znak = Console.ReadLine();

                    Console.WriteLine("Въведи второ число:");
                    double b = double.Parse(Console.ReadLine());

                    if (znak == "+")
                        Console.WriteLine("Резултат: " + k.Sabirane(a, b));
                    else if (znak == "-")
                        Console.WriteLine("Резултат: " + k.Izvazhdane(a, b));
                    else if (znak == "*")
                        Console.WriteLine("Резултат: " + k.Umnozhenie(a, b));
                    else if (znak == "/" && b != 0)
                        Console.WriteLine("Резултат: " + k.Delenie(a, b));
                    else if (znak == "%" && b != 0)
                        Console.WriteLine("Резултат: " + k.Ostatak(a, b));
                    else
                        Console.WriteLine("Грешно действие!");
                }
                else if (izbor == 2)
                {
                    Console.WriteLine("1 - Сума с ДДС");
                    Console.WriteLine("2 - Сума без ДДС");

                    int vid = int.Parse(Console.ReadLine());

                    Console.WriteLine("Въведи сума:");
                    decimal suma = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Въведи процент ДДС:");
                    decimal procent = decimal.Parse(Console.ReadLine());

                    if (vid == 1)
                        Console.WriteLine("Сума с ДДС: " + d.SasDDS(suma, procent));
                    else if (vid == 2 && procent >= 0)
                        Console.WriteLine("Сума без ДДС: " + d.BezDDS(suma, procent));
                    else
                        Console.WriteLine("Грешен избор!");
                }
                else
                {
                    Console.WriteLine("Грешен избор!");
                }
            }
        }
    }
}

    


