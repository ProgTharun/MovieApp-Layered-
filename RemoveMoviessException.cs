using System;

namespace Movie_Class_Library
{
    public class RemoveMoviessException : Exception
    {
        public RemoveMoviessException(string message) : base(message) { }
    }
}