//Introduction to C# 

//In this session we will learn 
//Basic structure of c# program
//What is namespace 
//Purpose of Main method

/*using System declaration
The namespace declaration. using System. indicates that you are using the System namespace.

A namespace is used to organize your code and is collection of classes.
interfaces, structs, enums and delegates.

Main method is the entry point into your application.

*/
//Sample Program ====>

//Namespace declaration
//using System;

//class Program
//{
//    public static void Main()
//    {
//        //Write to console 
//        Console.WriteLine("Hello I'm Sanjeev");
//    }
//}



//namespace Part1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}


//using System;
//class Program
//{
//    static void Main1()
//    {
//        Console.WriteLine("Hello Sanjeev Kumar");

//    }
//    static void Main()
//    {
//        Console.WriteLine("Welcome to C# Training");
//        Main1();

//    }
//}

using System;
class Engineer
{
    //static void Main()
    //{
    //    Console.WriteLine("Hello Sanjeev Developer");
    //    Main1();
    //}

    //static void Main1()
    //{
    //    Console.WriteLine("Hello Sanjeev bro");
    //}

    public void DisplayTitle()
    {
        Console.WriteLine("Sanjeev Kumar Full Stack Engineer");
    }
    public void DisplayRole()
    {
        Console.WriteLine("Sanjeev Kumar Software Engineer");
    }
}

class Sanjeev
{
    static void Main()
    {
        Engineer Sanjeev = new Engineer();
        Sanjeev.DisplayTitle();
        Sanjeev.DisplayRole();
    }
}
