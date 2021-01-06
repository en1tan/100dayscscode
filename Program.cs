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

            Console.WriteLine("Hello C#!");
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine(1101);
            Console.WriteLine(1001);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Math.Sqrt(12345));
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("What's your age: ");
            int Age = int.Parse(Console.ReadLine()) + dateTime.AddYears(9).Year;
            Console.WriteLine("C# is a programming language while .NET Framework is a framework built on C# for running .NET code");
            Console.WriteLine("Python, Java, Javascript, PHP, Ruby, C++"); 
            Console.WriteLine("You will be {0} years old", Age);
        }
    }
}
