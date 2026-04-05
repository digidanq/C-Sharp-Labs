using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

//namespace LabApp
//{
//    public class Person
//    {
//        private string FirstName { get; set; }
//        private string LastName { get; set; }
//        private int Age { get; set; }

//        public Person(string firstName, string lastName, int age)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Age = age;
//        }

//        public virtual void View()
//        {
//            Console.WriteLine($"{FirstName} {LastName}, wiek: {Age}.");
//        }
//    }

//    public class Book
//    {
//        protected string Title { get; set; }
//        protected Person Author { get; set; }
//        protected int Year { get; set; }

//        public Book(string title, Person author, int year)
//        {
//            Title = title;
//            Author = author;
//            Year = year;
//        }

//        public virtual void View()
//        {
//            Console.WriteLine($"\"{Title}\" ({Year}), author: ");
//            Author.View();
//        }

//        public string GetTitle() => Title;

//    }

//    public class AdventureBook : Book
//    {
//        private string Setting { get; set; }

//        public AdventureBook(string title, Person author, int year, string setting) : base(title, author, year) {
//            Setting = setting;
//        }

//        public override void View() {
//            base.View();
//            Console.WriteLine($"Typ: Przygodowa, Miejsce akcji: {Setting}");
//        }
//    }

//    public class DocumentaryBook : Book
//    {
//        private string Topic { get; set; }

//        public DocumentaryBook(string title, Person author, int year, string topic) : base(title, author, year)
//        {
//            Topic = topic;
//        }

//        public override void View()
//        {
//            base.View();
//            Console.WriteLine($"Typ: Dokumentalna, Temat: {Topic}");
//        }
//    }

//    public class Reader : Person
//    {
//        private List<Book> booksRead = new List<Book>();

//        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
//        {

//        }

//        public void AddBook(Book book)
//        {
//            booksRead.Add(book);
//        }

//        public void ViewBook()
//        {
//            Console.WriteLine("Preczytanie ksiazki: ");
//            foreach (var b in booksRead)
//            {
//                b.View();
//            }
//        }

//        public override void View()
//        {
//            base.View();
//            ViewBook();
//        }

//        // helper dla Reviewer
//        protected List<Book> GetBooks() => booksRead;
//    }

//    public class Reviewer : Reader
//    {
//        private Random random = new Random();

//        public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
//        {

//        }

//        public void Wypisz()
//        {
//            Console.WriteLine("Recenzje: ");
//            foreach(var book in GetBooks())
//            {
//                Console.WriteLine($"- {book.GetTitle()} | Ocena: {random.Next(1, 11)}");
//            }
//        }

//        public override void View()
//        {
//            base.View();
//            Wypisz();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Autorzy
//            Person a1 = new Person("Adam", "Mickiewicz", 50);
//            Person a2 = new Person("Henryk", "Sienkiewicz", 60);

//            // Ksiazki
//            Book b1 = new Book("Pan Tadeusz", a1, 1834);
//            AdventureBook b2 = new AdventureBook("W pustyni i w puszczy", a2, 1911, "Afryka");
//            DocumentaryBook b3 = new DocumentaryBook("Historia Polski", a2, 1900, "Polska XIX wieku");

//            // Czytelnicy
//            Reader r1 = new Reader("Jan", "Kowalski", 25);
//            r1.AddBook(b1);
//            r1.AddBook(b2);

//            Reviewer rev1 = new Reviewer("Anna", "Nowak", 30);
//            rev1.AddBook(b3);
//            rev1.AddBook(b1);

//            // Lista person
//            List<Person> list = new List<Person> { r1, rev1 };

//            foreach(var p in list)
//            {
//                p.View();
//                Console.WriteLine();
//            }

//        }
//    }
//}



namespace CarApp
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        public int przebieg;

        public int Przebieg
        {
            get => przebieg;
            set => przebieg = value < 0 ? 0 : value;
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rok, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rok;
            Przebieg = przebieg;
        }

        public Samochod()
        {
            Console.WriteLine("Podaj marke: ");
            Marka = Console.ReadLine();
            Console.WriteLine("Podaj model: ");
            Model = Console.ReadLine();
            Console.WriteLine("Podaj nadwozie: ");
            Nadwozie = Console.ReadLine();
            Console.WriteLine("Podaj kolor: ");
            Kolor = Console.ReadLine();
            Console.WriteLine("Podaj rok produkcji: ");
            RokProdukcji = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj przebieg: ");
            Przebieg = int.Parse(Console.ReadLine());

        }

        public virtual void View()
        {
            Console.WriteLine($"{Marka} {Model}, {Nadwozie}, {Kolor}, rok: {RokProdukcji}, przebieg: {Przebieg} km");
        }
    }

    public class SamochodOsobowy : Samochod
    {
        public double Waga { get; set; }
        public double PojemnoscSilnika { get; set; }
        public int IloscOsob { get; set; }

        public SamochodOsobowy() : base() 
        {
            Console.WriteLine("Podaj wage (2 - 4.5 t): ");
            Waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pojemnosc silnika (0.8 - 3.0): ");
            PojemnoscSilnika = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilosc osob: ");
            IloscOsob = int.Parse(Console.ReadLine());
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Waga: {Waga} t, Silnik: {PojemnoscSilnika}, Osoby: {IloscOsob} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SamochodOsobowy so = new SamochodOsobowy();

            Samochod s1 = new Samochod("Toyota", "Corolla", "Sedan", "Czerwony", 2020, 120000);
            Samochod s2 = new Samochod();

            Console.WriteLine("\nSamochody: ");
            so.View();
            s1.View();
            s2.View();
        }
    }
}
