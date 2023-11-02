using System;

/*
===============================================================================
PROJECT 03: DATA TYPES
===============================================================================
Objective:
- Understand and practice using different data types in C#.

Main Tasks:
1. Create an 'integer' variable and assign it a whole number.
2. Create a 'double' variable and assign it a decimal number.
3. Create a 'boolean' variable and assign it either true or false.
4. Output a single message that includes all three of your variables.
   (e.g., "There are 27 days until Christmas", "Avatar scored 7.8 on IMDb", "Door locked: false").
5. Make the program wait for input at the end using 'Console.ReadLine();'.

Questions:
1. What is the best data type for a whole number?
2. What are some data types you could use for decimal numbers?

Extension Tasks:
1. Use Google to find out what other data types are in C#, then have a go at using them.
2. Find out how to join variables to strings using "String Interpolation".

Example:
- Below is an example of creating a double precision floating point number and outputting it to the console:

    double preciseNumber = 2.997;
    Console.WriteLine("My precise number is: " + preciseNumber);
    Console.ReadLine();

Additional Resources:
- Variables: https://www.tutorialspoint.com/csharp/csharp_variables.htm
- Data Types: https://www.tutorialspoint.com/csharp/csharp_data_types.htm
- String Interpolation: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_03_DataTypes
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("please enter a number for x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter a number for y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what operation would you like to do?");
            Console.WriteLine("1. add");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. multiply");
            Console.WriteLine("4. divide");

            string operation = Console.ReadLine();

            if (operation == "1")

            {
                Console.WriteLine($"{x} plus {y} = {x + y}");
            }
            else if (operation == "2")
            {
                Console.WriteLine($"{x} subtract {y} = {x - y}");


            }
            else if (operation == "3")
            {
                Console.WriteLine($"{x} times {y} = {x * y}");

            }
            else if (operation == "4")
            {
                Console.WriteLine($"{x} divided by {y} = {x / y}");

            }

        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
