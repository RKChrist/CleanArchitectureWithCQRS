using Domain.Entities.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resources
{
    public abstract class Material : BaseResource
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
        public string SAPNumber { get; set; } = null!;
        public string VVSNumber { get; set; } = null!;
        public string DBNumber { get; set; } = null!;
        public List<LinkMaterialPhoto> MaterialPhotos { get; set; } = new List<LinkMaterialPhoto>();
    }
}
