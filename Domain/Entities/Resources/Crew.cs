using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resources
{
    public class Crew : BaseResource
    {
        public string Role { get; set; } = null!;
        public string Certification { get; set; } = null!;
    }
}
