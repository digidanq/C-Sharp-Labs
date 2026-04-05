using System;
using System.Numerics;
using System.Xml.Schema;

// Zadanie 1

//public class ConsoleInput
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter number a: ");
//        string inputString = Console.ReadLine();
//        int myNumber = int.Parse(inputString);

//        Console.WriteLine("Enter number b: ");
//        string inputString1 = Console.ReadLine();
//        int myNumber1 = int.Parse(inputString1);

//        Console.WriteLine("Enter number c: ");
//        string inputString2 = Console.ReadLine();
//        int myNumber2 = int.Parse(inputString2);

//        double delta = myNumber1 * myNumber1 - 4 * myNumber * myNumber2;
//        Console.WriteLine($"\nDelta: {delta}");

//        if (delta > 0)
//        {
//            double x1 = (-myNumber1 + Math.Sqrt(delta)) / (2 * myNumber);
//            double x2 = (-myNumber1 - Math.Sqrt(delta)) / (2 * myNumber);

//            Console.WriteLine($"Equation has two real roots: ");
//            Console.WriteLine($"x1 = {x1}");
//            Console.WriteLine($"x2 = {x2}");
//        }
//        else if (delta == 0)
//        {
//            double x = (-myNumber1 / (2 * myNumber));

//            Console.WriteLine($"Equation has one real root: ");
//            Console.WriteLine($"x = {x}");
//        }
//        else {
//            Console.WriteLine("Equation has no real root (delta < 0).");
//        }
//    }
//}


// Zadanie 2

//class Calculator
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter number a: ");
//        double numberA = double.Parse(Console.ReadLine());

//        Console.WriteLine("\nEnter number b: ");
//        double numberB = double.Parse(Console.ReadLine());

//        Console.WriteLine("\nEnter mathematical operation (+, -, *, /, ^, sqrt): ");
//        string mOperation = Console.ReadLine();

//        Console.WriteLine("\nEnter the angle (in degrees): ");
//        double angle = double.Parse(Console.ReadLine());

//        // Converting angle to radians
//        double angleRad = angle * Math.PI / 180.0;
//        double resault = 0;

//        // Arithmetic operations and output of results
//        switch (mOperation) 
//        {
//            case "+":
//                Console.WriteLine($"\nYour answer: {resault = numberA + numberB}");
//                break;

//            case "-":
//                Console.WriteLine($"\nYour answer: {resault = numberA - numberB}");
//                break;

//            case "*":
//                Console.WriteLine($"\nYour answer: {resault = numberA * numberB}");
//                break;

//            case "/":
//                Console.WriteLine($"\nYour answer: {resault = numberA / numberB}");
//                break;

//            case "^":
//                double resault1 = Math.Pow(numberA, numberB);
//                Console.WriteLine($"\nYour answer: {resault1}");
//                break;

//            case "sqrt":
//                double resault2 = Math.Sqrt(numberA);
//                double resault3 = Math.Sqrt(numberB);

//                Console.WriteLine($"\nThe square root of the first number: {resault2}");
//                Console.WriteLine($"The square root of the second number: {resault3}");
//                break;
//        }

//        // Angles
//        double sin = Math.Sin(angleRad);
//        double cos = Math.Cos(angleRad);
//        double tan = Math.Tan(angleRad);

//        Console.WriteLine($"\nSin({angle}°) = {sin}");
//        Console.WriteLine($"Cos({angle}°) = {cos}");
//        Console.WriteLine($"Tan({angle}°) = {tan}");

//    }
//}


// Zadanie 3

//class Array
//{
//    static void Main()
//    {
//        double[] nums = new double[10];
//        Console.WriteLine("Enter 10 numbers: ");

//        for(int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"Number {i + 1}: ");
//            nums[i] = Convert.ToDouble(Console.ReadLine());
//        }

//        Console.WriteLine("\nArray from firts to last: ");
//        for(int i = 0; i < 10; i++)
//        {
//            Console.Write(nums[i] + " ");
//        }

//        Console.WriteLine("\nArray from last to first: ");
//        for(int i = 9; i >= 0; i--)
//        {
//            Console.Write(nums[i] + " ");
//        }

//        Console.WriteLine("\nElements with odd indexes in array: ");
//        for(int i = 1; i < 10; i += 2)
//        {
//            Console.Write(nums[i] + " ");
//        }

//        Console.WriteLine("\nElements with even indexes in array:  ");
//        for(int i = 0; i < 10; i += 2)
//        {
//            Console.Write(nums[i] + " ");
//        }

//    }
//}


// Zadanie 4

//class Array
//{
//    static void Main()
//    {
//        int[] nums = new int[10];

//        Console.WriteLine("Enter 10 numbers: ");
//        for(int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"Element {i + 1}: ");
//            nums[i] = Convert.ToInt16(Console.ReadLine());
//        }

//        int prod = 0;
//        foreach (int num in nums)
//        {
//            prod += num;
//        }
//        Console.WriteLine("\nSum of the array elements: {0}", prod);

//        int prod1 = 1;
//        foreach (int num in nums)
//        {
//            prod1 *= num;
//        }
//        Console.WriteLine("\nProduct of the array elements: {0}", prod1);

//        int average = (int)prod / nums.Length;
//        Console.WriteLine("\nAverage value of the array elements: {0}", average);

//        int max = nums[0];
//        int min = nums[0];
//        for(int i = 1; i < nums.Length; i++)
//        {
//            if (nums[i] > max)
//            {
//                max = nums[i];
//            }
//            if (nums[i] < min)
//            {
//                min = nums[i];
//            }
//        }
//        Console.WriteLine("\nMaximum value: {0}", max);
//        Console.WriteLine("\nMinimum value: {0}", min);
//    }
//}



// Zadanie 5

//class Program
//{
//    static void Main()
//    {
//        for (int i = 20; i >= 0; i--)
//        {
//            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
//                continue;

//            Console.WriteLine(i);
//        }
//    }
//}


// Zadanie 6

//class Program
//{
//    static void Main()
//    {
//        while (true)
//        {
//            Console.WriteLine($"Enter your number: ");
//            int Number = int.Parse(Console.ReadLine());

//            if (Number < 0)
//            {
//                Console.WriteLine("A negative number has been entered. Program termination.");
//                break;
//            }

//            Console.WriteLine($"Your number: {Number} \n");
//        }
//    }
//}