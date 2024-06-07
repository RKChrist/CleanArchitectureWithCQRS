using Domain.Entities.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Photos
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<LinkMaterialPhoto> MaterialPhotos { get; set; } = new List<LinkMaterialPhoto>();
    }
}
