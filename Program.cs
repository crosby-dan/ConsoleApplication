using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //#1 get name
            string myName;
            Console.WriteLine("What is your name -->");
            myName = Console.ReadLine();
            if (myName.Length == 0) { Console.WriteLine("Invalid name, program aborted."); return; }

            //#2 get location
            string myLocation;
            Console.WriteLine("In what state or country do you live-->\b");
            myLocation = Console.ReadLine();
            if (myLocation.Length == 0) { Console.WriteLine("Invalid location, program aborted."); return; }

            //#3 interpolated output
            Console.WriteLine($"My name is {myName}, I am from {myLocation}");

            //#4 Print current date
            string myDate = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine($"The date is {myDate}");

            //#5 Days until Christmas
            DateTime today = DateTime.Now;
            DateTime nextChristmas = DateTime.Parse("12/25/" + today.Year);
            int daysToChristmas = (nextChristmas - today).Days;
            if (today < nextChristmas)
            {
                Console.WriteLine($"There are {(nextChristmas - today).Days} days until Christmas.");
            }
            else
            {
                Console.WriteLine("The premise of the assignment question is invalid for dates after 12/24/19.");
            }

            //#6 - Code from2.1 of Yellow Pages book

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //#7.1 Provide appropriate text labels when requesting dimensional input.
            Console.WriteLine("For glazing, enter a width (i.e. 2.5) -->");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("For glazing, enter a height (i.e. 2.5) -->");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            if (myLocation.Length == 0) { Console.WriteLine("Invalid location, program aborted."); Console.ReadKey(); return; }

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            //#7.2 Add a pause
            Console.WriteLine("Thank you for running this program, press a key to exit.");
            Console.ReadKey();
        }
    }

}
