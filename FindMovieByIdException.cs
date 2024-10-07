using System;

namespace Movie_Class_Library
{
    public class FindMovieByIdException : Exception
    {
        public FindMovieByIdException(string message) : base(message) { }
    }
}