using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resources
{
    public class SprinklerHead : Material
    {
        public string SprayPattern { get; set; } = null!; // e.g., Full Cone, Hollow Cone
        public string ActivationTemperature { get; set; } = null!; // Temperature at which it activates
    }
}
