//In this session we will learn 
//Built-in types in c#
//Boolean type - only true or false
//Integral Types - sbyte, byte, short, ushort, int, uint, long, ulong, char
//Floating Types - float and doubles
//Decimal Types
//String Type 
//Escape Sequences in c#
//Verbatim Litaral

//namespace Part4
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            // 1. Escape Sequence Example (\")
//            string Name = "Sanjeev";
//            string Name = "\"Sanjeev\"";
//            Console.WriteLine(Name);

//            // 2. New Line Escape Sequence (\n)
//            string MultiLine = "One\nTwo\nThree";
//            Console.WriteLine(MultiLine);

//            // 3. File path using Escape Sequence (\\)
//            string FilePath1 = "C:\\Sanjeev\\CSharp\\Training\\Lessons";
//            Console.WriteLine(FilePath1);

//            // 4. File path using Verbatim Literal (@)
//            // Verbatim literal escape sequences ko ignore karta hai aur string ko as-is print karta hai
//            string FilePath2 = @"C:\Sanjeev\CSharp\Training\Lessons";
//            Console.WriteLine(FilePath2);
//        }
//    }
//}

//Vervatim Litaral: 
Verbatim Litaral is a string with an @ symbol prefix, as in @"Hello".

Verbatim Literal make escape sequences translate as normal printable characters to enhance readability.

Practical Example: 
Without Verbatim Literal: "C:\\Sanjeev\\CSharp\\Training\\Lessons";  - Less Readable
With Verbatim Literal: @"C:\Sanjeev\CSharp\Training\Lessons";  - Better Readable

//using System;

//class Calculator
//{
//    // Method 1: Do integers add karta hai
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    // Method 2: Teen integers add karta hai (Parameter count alag hai)
//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    // Method 3: Double values add karta hai (Data type alag hai)
//    public double Add(double a, double b)
//    {
//        return a + b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calc = new Calculator();

//        Console.WriteLine(calc.Add(5, 10));          // Output: 15
//        Console.WriteLine(calc.Add(5, 10, 20));      // Output: 35
//        Console.WriteLine(calc.Add(5.5, 4.5));       // Output: 10
//    }
//}


using System;

class Printer
{
    // Method 1: Text print karne ke liye
    public void Print(string text)
    {
        Console.WriteLine("Printing Text: " + text);
    }

    // Method 2: Number print karne ke liye (Parameter type alag hai)
    public void Print(int number)
    {
        Console.WriteLine("Printing Number: " + number);
    }
}

class Program
{
    static void Main()
    {
        Printer p = new Printer();
        p.Print("Hello C#"); // Output: Printing Text: Hello C#
        p.Print(100);        // Output: Printing Number: 100
    }
}

