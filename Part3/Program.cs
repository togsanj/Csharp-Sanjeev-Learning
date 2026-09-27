/*Part 3 - Built-in types in C#
Index this session we will learn 
    Built-in types in C#
    Boolean type - only true or false
    Integrated Types - sbyte, byte, short, ushort, int, uint, long, ulong, char 
    Floating Types - float and double
    Decimal Types 
    String Type 

Escape Sequences in C# 
    Verbatim Literal
*/


namespace Part3
{
    class Program
    {
        static void Main()
        {
            // ==========================================
            // 1. BOOLEAN TYPE
            // ==========================================
            //Boolean type -only true or false
            bool IsLoggedIn = true;
            if (IsLoggedIn)
            {
                Console.WriteLine("User is Logged In");
            }
            else
            {
                Console.WriteLine("User is not Logged In");
            }

            // ==========================================
            // 2. INTEGRAL TYPES (Whole Numbers & Char)
            // ==========================================
            //Integrated Types -sbyte, byte, char, short, ushort, int, uint, long, ulong
            //sbyte temperature = -10;       // -128 to 127
            byte age = 25;                  // 0 to 255
            char grade = 'A';               // Single Character
            int charValue = grade;          // Implicit conversion (ASCII Value: 65)
            short students = 1500;          // -32,768 to 32,767
            ushort rooms = 500;             // 0 to 65,535
            int employeeId = 10245;         // -2,147,483,648 to 2,147,483,647
            uint views = 250000000;         // 0 to 4,294,967,295
            long transactionId = 9876543210123L;   // L Suffix
            ulong totalViews = 987654321012345UL;  // UL Suffix

            Console.WriteLine("\n--- Integral Values ---");
            //Console.WriteLine("Temperature: {0}", temperature);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Grade: {0} (ASCII Value: {1})", grade, charValue);
            Console.WriteLine("Students: {0}", students);
            Console.WriteLine("Rooms: {0}", rooms);
            Console.WriteLine("Employee ID: {0}", employeeId);
            Console.WriteLine("Views: {0}", views);
            Console.WriteLine("Transaction ID: {0}", transactionId);
            Console.WriteLine("Total Views: {0}", totalViews);

            // Min/Max Limits Example
            Console.WriteLine("\n--- Int Range ---");
            Console.WriteLine("int Min Value: {0}", int.MinValue);
            Console.WriteLine("int Max Value: {0}", int.MaxValue);

            // ==========================================
            // 3. FLOATING & DECIMAL TYPES
            // ==========================================
            float tempFahrenheit = 98.6f;  // 'f' or 'F' suffix (7 digits precision)
            //double distance = 125.6789D;   // Optional 'd' or 'D' suffix (15-16 digits precision)

            decimal price = 99.99m;        // 'm' or 'M' suffix (28-29 digits precision)
            decimal tax = 18.50M;
            decimal total = price + tax;

            Console.WriteLine("\n--- Floating & Decimal Values ---");
            Console.WriteLine("Float Temperature: {0}", tempFahrenheit);
            //Console.WriteLine("Double Distance: {0}", distance);
            Console.WriteLine("Decimal Total: {0}", total);

            // Float special properties
            Console.WriteLine("\n--- Float Precision Info ---");
            Console.WriteLine("float Min Value: {0}", float.MinValue);
            Console.WriteLine("float Max Value: {0}", float.MaxValue);
            Console.WriteLine("float Epsilon: {0}", float.Epsilon);


            // bool IsLoggedIn = True;
            // if(IsLoggedIn)
            // {
            // Console.WriteLine("User is Logged In");
            // }
            // else
            // {
            // Console.WriteLine("User is not Logged in");
            // }

            // 1. sbyte: Signed 8-bit integer (-128 to 127)
            // Real-world use: Temperature in Celsius (can be negative)
            // sbyte CurrentTemperature = -15;
            // Console.WriteLine("Temperature (sbyte): "+ CurrentTemperature+ "\u00B0C");
            // Console.WriteLine("Temperature (sbyte): {0}\u00B0C", CurrentTemperature);	
            // Console.WriteLine($"Temperature (sbyte): {CurrentTemperature}\u00B0C");


            // 2. byte: Unsigned 8-bit integer (0 to 255)
            // Real-world use: Age of a person
            // byte personAge = 25; 
            // Console.WriteLine("Age (byte): "+ personAge);	
            // Console.WriteLine("Age (byte): {0}", personAge);
            // Console.WriteLine($"Age (byte): {personAge}"); 


            // 3. char: 16-bit Unicode character
            // Real-world use: Grade or initial letter
            // char studentGrade = 'A';
            // Console.WriteLine("Grade: " + studentGrade);
            // Console.WriteLine("Grade: {0}", studentGrade);
            // Console.WriteLine($"Grade: {studentGrade}");


            // 4. short: Signed 16-bit integer (-32,768 to 32,767)
            // Real-world use: Number of employees in a mid-size company department
            // short departmentEmployee = 1500;
            // Console.WriteLine("Department Employee (short):" + departmentEmployee);
            // Console.WriteLine("Department Employee (short): {0}", departmentEmployee);
            // Console.WriteLine($"Department Employee (short): {departmentEmployee}");


            // 5. ushort: Unsigned 16-bit integer (0 to 65,535)
            // Real-world use: Network port number
            // ushort serverPort = 8080;
            // Console.WriteLine("Server Port (ushort): " + serverPort);
            // Console.WriteLine("Server Port (ushort): {0}", serverPort);
            // Console.WriteLine($"Server Port (ushort): {serverPort}");


            // 6. int: Signed 32-bit integer (~ -2 billion to 2 billion)[cite: 1]
            // Real-world use: Product inventory count in a warehouse
            // int inventoryStock  = 125000;
            // Console.WriteLine("Inventory Stock (int): " + inventoryStock);
            // Console.WriteLine("Inventory Stock (int): {0}", inventoryStock);
            // Console.WriteLine($"Inventory Stock (int): {inventoryStock}");


            // 7. uint: Unsigned 32-bit integer (0 to ~ 4.29 billion)[cite: 1]
            // Real-world use: Positive identification number (ID)
            // uint userId = 40293812;
            // Console.WriteLine("User ID: " + userId);
            // Console.WriteLine("User ID: {0}", userId);
            // Console.WriteLine($"User ID: {userId}"); 


            // 8. long: Signed 64-bit integer (Very large positive/negative numbers)[cite: 1]
            // Real-world use: Bank account balance or total website views
            // long totalWebsiteViews = 9876543210L; 
            // Console.WriteLine("Website Views (long): " + totalWebsiteViews);
            // Console.WriteLine("Website Views (long): {0}", totalWebsiteViews);
            // Console.WriteLine($"Website Views (long): {totalWebsiteViews}");

            // 9. ulong: Unsigned 64-bit integer (Very large positive numbers only)[cite: 1]
            // Real-world use: Unique transaction ID or global tracking numbers
            ulong globalTransactionId = 18446744073709551615UL;
            Console.WriteLine("Transaction ID: " + globalTransactionId);
            Console.WriteLine("Transaction ID: {0}", globalTransactionId);
            Console.WriteLine("Transaction ID: {globalTransactionId}");



            // 1. FLOAT EXAMPLE (4 Bytes - ~6-7 digits precision)
            // Aam taur par scientific measurements ya graphics/games mein use hota hai.
            // Float value ke aage 'f' ya 'F' lagana zaroori hota hai.
            float temperature = 98.6f;
            Console.WriteLine($"Float Temperature: {temperature} \u00B0C");
            Console.WriteLine($"float.MinValue: {float.MinValue}, float.MaxValue: {float.MaxValue}");
            Console.WriteLine($"float.Epsilon: {float.Epsilon}\n");

            // 2. DOUBLE EXAMPLE (8 Bytes - ~15-16 digits precision)
            // Yeh C# mein default floating-point type hai. Mathematical calculations ke liye best hai.
            double distance = 125.6789;
            Console.WriteLine($"Double Distance: {distance} km");
            Console.WriteLine($"double.MinValue: {double.MinValue}, double.MaxValue: {double.MaxValue}\n");

            // 3. DECIMAL EXAMPLE (16 Bytes - ~28-29 digits precision)
            // Yeh financial, banking, aur currency calculations ke liye use hota hai jahan accuracy sabse zaroori hoti hai.
            // Decimal value ke aage 'm' ya 'M' lagana zaroori hota hai.
            decimal totalAmount = 118.49m;
            Console.WriteLine($"Decimal Total: {totalAmount:C} (Currency Format)");
            Console.WriteLine($"decimal.MinValue: {decimal.MinValue}, decimal.MaxValue: {decimal.MaxValue}");

         
            Console.ReadLine();
        }
    }
}