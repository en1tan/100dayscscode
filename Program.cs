using System;

namespace tutorial
{
    class Program
    {

        static void Main(string[] args)
        {

            string FirstName = "John";
            string LastName = "Doe";
            DateTime dateTime = new DateTime();

            Console.WriteLine("Hello World!");
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(1101);
            Console.WriteLine(1001);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Math.Sqrt(12345));
            Console.Write("What's your age: ");
            int Age = int.Parse(Console.ReadLine()) + dateTime.AddYears(9).Year;
            Console.WriteLine("You will be {0} years old", Age);

        }
    }
}
