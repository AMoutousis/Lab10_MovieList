using System;
using System.Collections.Generic;

namespace Lab10_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> Movies = new List<Movie>();

            Movies.Add(new Movie("Toy Story", "Animated"));
            Movies.Add(new Movie("Friday the 13th", "Horror"));
            Movies.Add(new Movie("Alien", "Horror"));
            Movies.Add(new Movie("Joker", "Drama"));
            Movies.Add(new Movie("1917", "Drama"));
            Movies.Add(new Movie("Big Hero 6", "Animated"));
            Movies.Add(new Movie("Star Trek", "Scifi"));
            Movies.Add(new Movie("Spider-Man: Homecoming", "Scifi"));
            Movies.Add(new Movie("The Martian", "Scifi"));
            Movies.Add(new Movie("Interstellar", "Scifi"));

            bool validSelection = true;

            int input;

            PrintMovieList(Movies);


            while (validSelection)
            {
                try
                {
                    Console.WriteLine("dWhat category of Movies would you like to see?");
                    Console.WriteLine("Enter 1 for Animated. Enter 2 for Drama. Enter 3 for Horror. Enter 4 for Scifi");
                    Console.WriteLine("If you would like to quit, enter 5");

                    while (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine("Please enter a number between 1-5");

                    }

                    if (input >= 1 && input <= 5)
                    {

                        if (input == 1)
                        {
                            foreach (Movie category in Movies)
                            {
                                if (category.Category == "Animated")
                                {
                                    category.PrintMovie();
                                }
                            }
                        }
                        else if (input == 2)
                        {
                            foreach (Movie category in Movies)
                            {
                                if (category.Category == "Drama")
                                { 
                                    category.PrintMovie();
                                }
                            }
                        }
                        else if (input == 3)
                        {
                            foreach (Movie category in Movies)
                            {
                                if (category.Category == "Horror")
                                {
                                    category.PrintMovie();
                                }
                            }
                        }
                        else if (input == 4)
                        {
                            foreach (Movie category in Movies)
                            {
                                if (category.Category == "Scifi")
                                {
                                    category.PrintMovie();
                                }
                            }
                        }
                        else if (input == 5)
                        {
                            validSelection = false;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-4");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                        validSelection = false;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter a number between 1-4");
                    Console.WriteLine("Please enter a number between 1-4");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public static void PrintMovieList(List<Movie> Movies)
        {
            foreach (Movie name in Movies)
            {
                name.PrintMovie();
            }
        }
        public static List<Movie> PrintMovieCategory(string cat)
        {
            List<Movie> movieByCategory = new List<Movie>();

            foreach (Movie category in movieByCategory)
            {
                if (category.Category == cat)
                {
                    movieByCategory.Add(category);
                }
            }

            return movieByCategory;
        }
    }
}
