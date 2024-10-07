using System;

    [Serializable]
    public class Movie
    {
        public double MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public double MovieYear { get; set; }

        public Movie(double movieid, string moviename, string moviegenre, double movieyear)
        {
            MovieId = movieid;
            MovieName = moviename;
            MovieGenre = moviegenre;
            MovieYear = movieyear;
        }

        public override string ToString()
        {
            return $"MovieId::{MovieId}\n" +
                   $"MovieName::{MovieName}\n" +
                   $"MovieGener::{MovieGenre}\n" +
                   $"MovieYear::{MovieYear}\n";
        }
    }

