using System;

namespace Digitalizacion.v1.Core.Exceptions
{
    public class BasicExceptions
    {
        public class NotFoundException : ApplicationException
        {
            public NotFoundException(string message) : base(message)
            {
            }
        }

        public class BadRequestException : ApplicationException
        {
            public BadRequestException() : base()
            {
            }
        }
        public class ConflictException : ApplicationException
        {
            public ConflictException(string message) : base(message)
            {
            }
        }

    }
}
