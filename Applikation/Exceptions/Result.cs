using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class Result<TError, TValue> where TError : Error
    {
        private readonly ErrorReason? _error;
        private readonly string _errorMessage;
        private readonly object? _value;
        public bool IsSuccess => _value is not null;

        public Result(TValue value)
        {
            _value = value;
        }

        public Result(TError error)
        {
            _error = error.Reason;
            _errorMessage = error.Message;
        }

        public new TValue? Value => _value is TValue value ? value : default;
        public new TError? Error => _error as TError;

        public static implicit operator Result<TError, TValue>(TValue value)
        {
            return new Result<TError, TValue>(value);
        }

        public static implicit operator Result<TError, TValue>(TError error)
        {
            return new Result<TError, TValue>(error);
        }

        public TResult Match<TResult>(Func<TError, TResult> failure, Func<TValue, TResult> success)
        {
            // Here we can throw exception because it's a failure case, not an error
            // It's normally impossible to get an exception from here, but compiler needs it
            return IsSuccess
              ? success(Value ?? throw new NullReferenceException())
              : failure(Error ?? throw new NullReferenceException());
        }
    }
}
