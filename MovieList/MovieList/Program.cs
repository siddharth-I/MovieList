using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie();
            movie1.Title = "Aliens";
            movie1.Category = "scifi";

            Movie movie2 = new Movie();
            movie2.Title = "Predator";
            movie2.Category = "scifi";

            Movie movie3 = new Movie();
            movie3.Title = "Terminator";
            movie3.Category = "scifi";

            Movie movie4 = new Movie();
            movie4.Title = "Aliens";
            movie4.Category = "scifi";

            Movie movie5 = new Movie();
            movie5.Title = "Aliens";
            movie5.Category = "scifi";

            Movie movie6 = new Movie();
            movie6.Title = "Aliens";
            movie6.Category = "scifi";

            Movie movie7 = new Movie();
            movie7.Title = "Aliens";
            movie7.Category = "scifi";

            Movie movie8 = new Movie();
            movie8.Title = "Aliens";
            movie8.Category = "scifi";

            Movie movie9 = new Movie();
            movie9.Title = "Aliens";
            movie9.Category = "scifi";

            Movie movie10 = new Movie();
            movie10.Title = "Aliens";
            movie10.Category = "scifi";
            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine("There are 100 movies in this list.\nWhat category are you interested in?");
            string result = Console.ReadLine();
        }
    }
}
