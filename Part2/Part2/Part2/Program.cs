//Reading & Writing to Console
/*
 * In this session 

    Reading from the console
    Writing to the console
    3 ways to write to console
     a) Concatenation
     b) Place holder syntax - Most prefreed
     c) Interpolation - Most prefered
*/

/*
namespace Part2
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name");

           string UserName = Console.ReadLine();

            Console.WriteLine($"Hello {UserName}");

            //Console.WriteLine("Hello {0}" + UserName);

            //Console.WriteLine("Hello " + UserName);
        }
    }
}

*/

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Please enter your first name");
//        string FirstName = Console.ReadLine();

//        Console.WriteLine("Please enter your last name");
//        string LastName = Console.ReadLine();

//        //Console.WriteLine("Hello " + FirstName + " " + LastName);

//        //Console.WriteLine("Hello {0} {1}", FirstName, LastName);

//        Console.WriteLine($"Hello {FirstName} {LastName}");
//    }
//}

//Note: C# is case sensitive 


//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter your first name: ");
//        string FirstName = Console.ReadLine();

//        Console.WriteLine("Enter your last name: ");
//        string LastName = Console.ReadLine();

//        Console.WriteLine($"Hello {FirstName} {LastName}");
//    }
//}


//##If you are sure that the user will provide input, use !

//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter your first name: ");
//        string FirstName = Console.ReadLine()!;

//        Console.WriteLine("Enter your last name: ");
//        string LastName = Console.ReadLine()!;

//        Console.WriteLine($"Hello {FirstName} {LastName}");
//    }
//}

//##If you want to prevent the user input from being empty or null, use ?? ""

//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter your first name: ");
//        string FirstName = Console.ReadLine()?? "";

//        Console.WriteLine("Enter your last name: ");
//        string LastName = Console.ReadLine() ?? "";

//        Console.WriteLine($"Hello {FirstName} {LastName}");
//    }
//}


//##If you want to allow both null and user input, use string?

//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter your first name: ");
//        string? FirstName = Console.ReadLine();

//        Console.WriteLine("Enter your last name: ");
//        string? LastName = Console.ReadLine();

//        Console.WriteLine($"Hello {FirstName} {LastName}");
//    }
//}


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your first name: ");
        string? firstName = Console.ReadLine();

        if(string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("First name is required");
            return;
        }

        Console.WriteLine("Enter your last name: ");
        string? lastName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Last name is required");
            return;
        }

        Console.WriteLine($"Hello {firstName} {lastName}");
    }
}

  