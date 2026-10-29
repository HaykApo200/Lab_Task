using System;

public enum Genre
{
    Action = 1,
    Comedy,
    Drama,
    Horror,
    SciFi
}

public class Movie
{
    public int Id;
    public string Name;
    public int Year;
    public Genre Genre;
    public int Views;
    public int Likes;

    public double GetRating()
    {
        if (Views == 0) return 0;
        return Math.Sqrt(Math.Pow(Likes, 2) / Views);
    }

    public override string ToString()
    {
        return $"{Id,4}" +
               $"{Name,-15}" +
               $"{"(" + Year + ")",-8}" +
               $"{Genre.ToString(),-12}" +
               $"{GetRating(),8:F3}";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Movies count: ");
        int count = int.Parse(Console.ReadLine());
        Movie[] movies = new Movie[count];

        Console.WriteLine("Format: id,name,year,genre(1-5),views,likes");
        Console.WriteLine("Genres: 1-Action 2-Comedy 3-Drama 4-Horror 5-SciFi");

        for (int i = 0; i < count; i++)
        {
            string[] p = Console.ReadLine().Split(',');
            movies[i] = new Movie
            {
                Id = int.Parse(p[0].Trim()),
                Name = p[1].Trim(),
                Year = int.Parse(p[2].Trim()),
                Genre = (Genre)int.Parse(p[3].Trim()),
                Views = int.Parse(p[4].Trim()),
                Likes = int.Parse(p[5].Trim())
            };
        }

        Console.WriteLine();
        foreach (Movie m in movies)
            Console.WriteLine(m);
    }
}
