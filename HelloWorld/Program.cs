using System; // Using directive


namespace HelloWorld // Namespace declaration
{ // Start namespace block
    class Program // Create class
    { // Start class block
        static void Main(string[] args) // Create Method
        { // Start method block
            Console.WriteLine("Hello World!"); // Expression statement

            // Declaring a variable
            int counter;
            //assigning a variable
            counter = 5;
            // Output value to console
            Console.WriteLine("Counter is " + counter);


            // Change counter to 7
            counter = 7;
            Console.WriteLine("Counter is " + counter);


            //Increment counter by 1
            counter++;
            Console.WriteLine("Counter is " + counter);


            //Decrement counter by 1
            counter--;
            Console.WriteLine("Counter is " + counter);


            // Multiply by 3
            counter *= 3;
            Console.WriteLine("Counter is " + counter);


            // Division by 3
            counter /= 3;
            Console.WriteLine("Counter is " + counter);


            //Modulus of 2
            counter %= 2;
            Console.WriteLine("Counter is " + counter);


        } // End method block
    } // End class block
} // End namespace block

// HOUSEKEEPING RULES
//
// 1. Using directives and statements end with ;
// 2. Namespaces, classes and methods use { }
//
