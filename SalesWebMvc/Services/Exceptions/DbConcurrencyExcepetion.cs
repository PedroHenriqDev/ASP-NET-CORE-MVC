using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyExcepetion : ApplicationException
    {
        public DbConcurrencyExcepetion(string message) : base(message)
        {
        }
    }
}
