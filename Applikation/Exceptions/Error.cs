using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public abstract record Error
    {
        public string Message { get; }

        public ErrorReason Reason { get; }

        public Error(ErrorReason reason, string message)
        {
            Message = message;
            Reason = reason;
        }
    }
    //Commonly Defined Errors
    public record NoneError() : Error(ErrorReason.None, "No error");
    public record NotFoundError(int Id) : Error(ErrorReason.NotFound, $"Element With {Id} not found");
}
