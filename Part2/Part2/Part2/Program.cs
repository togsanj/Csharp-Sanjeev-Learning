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

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your first name");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name");
        string LastName = Console.ReadLine();

        //Console.WriteLine("Hello " + FirstName + " " + LastName);

        //Console.WriteLine("Hello {0} {1}", FirstName, LastName);

        Console.WriteLine($"Hello {FirstName} {LastName}");
    }
}

//Note: C# is case sensitive