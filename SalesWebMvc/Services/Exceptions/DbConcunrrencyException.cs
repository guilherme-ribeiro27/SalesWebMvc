using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcunrrencyException : ApplicationException
    {
        public DbConcunrrencyException(string message) : base(message) { }
    }
}
