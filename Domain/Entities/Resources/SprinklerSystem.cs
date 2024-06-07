using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resources
{
    public class SprinklerSystem : Material
    {
        public string Manufacturer { get; set; } = null!;
        public string Model { get; set; } = null!; // e.g., K-Mic Mist Sprayer, Mini Sprinkler
        public string Type { get; set; } = null!;  // e.g., Micro-Sprinkler, Rotating Head
    }
}
