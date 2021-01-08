using System;

namespace tutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            //    Question 1
            int firstNumber = 23;
            Console.WriteLine(firstNumber % 2 == 0 ? "even" : "odd");

            // Question 2
            int secondNumber = 35;
            int divideSecondNumberByFive = secondNumber % 5;
            int divideSecondNumberBySeven = secondNumber % 7;
            Console.WriteLine(divideSecondNumberByFive == 0 && divideSecondNumberBySeven == 0 ? "true" : "false");

            // Question 3
            int thirdNumber = 700;
            int divideThirdNumberByHundred = thirdNumber / 100;
            int findTheRemainder = divideThirdNumberByHundred % 10;
            Console.WriteLine(findTheRemainder == 7 ? "eq" : "!eq");

            // Question 4
            int num = 25;
            bool thirdBit = (num & 8) != 0;

            // Question 5
            int a = 4;
            int b = 7;
            int h = 3;
            int S = (a + b) * h / 2;
            Console.WriteLine(S);

            // Question 6
            Console.Write("Side: ");
            int side = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());
            // Calculate perimeter and area
            Console.WriteLine("Area: {0}", side * height);
            Console.WriteLine("Perimeter: {0}", 2 * (side + height));

            // Question 7
            Console.Write("Weight on Earth: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weight on the moon: {0}", weight * 0.17);
        }
    }
}
