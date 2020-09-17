/*
 Author: Brett Hartman
 Date: 9/16/20
 Comments: This C# Console application code is for Tech Assingment #2B.
           It demonstrates the use of Conditional Statements.
*/

using Microsoft.VisualBasic.CompilerServices;
using System;

namespace TechProject2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tell user to enter the grade they expect
            Console.WriteLine("Enter the grade you expect to get in ISM 4300: ");

            // Make sure they know it must be an Integer between 0 and 100.
            Console.WriteLine("Must be an Integer between 0 and 100!");

            // Hoping this gets me a 3 out of 3!
            Console.WriteLine("OR!");
            Console.WriteLine("Enter '101' to see what I'm going to get on this assignment");

            // Use Try-Catch block to validate input
            try
            {
                // Receive input from user
                string input = Console.ReadLine();

                // Define variable for input value
                int input_value = int.Parse(input);

                // If, else if, else if, else if statement to determine which grade they expect.

                // If input_value is between 93 and 100 then yield A.
                if ((input_value >= 93) && (input_value <= 100))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get an A!");
                    Console.WriteLine("Good Luck!");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 90 and 92 then yield A-
                else if ((input_value >= 90) && (input_value <= 92))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get an A-!");
                    Console.WriteLine("Good Luck!");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 87 and 89 then yield B+
                else if ((input_value >= 87) && (input_value <= 89))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a B+!");
                    Console.WriteLine("Good Luck!");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 83 and 86 then yield B
                else if ((input_value >= 83) && (input_value <= 86))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a B!");
                    Console.WriteLine("Good Luck!");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 80 and 82 then yield B-
                else if ((input_value >= 80) && (input_value <= 82))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a B-!");
                    Console.WriteLine("Good Luck!");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 77 and 79 then yield C+
                else if ((input_value >= 77) && (input_value <= 79))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a C+!");
                    Console.WriteLine("Come on that's basically a B-.");
                    Console.WriteLine("Just try a little harder!");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 73 and 76 then yield C
                else if ((input_value >= 73) && (input_value <= 76))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a C!");
                    Console.WriteLine("I guess that's good enough.");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 70 and 72 then yield C-
                else if ((input_value >= 70) && (input_value <= 72))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a C-!");
                    Console.WriteLine("Whew that's pretty close...");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 67 and 69 then yield D+
                else if((input_value >= 67) && (input_value <= 69))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a D+!");
                    Console.WriteLine("Maybe show up to class more?");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 63 and 66 yield D
                else if((input_value >= 63) && (input_value <= 66))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a D...");
                    Console.WriteLine("So you're not even going to try...");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is between 60 and 62 yield D-
                else if((input_value >= 60) && (input_value <= 62))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get a D-...");
                    Console.WriteLine("So you're really not even going to try...");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is less than 59 yield F
                else if((input_value >= 0) && (input_value <= 59))
                {
                    // Tell the user their grade
                    Console.WriteLine("You expect to get an F...");
                    Console.WriteLine("Why are you even here?");

                    // Ask user to press key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    // Take input from user
                    Console.ReadKey(true);
                }

                // If input_value is 101 then...
                else if(input_value == 101)
                {
                    Console.WriteLine("You're going to get a 3 on this assingment!");
                    Console.WriteLine("Congratulations!");

                    // Ask User to press key to exit the program
                    Console.WriteLine("Press any key to exit the program and try again...");

                    // Take input from user
                    Console.ReadKey(true);
                }

                // Display Message for not entering an integer between 0 and 100 or 101
                else
                {
                    Console.WriteLine("Please enter an integer between 0 and 100...");

                    // Ask User to press key to exit the program
                    Console.WriteLine("Press any key to exit the program and try again...");

                    // Take input from user
                    Console.ReadKey(true);
                }
            } // End Try 

            catch
            {
                Console.WriteLine("Please enter and integer value and try again ...");

                // Ask user to press key to exit program
                Console.WriteLine("Press any key to exit the program and try again ...");

                // Take input from user
                Console.ReadKey(true);
            } // End Catch
        } // End Main
    } // End Class
} // End Namespace
