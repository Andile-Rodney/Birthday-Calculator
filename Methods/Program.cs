using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string result = GetUserDateOfBirth("Rodney Mthunzi");

            Console.WriteLine(result);
            //or a shorter way to write this

            //Console.WriteLine(GetUserDateOfBirth("Rodney Mthunzi"));
            


        }

        public static string GetUserDateOfBirth(string fullName)
        {
            return fullName + " was born on Tuesday";
        }
    }
}
