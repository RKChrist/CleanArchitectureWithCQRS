using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resources
{
    public class Valve : Material
    {
        public string ValveType { get; set; } = null!;
        public string PressureRating { get; set; } = null!;
    }
}
