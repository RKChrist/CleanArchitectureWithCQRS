using Domain.Entities.Common;
using Domain.Entities.Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Auth
{
    public class Group : BaseIdEntity
    {

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        public List<LinkUserGroup> Users { get; set; } = new List<LinkUserGroup>();
    }
}
