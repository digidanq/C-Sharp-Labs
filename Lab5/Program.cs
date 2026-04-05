using System;
using System.Data;
using System.Diagnostics;

namespace ConsoleApp1
{
    // Zadanie 1
    //enum Color
    //{
    //    Green,
    //    Yellow,
    //    Black,
    //}
    //internal class Rectangle
    //{

    //    public Color color { get; set; }
    //    public int widht { get; set; }
    //    public int height { get; set; }

    //    public Rectangle()
    //    {
    //        color = Color.Green;
    //        widht = 6;
    //        height = 8;
    //    }

    //    public Rectangle(Color color, int widht, int height)
    //    {
    //        this.color = color;
    //        this.widht = widht;
    //        this.height = height;
    //    }

    //    public override string ToString()
    //    {
    //        return $"\nProstokat o parametrach: \nColor - {color};\nWidth - {widht};\nHeight - {height}.";
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle r1 = new Rectangle();
    //        Console.WriteLine(r1.ToString());
    //        r1.color = (Color)2; //Color.Yellow;
    //        Console.WriteLine("\nPo zmienie koloru: ");
    //        Console.WriteLine(r1.ToString());
    //    }
    //}
    // =================================================================================================================


    // Zadanie 2
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Begining Main");

    //        try
    //        {
    //            string texts = null;
    //            Program p1 = new Program();
    //            p1.Main2(texts);
    //        }
    //        catch (NullReferenceException ex)
    //        {
    //            Console.WriteLine("NullReferenceException caught!");
    //            Console.WriteLine(ex.StackTrace);
    //            throw new Exception("I'm from block catch", ex);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.ToString());
    //            Console.WriteLine(ex.StackTrace);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Finally block executed!");
    //        }
    //    }

    //    public void Main2(string napis)
    //    {
    //        Console.WriteLine("Dludosc napisu {0}", napis.Length);
    //    }
    //    public static void Main2a(string napis)
    //    {
    //        Console.WriteLine("Dludosc napisu {0}", napis.Length);
    //    }

    //}
    // =================================================================================================================


    // Zadanie 3
    class MyException : Exception
    {
        public MyException()
        {
            
        }

        public MyException(string message) : base(message)
        {
            
        }
    }
    internal class Number
        {
        int m_1;
        int m_2;

        public Number()
        {
            m_1 = 50;
            m_2 = 23;
        }

        public Number(int m_1, int m_2)
        {
            this.m_1 = m_1;
            this.m_2 = m_2;
        }

        public int Operation(char oper)
        {
            int result = 0;
                         
            switch (oper)
            {
                case '+':
                    result = this.m_1 + this.m_2;
                    break;
                case '-':
                    result = this.m_1 - this.m_2;
                    break;
                case '*':
                    result = this.m_1 * this.m_2;
                    break;
                case '/':
                    if (this.m_2 == 0)
                    {
                        throw new MyException("Devide by zero");
                    }
                    result = this.m_1 / this.m_2;
                    break;
                default:
                    throw new MyException("Unknown operation.");
                        
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Number n1 = new Number(42, 0);
                Console.WriteLine(n1.Operation('+'));
                Console.WriteLine(n1.Operation('-'));
                Console.WriteLine(n1.Operation('*'));
                Console.WriteLine(n1.Operation('/'));
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Remember, we can't devide by zero.");
            }

            Console.WriteLine("End Main.");
        }
    }
    
}
