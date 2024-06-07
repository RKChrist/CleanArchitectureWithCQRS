using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum ProjectStatus
    {
        Draft = 1,
        Active = 2,
        NeedsConfirmation = 3,
        Completed = 4,
        Cancelled = 5,
        Removed = 6
    }
}
