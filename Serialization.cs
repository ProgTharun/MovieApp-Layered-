using System;
using System.Configuration;
using System.Text.Json;

public class Serialization
{
    private static string filePath = @"C:\Users\Tharu\source\repos.json";

    public static void Serialize(List<Movie> movies)
    {

        var json = JsonSerializer.Serialize(movies);
        File.WriteAllText(filePath, json);

    }

    public static List<Movie> DeserializeMovies()
    {
        if (!File.Exists(filePath))
        {
            return new List<Movie>();
        }
        var json = File.ReadAllText(filePath);
        var movies = JsonSerializer.Deserialize<List<Movie>>(json);

        return movies ?? new List<Movie>();
    }
}
