using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        public static string FirstName { get; set; } = "Pascal";

        public static string LastName { get; }

        public static DateTime CurrentDateAndTime => DateTime.Now;

        static Program()
        {
            LastName = "Günti";
        }

        public static int LenghtOfDict(Dictionary<string, string> d) => d.Keys.Count;

        static void Main(string[] args)
        {
            WriteLine(nameof(Console));
            WriteLine(FirstName);
            WriteLine(LastName);
            WriteLine(CurrentDateAndTime.ToString());

            WriteLine($"Pascals Name: {FirstName} and the App Name is {nameof(Program)}");

            int? textLength = FirstName?.Length;
            FirstName = null;
            int? textLength2 = FirstName?.Length;
            int? textLength3 = FirstName?.Length ?? 0;

            WriteLine(textLength);
            WriteLine(textLength2);
            WriteLine(textLength3);

            var dict = new Dictionary<string, string> { ["A"] = "A Value", ["B"] = "B Value" };
            WriteLine(dict["B"]);

            WriteLine(LenghtOfDict(dict));

            try
            {
                FirstName = "Test";
                throw new ArgumentException();
            }
            catch(Exception) when (FirstName != null)
            {
                WriteLine("CATCHED YOU!!!");
                WriteLine(new Helper().SaySomething());
            }

            ReadLine();
        }
    }
}
