using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resources
{
    public class BaseResource : BaseIdEntity
    {
        public string Description { get; set; } = null!;
    }
}
