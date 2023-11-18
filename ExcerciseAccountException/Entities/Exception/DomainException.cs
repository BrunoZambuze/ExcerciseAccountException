using System;

namespace ExcerciseAccountException.Entities.Exception
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
