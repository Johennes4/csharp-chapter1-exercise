using System;

namespace data_type_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();
            int rectLength = int.Parse(length);
            int rectWidth = int.Parse(width);
            int area = rectLength * rectWidth;
            Console.WriteLine("The area of the rectangle is: " + area);

            Console.WriteLine("How many miles did you drive on your trip?");
            string mi = Console.ReadLine();
            int miles = Int32.Parse(mi);

            Console.WriteLine("How many gallons of gas did you use?");
            string gal = Console.ReadLine();
            int gallons = Int32.Parse(gal);

            int mpg = miles / gallons;
            Console.WriteLine("The MPG for the trip was: " + mpg);



            string alice = @"Alice was beginning to get very tired of sitting by her sister on the
                bank, and of having nothing to do: once or twice she had peeped into the
                book her sister was reading, but it had no pictures or conversations in
                it, 'and what is the use of a book,' thought Alice 'without pictures or
                conversation?'";

            Console.WriteLine(alice);
            Console.WriteLine("What word would you like to look for in the sentence above?");
            string searchTerm = Console.ReadLine();
            string compSearchTerm = searchTerm.ToLower();
            string compAlice = alice.ToLower();

            if (compAlice.IndexOf(compSearchTerm, 0) != -1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            int searchTermIndex = compAlice.IndexOf(searchTerm);
            Console.WriteLine(searchTermIndex);
            int searchTermLength = searchTerm.Length;
            Console.WriteLine(searchTermLength);
        }
    }
}
