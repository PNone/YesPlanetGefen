using System;

namespace YesPlanetGefen
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie("Barbie", 1, 30, 90);
            Console.WriteLine(m1.CalculateEndOfMovieAsString()); // 03:00
            Movie m2 = new Movie("Barbie 2: the Rise of Ken", 1, 30, 60 * 24); // A whole day
            Console.WriteLine(m2.CalculateEndOfMovieAsString()); // 01:30
            Movie m3 = new Movie("Barbie 3: Ken robs Kanye West", 23, 45, 150); // A whole day
            Console.WriteLine(m3.CalculateEndOfMovieAsString()); // 02:15
            Movie m4 = new Movie("Barbie 4: Ken Sells His Kidney to Pay Alimony", 8, 10, 210); // A whole day
            Console.WriteLine(m4.CalculateEndOfMovieAsString()); // 11:40
            Movie m5 = new Movie("Barbie 5: Ken Buys Twitter From Elon Musk to Promote NFT Scams", 8, 01, 123); // A whole day
            Console.WriteLine(m5.CalculateEndOfMovieAsString()); // 10:04
        }


    }
}
