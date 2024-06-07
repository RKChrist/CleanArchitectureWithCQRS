using Domain.Entities.Photos;
using Domain.Entities.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Link
{
    public class LinkMaterialPhoto
    {
        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
