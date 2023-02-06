using System;

namespace PracaDomowa
{
    public class Tyd2Praca2
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            { 
                int a = 5;
                int b = 5;

                if (a == b)
                {
                    Console.WriteLine($"Liczby a={a} oraz b={b} są równe");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Liczby a={a} oraz b={b} są różne");
                    Console.ReadLine();
                }
            }
            
            //Zadanie 2
            {
                int numb;

                Console.WriteLine("Podaj dowolną liczbę całkowitą");
                double.TryParse(Console.ReadLine(), out numb);

                if (numb % 2 == 0) 
                {
                    Console.WriteLine($"Liczba {numb} jest parzysta");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Liczba {numb} jest nieparzysta");
                    Console.ReadLine();
                }
            }
            
            //Zadanie 3
            {
                int numb = 14;

                if (numb < 0)
                {
                    Console.WriteLine($"Liczba {numb} jest liczbą ujemną");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Liczba {numb} jest liczbą dodatnią");
                    Console.ReadLine();
                }
            }
            
            //Zadanie 4
            {
                int year = 2017;

                if (year % 4 == 0)
                {
                    Console.WriteLine($"Rok {year} jest przestępny");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Rok {year} nie jest przestępny");
                    Console.ReadLine();
                }
            }

        }
    }
}