using System;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp;

public class Program
{

    // Zadanie 1
    //static void Main(string[] args)
    //{
    //    Licz x = new Licz(10);
    //    Licz y = new Licz(20);

    //    x.Dodaj(7);
    //    x.Odejmij(11);
    //    x.Wyswietli();

    //    y.Dodaj(9);
    //    y.Odejmij(19);
    //    y.Wyswietli();

    //    Licz z = new Licz(50);
    //    z.Odejmij(20);
    //    z.Wyswietli();

    //}


    //Zadanie 2
    //static void Main(string[] args)
    //{
    //    int[] dane = { 2, 4, 6, 7, 8, 10, 12, 14, 16, 18 };
    //    Sumator s = new Sumator(dane);

    //    s.WypWszys();

    //    Console.WriteLine($"\nSuma wszystkich = {s.Suma()}");
    //    Console.WriteLine($"\nSuma liczb podzielnych przez 2 = {s.SumaPod2()}");
    //    Console.WriteLine($"\nLiczba elementów = {s.IleEl()}");

    //    s.WypZak(2, 8);
    //    s.WypZak(-4, 7);
    //    s.WypZak(6, 50);
    //}


    //Zadanie 3
    static void Main(string[] args)
    {
        Console.WriteLine("Wybierz sposób wprowadzania daty: ");
        Console.WriteLine("1 - Użyj lokalnej daty");
        Console.WriteLine("2 - Wprowadź swoją datę");
        Console.WriteLine("Twój wybór: ");
        string choice = Console.ReadLine();

        MyDate date;

        switch (choice) 
        {
            case "1": 
                DateTime now = DateTime.Now;
                date = new MyDate(now.Day, now.Month, now.Year);
                Console.WriteLine($"Użyto Twojej lokalnej daty: {date.GetDate()}");
                break;

            case "2":
                Console.WriteLine("Wprowadź dzień: ");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Wprowadź miesiąc: ");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Wprowadź rok: ");
                int year = int.Parse(Console.ReadLine());

                date = new MyDate(day, month, year);
                Console.WriteLine($"Twoja data: {date.GetDate()}");
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór. Używana będzie lokalna data.");
                DateTime defaultNow = DateTime.Now;
                date = new MyDate(defaultNow.Day, defaultNow.Month, defaultNow.Year);
                break;
        }

        Console.WriteLine("\nCo zrobić z datą?");
        Console.WriteLine("1 — Dodaj 1 tydzień");
        Console.WriteLine("2 - Odejmij 1 tydzień");
        Console.WriteLine("Twój wybór: ");
        string x = Console.ReadLine();

        switch (x)
        {
            case "1":
                date.AddWeek();
                break;
            case "2":
                date.SubtractWeek();
                break;
            default:
                break;
        }

        Console.WriteLine($"\nWynik: {date.GetDate()}");
    }
}

