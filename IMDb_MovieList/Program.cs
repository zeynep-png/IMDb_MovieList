using IMDb_MovieList;

using static IMDb_MovieList.Movie;

using System;
using System.Collections.Generic;
using System.Linq;

List<Movie> movieList = new List<Movie>();
//DEGİSİKLİK
bool continueAdding = true;
while (continueAdding)
{
    Console.Write("\nEnter movie name: ");
    string name = Console.ReadLine();

    Console.Write("\nEnter IMDb rating: ");
    double imdbRating = double.Parse(Console.ReadLine());

    movieList.Add(new Movie { Name = name, ImdbRating = imdbRating });

    Console.WriteLine("\nDo you want to add another movie? (y/n)");
    string response = Console.ReadLine().ToLower();

    if (response != "y")
        continueAdding = false;
}


ConsoleHelper.WriteColored("\n\n-------------  MOVIE LIST  -------------\n", ConsoleColor.Yellow);
for (int i = 0; i < movieList.Count; i++)
{
    Console.WriteLine((i + 1) + "- " + movieList[i].Name + "  IMDb Rating: " + movieList[i].ImdbRating);
}

ConsoleHelper.WriteColored("\n\n-------  IMDb 4-9 RATING MOVIES  --------\n", ConsoleColor.Cyan);

List<Movie> highRatedMovies = movieList.Where(movie => movie.ImdbRating >= 4 && movie.ImdbRating <= 9).ToList();

if (highRatedMovies.Count == 0)
{
    Console.WriteLine("No movies found with IMDb rating between 4 and 9.");
}
else
{
    for (int i = 0; i < highRatedMovies.Count; i++)
    {
        Console.WriteLine((i + 1) + "- " + highRatedMovies[i].Name + "  IMDb Rating: " + highRatedMovies[i].ImdbRating);
    }
}

ConsoleHelper.WriteColored("\n\n---------  MOVIES START WITH A  ---------\n", ConsoleColor.Red);

List<Movie> moviesStartingWithA = movieList.Where(movie => movie.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

if (moviesStartingWithA.Count == 0)
{
    Console.WriteLine("No movies found that start with 'A'.");
}
else
{
    for (int i = 0; i < moviesStartingWithA.Count; i++)
    {
        Console.WriteLine((i + 1) + "- " + moviesStartingWithA[i].Name + "  IMDb Rating: " + moviesStartingWithA[i].ImdbRating);
    }
}
