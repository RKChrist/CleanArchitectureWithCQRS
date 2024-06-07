using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum ErrorReason
    {
        None = 0,
        NotFound = 1,
        Invalid = 2,
        Unauthorized = 3,
        Forbidden = 4,
        Conflict = 5,
        InternalServerError = 6,
        DuplicateId = 7,

    }
}
