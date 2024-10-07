using System;

namespace Movie_Class_Library
{
    public class FindMovieByNameException : Exception
    {
        public FindMovieByNameException(string message) : base(message) { }
    }
}