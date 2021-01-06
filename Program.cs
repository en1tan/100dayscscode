using System;

namespace tutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            float a = 0.01f;
            float b = 0.02f;
            int hexaNum = 0x100;
            char myChar = '\u0072';
            bool isMale;
            string gender = "male";
            string firstWord = "Hello";
            string secondWord = "World";
            object theWord;
            string withQuote = "The \"use\" of quotations causes difficulties";
            string withoutQuote = "The use of quotations causes difficulties";
            int firstNum = 5;
            int secondNum = 10;
            int numToSwap = firstNum;
            firstNum = secondNum;
            secondNum = numToSwap;
            // Question 1
            Console.WriteLine("sbyte: {0}, {1}, {2}", -115, 112, -44);
            Console.WriteLine("byte: {0}, {1}", 97, 224);
            Console.WriteLine("short: {0}", -10000, 1990);
            Console.WriteLine("ushort: {0}", 52130);
            Console.WriteLine("int: {0}, {1}", -1000000, 4825932);
            Console.WriteLine("uint: {0}", 970700000);
            Console.WriteLine("long: {0}", 123456789123456789);
            //    Question 2
            Console.WriteLine("Float: {0}f,{1}f", 5, 12.345);
            Console.WriteLine("Double: {0}f, {1}f", -5.01, 8923.1234857);
            Console.WriteLine("Decimal: {0}f, {1}f", 34.567839023, 3456.091124875956542151256683467);
            // Question 3
            bool equal = Math.Abs(a - b) < 0.000001;
            Console.WriteLine("Equal?: {0}", equal);
            // Question 4
            Console.WriteLine(hexaNum);
            // Question 5
            Console.WriteLine(myChar);
            // Question 6
            if (gender == "male")
            {
                isMale = true;
                Console.WriteLine(isMale);
            }
            // Question 7
            theWord = firstWord + " " + secondWord;
            Console.WriteLine(theWord);
            // Question 8
            string otherWord = theWord.ToString();
            Console.WriteLine(otherWord);

            // Question 9
            Console.WriteLine(withoutQuote);
            Console.WriteLine(withQuote);

            // Question 10
            Console.WriteLine("    o       o");
            Console.WriteLine("   ooo     ooo");
            Console.WriteLine("  ooooo   ooooo");
            Console.WriteLine(" ooooooo oooooooo");
            Console.WriteLine("oooooooooooooooooo");
            Console.WriteLine("oooooooooooooooooo ");
            Console.WriteLine("oooooooooooooooooo ");
            Console.WriteLine(" oooooooooooooooo ");
            Console.WriteLine("  oooooooooooooo ");
            Console.WriteLine("   oooooooooooo ");
            Console.WriteLine("    oooooooooo ");
            Console.WriteLine("     oooooooo ");
            Console.WriteLine("      oooooo ");
            Console.WriteLine("       oooo ");
            Console.WriteLine("        oo ");

            // Question 11
            Console.WriteLine("          ©");
            Console.WriteLine("         ©©©");
            Console.WriteLine("        ©©©©©");
            Console.WriteLine("       ©©©©©©©");
            Console.WriteLine("      ©©©©©©©©©");
            Console.WriteLine("     ©©©©©©©©©©©");
            Console.WriteLine("    ©©©©©©©©©©©©©");
            Console.WriteLine("   ©©©©©©©©©©©©©©©");
            Console.WriteLine("  ©©©©©©©©©©©©©©©©©");
            Console.WriteLine(" ©©©©©©©©©©©©©©©©©©©");
            Console.WriteLine("©©©©©©©©©©©©©©©©©©©©©");
        }
    }
}
