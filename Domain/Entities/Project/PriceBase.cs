using Domain.Entities.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Project
{
    public class PriceBase : BaseIdEntity
    {
        public PriceReason Reason { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
