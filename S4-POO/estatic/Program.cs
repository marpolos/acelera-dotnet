// See https://aka.ms/new-console-template for more information
namespace course;

class Program
{
    public static void Main(string[] args)
    {
        var movie = new Movie("Matrix", "Ficção científica");

        System.Console.WriteLine(movie.Title);

        movie.Title = "Matrix 2";
        System.Console.WriteLine(movie.Title);
    }
}