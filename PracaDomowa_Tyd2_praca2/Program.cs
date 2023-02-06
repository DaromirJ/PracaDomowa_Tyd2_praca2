using System;

namespace PracaDomowa
{
    public class Tyd2Praca2
    {
        static void Main(string[] args)
        {
            
            //Zadanie 1 (porównanie dwóch liczb)
            { 
                int a;
                int b;

                Console.WriteLine("Zadanie 1 (porównanie dwóch liczb)");

                Console.WriteLine("Podaj pierwszą liczbę całkowitą");
                int.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Podaj drugą liczbę całkowitą");
                int.TryParse(Console.ReadLine(), out b);

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

            //Zadanie 2 (czy liczba jest parzysta)
            {
                int numb;

                Console.WriteLine("Zadanie 2 (czy liczba jest parzysta)");

                Console.WriteLine("Podaj dowolną liczbę całkowitą");
                int.TryParse(Console.ReadLine(), out numb);

                if (numb % 2 == 0) 
                {
                    Console.WriteLine($"Liczba {numb} jest liczbą parzysta");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Liczba {numb} jest liczbą nieparzysta");
                    Console.ReadLine();
                }
            }

            //Zadanie 3 (czy liczba jest ujemna czy dodatnia)
            {
                int numb;

                Console.WriteLine("Zadanie 3 (czy liczba jest ujemna czy dodatnia)");

                Console.WriteLine("Podaj dowolną liczbę całkowitą");
                int.TryParse(Console.ReadLine(), out numb);


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
            
            //Zadanie 4 (czy podany rok jest przestępny)
            {
                int year;

                Console.WriteLine("Zadanie 4 (czy podany rok jest przestępny)");

                Console.WriteLine("Podaj dowolną rok, a sprawdzę czy to rok przestępny.");
                int.TryParse(Console.ReadLine(), out year);

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
            
            //Zadanie 5 (czy możesz się ubiegać o stanowisko: posła, sentaora, premiera, prezydenta?)
            {
                int age;

                Console.WriteLine("Zadanie 5 (czy możesz się ubiegać o stanowisko: posła, sentaora, premiera, prezydenta?)");

                Console.WriteLine("Podaj twój wiek.");
                int.TryParse(Console.ReadLine(), out age);

                string posel = age >= 21 ? "\r\n posła" : "";
                string senat = age >= 30 ? "\r\n senatora \r\n premiera" : "";
                string president = age >= 35 ? "\r\n prezydenta" : "";

                Console.WriteLine($"Masz {age} lat, więc możesz się ubiegać o stanowisko: {posel}{senat}{president}");
                Console.ReadLine();                
            }
            
            //Zadanie 6 (Kategorie wzrostu)
            {
                int growth;

                Console.WriteLine("Zadanie 6 (Jakiej kategorii jest twój wzrost?)");

                Console.WriteLine("Podaj twój wzrost w centymetrach.");
                int.TryParse(Console.ReadLine(), out growth);

                string result = growth switch
                {
                    > 200 => "bardzo wysoki",
                    > 180 => "wysoki",
                    > 168 => "średniego wzrostu",
                    > 150 => "niskiego wzrostu",
                    > 140 => "kurduplem",
                    <= 140 => "karłem",
                };

                Console.WriteLine($"Masz {growth} cm wzrostu, więc jesteś {result}");
                Console.ReadLine();
            }
            
            //Zadanie 7 (Największa z 3-ech liczb)
            {
            Console.WriteLine("Zadanie 7 (Największa z 3-ech liczb?)");

                Console.WriteLine("Podaj 3 dowolne liczby całkowite: ");
                Console.WriteLine("Liczba 1: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Liczba 2: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Liczba 3: ");
                int number3 = int.Parse(Console.ReadLine());

                int maxNumber = 0;
                {
                    if (number1 > number2) 
                    {
                        maxNumber = number1;
                    }
                    else
                    {
                        maxNumber = number2;
                    }
                    if (maxNumber < number3)
                    {
                        maxNumber = number3;
                    }
                }

                Console.WriteLine($"Liczba {maxNumber} jest największą z podanych liczb");
            }
            
            //Zadanie 8 (prawo do miejsca na studiach)
            {
                Console.WriteLine("Zadanie 8 (prawo do miejsca na studiach)");

                Console.WriteLine($"By sprawdzić czy możesz ubiegać się o miejsce na studiach \r\npodaj oceny z matury z podanych niżej przedmiotów: ");
                Console.WriteLine("z matematyki: ");
                int matma = int.Parse(Console.ReadLine());

                Console.WriteLine("z fizyki: ");
                int fizyka = int.Parse(Console.ReadLine());

                Console.WriteLine("z chemii: ");
                int chemia = int.Parse(Console.ReadLine());

                string result;
                {
                    if ((matma > 70 && fizyka > 55 && chemia >45 && (matma + fizyka + chemia > 180)) 
                        || (matma + fizyka > 150) 
                        || (matma + chemia >150) )
                    {
                        result = "może się";
                    }
                    else
                    {
                        result = "nie może się";
                    }
                }

                Console.WriteLine($"Kandydat {result} ubiegać o miejsce na studiach");
            }
            
            //Zadanie 9 (określenie typu temperatury)
            {
                Console.WriteLine("Zadanie 9 (określenie typu temperatury)");

                Console.WriteLine($"Podaj jaka panuje temperatura na dworze:");
                int temp = int.Parse(Console.ReadLine());

                string result;
                {
                    if (temp >= 40)
                    {
                        result = "A weź wyprowadzam się na Alaskę";
                    }
                    else if (temp >= 30)
                    {
                        result = "Zaczyna być słabo, bo gorąco";
                    }
                    else if(temp >= 20)
                    {
                        result = "W sam raz";
                    }
                    else if(temp >= 10)
                    {
                        result = "Chłodno";
                    }
                    else if(temp >= 0)
                    {
                        result = "Zimno";
                    }
                    else
                    {
                        result = "Cholernie piździ";
                    }
                }

                Console.WriteLine($"Jaka pogoda? {result}");
            }
            
            //Zadanie 10 (możliwość zbudowania trójkąta z podanych długości boków)
            {
                Console.WriteLine("Zadanie 10 (możliwość zbudowania trójkąta z podanych długości boków)");

                Console.WriteLine($"Sprawdzimy czy z podanych przez ciebie długości boków można zbudować trójkąt.\r\nPodaj długości następujących boków:");
                Console.WriteLine("długość boku a: ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("długość boku b: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("długość boku c: ");
                int c = int.Parse(Console.ReadLine());

                string result;
                {
                    if ((a + b > c) || (a + c > b) || (b + c > a))
                    {
                        result = "można";
                    }
                    else
                    {
                        result = "nie można";
                    }
                }

                Console.WriteLine($"Z podanych długości boków {result} zbudować trójką");
            }
            
            //Zadanie 11 (Kategorie wzrostu)
            {
                int ocena;

                Console.WriteLine("Zadanie 11 (ocena słownie)");

                Console.WriteLine("Podaj otrzymaną ocenę");
                int.TryParse(Console.ReadLine(), out ocena);

                switch (ocena)
                {
                    case 1:
                        Console.WriteLine("Niedostateczny");
                        break;
                    case 2:
                        Console.WriteLine("Dopuszczający");
                        break;
                    case 3:
                        Console.WriteLine("Dostateczny");
                        break;
                    case 4:
                        Console.WriteLine("Dobry");
                        break;
                    case 5:
                        Console.WriteLine("Bardzo dobry");
                        break;
                    case 6:
                        Console.WriteLine("Celujący");
                        break;
                }

                Console.ReadLine();
            }
            
            //Zadanie 12 (Nazwy dni tygodnia)
            {
                int dayNo;

                Console.WriteLine("Zadanie 12 (Nazwy dni tygodnia)");

                Console.WriteLine("Podaj numer dnia tygodnia, a podam ci jego nazwę");
                int.TryParse(Console.ReadLine(), out dayNo);

                switch (dayNo)
                {
                    case 1:
                        Console.WriteLine("Dzień nr 1, to poniedziałek");
                        break;
                    case 2:
                        Console.WriteLine("Dzień nr 2, to wtorek");
                        break;
                    case 3:
                        Console.WriteLine("Dzień nr 3, to środa");
                        break;
                    case 4:
                        Console.WriteLine("Dzień nr 4, to czwartek");
                        break;
                    case 5:
                        Console.WriteLine("Dzień nr 5, to piątek");
                        break;
                    case 6:
                        Console.WriteLine("Dzień nr 6, to sobota");
                        break;
                    case 7:
                        Console.WriteLine("Dzień nr 7, to niedziela");
                        break;
                }

                Console.ReadLine();
            }
            
            //Zadanie 13 (operacje na dwóch podanych liczbach)
            {
                Console.WriteLine("Podaj pierwszą liczbę całkowitą:");
                int no1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę całkowitą:");
                int no2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj numer operacji do wykonania:");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");

                int operation = int.Parse(Console.ReadLine());

                double result;

                switch (operation)
                {
                    case 1:
                        result = no1 + no2;
                        Console.WriteLine($"Twój wynik to: {result}");
                        break;
                    case 2:
                        result = no1 - no2;
                        Console.WriteLine($"Twój wynik to: {result}");
                        break;
                    case 3:
                        result = no1 * no2;
                        Console.WriteLine($"Twój wynik to: {result}");
                        break;
                    case 4:
                        if (no2 == 0)
                        {
                            Console.WriteLine("Dzielenie przez 0 jest zabronione!");
                            break;
                        }
                        result = (double)no1 / no2;
                        Console.WriteLine($"Twój wynik to: {result}");
                        break;
                    default:
                        Console.WriteLine("Wybrana operacja nie jest dostępna");
                        break;
                }
            }


        }
    }
}