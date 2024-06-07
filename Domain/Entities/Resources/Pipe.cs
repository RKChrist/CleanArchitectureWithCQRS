using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resources
{
    public class Pipe : Material
    {
        public int OuterDiameter { get; set; } // Dy
        public int InnerDiameter { get; set; } // Di
        public int WallThickness { get; set; } // e
        public int Length { get; set; }
        public int EffectiveLength { get; set; } // L1
        public int FullLength { get; set; } // L2
        public string PressureClass { get; set; } = null!;
        public double Weight { get; set; } // Weight in kg
        public string PackagingData { get; set; } = null!;
    }

}
