using program;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace program
{
    // Zadanie 1

    //abstract class Shape
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Width { get; set; }
    //    public int Height { get; set; }

    //    public virtual void Draw()
    //    {
    //        Console.WriteLine("I am drawing a figure.");
    //    }
    //}

    //class Rectangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("I draw a rectangle");
    //    }
    //}

    //class Triangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("I draw a triangle");
    //    }
    //}

    //class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("I draw a circle");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        List<Shape> shapes = new List<Shape>();

    //        shapes.Add(new Rectangle { X = 0, Y = 0, Width = 11, Height = 7 });
    //        shapes.Add(new Triangle { X = 8, Y = 8, Width = 14, Height = 10 });
    //        shapes.Add(new Circle { X = 4, Y = 4, Width = 9, Height = 9 });

    //        foreach (Shape shape in shapes)
    //        {
    //            shape.Draw();   
    //        }
    //    }
    //}


    // Zadanie 2

    // Base class "Osoba"
    //abstract class Osoba
    //{
    //    public string Name { get; protected set; }
    //    public string Surname { get; protected set; }
    //    public string Pesel { get; protected set; }


    //    public void SetFirstName(string name)
    //    {
    //        Name = name;
    //    }

    //    public void SetLastName(string surname)
    //    {
    //        Surname = surname;
    //    }

    //    public void SetPesel(string pesel)
    //    {
    //        Pesel = pesel;
    //    }

    //    public int GetAge(DateTime dateToCheck)
    //    {
    //        int year = int.Parse(Pesel.Substring(0, 2));
    //        int month = int.Parse(Pesel.Substring(2, 2));
    //        int day = int.Parse(Pesel.Substring(4, 2));

    //        int century = month > 20 ? 2000 : 1900;
    //        if (month > 20) month -= 20;

    //        DateTime birthDate = new DateTime(century + year, month, day);

    //        int age = dateToCheck.Year - birthDate.Year;
    //        if (dateToCheck < birthDate.AddYears(age))
    //            age--;
    //        return age;
    //    }

    //    public string GetGender()
    //    {
    //        int genderDigit = int.Parse(Pesel[9].ToString());
    //        return genderDigit % 2 == 0 ? "Woman" : "Man";
    //    }

    //    public string GetFullName()
    //    {
    //        return $"{Name} {Surname}";
    //    }

    //    public abstract string GetEducationInfo();
    //    public abstract bool CanGoAloneToHome(DateTime dateToCheck);
    //}

    //// Class "Student"
    //class Uczen : Osoba
    //{
    //    public string School {  get; private set; }
    //    public bool CanGoHomeAlone { get; private set; }

    //    public void SetSchool(string school)
    //    {
    //        School = school;
    //    }

    //    public void ChangeSchool(string newSchool)
    //    {
    //        School = newSchool;
    //    }

    //    public void SetCanGoHomeAlone(bool value)
    //    {
    //        CanGoHomeAlone = value;
    //    }

    //    public override string GetEducationInfo()
    //    {
    //        return $"School student: {School}";
    //    }

    //    public override bool CanGoAloneToHome(DateTime dateToCheck)
    //    {
    //        int age = GetAge(dateToCheck);

    //        if (age >= 12)
    //            return true;

    //        return CanGoHomeAlone;
    //    }
    //}

    ////Class "Nauczyciel"
    //class Nauczyciel : Uczen
    //{
    //    public string AcademicTitle { get; set; }
    //    public List<Uczen> SubordinatesStudents { get; set; } = new List<Uczen>();

    //    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
    //    {
    //        Console.WriteLine("Students who can go home alone: ");

    //        foreach (Uczen uczen in SubordinatesStudents)
    //        {
    //            if (uczen.CanGoAloneToHome(dateToCheck))
    //                Console.WriteLine(uczen.GetFullName());
    //        }
    //    }
    //}

    ////Main program
    //class Program
    //{
    //    static void Main()
    //    {
    //        DateTime today = DateTime.Now;

    //        Uczen u1 = new Uczen();
    //        u1.SetFirstName("Rose");
    //        u1.SetFirstName("Hudson");
    //        u1.SetPesel("11210112345");
    //        u1.SetSchool("SP 1");
    //        u1.SetCanGoHomeAlone(false);

    //        Uczen u2 = new Uczen();
    //        u2.SetFirstName("Byron");
    //        u2.SetFirstName("O’Neal");
    //        u2.SetPesel("08231554321");
    //        u2.SetSchool("SP 1");
    //        u2.SetCanGoHomeAlone(false);

    //        Uczen u3 = new Uczen();
    //        u3.SetFirstName("Annalise");
    //        u3.SetFirstName("Baldwin");
    //        u3.SetPesel("13210167890");
    //        u3.SetSchool("SP 1");
    //        u3.SetCanGoHomeAlone(true);

    //        Nauczyciel nauczyciel = new Nauczyciel();
    //        nauczyciel.SetFirstName("Iris");
    //        nauczyciel.SetFirstName("Reese");
    //        nauczyciel.AcademicTitle = "mgr";

    //        nauczyciel.SubordinatesStudents.Add(u1);
    //        nauczyciel.SubordinatesStudents.Add(u2);
    //        nauczyciel.SubordinatesStudents.Add(u3);

    //        nauczyciel.WhichStudentCanGoHomeAlone(today);
    //    }
    //}

    // Zadanie 3

    // Zadanie 3a
    interface IOsoba
    {
        string Imie { get; set; } 
        string Nazwisko {  get; set; }

        string ZwrocPelnaNazwe();
    }

    class Osoba : IOsoba
    {
        public string Imie { get; set; } 
        public string Nazwisko { get; set; } 

        public string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko}";
        } 
    }

    // Zadanie 3b, 3c
    static class OsobaExtensions
    {
        public static void WypiszOsoby(this List<IOsoba> osoby)
        {
            foreach (var osoba in osoby)
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }

        // 3c
        public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
        {
            osoby.Sort((a, b) => a.Nazwisko.CompareTo(b.Nazwisko));
        }
    }

    // Zadanie 3d
    interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
    }

    class Student : Osoba, IOsoba
    {
        public string Uczelnia { get; set; } 
        public string Kierunek { get; set; } 
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public virtual string WypiszPelnaNazweIUczelnie()
        {
            return $"{ZwrocPelnaNazwe()} - {Rok} {Kierunek} {Semestr} {Uczelnia}";
        }
    }

    // Zadanie 3e
    class StudentWSIiZ : Student
    {
        public override string WypiszPelnaNazweIUczelnie()
        {
            return $"{ZwrocPelnaNazwe()} - {Kierunek} Rok: {Rok}, Semestr: {Semestr}, {Uczelnia}";
        }
    }

    // Main program
    class Program
    {
        static void Main()
        {
            List<IOsoba> osoby = new List<IOsoba>
            {
                new Osoba { Imie = "Rose", Nazwisko = "Hudson" },
                new Osoba { Imie = "Byron", Nazwisko = "O’Neal" },
                new Osoba { Imie = "Annalise", Nazwisko = "Baldwin" }
            };

            osoby.WypiszOsoby();
            osoby.PosortujOsobyPoNazwisku();

            Console.WriteLine("\nPo sortowaniu: ");
            osoby.WypiszOsoby();

            List<StudentWSIiZ> studenci = new List<StudentWSIiZ>
            {
                new StudentWSIiZ
                {
                    Imie = "\nPiotr",
                    Nazwisko = "Mazur",
                    Uczelnia = "WSIiZ",
                    Kierunek = "IID-P",
                    Rok = 4,
                    Semestr = 8
                }
            };

            foreach (var s in studenci)
            {
                Console.WriteLine(s.WypiszPelnaNazweIUczelnie());
            }
        }
    }
}

