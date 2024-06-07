using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Project
{
    public class EntrepriseOverview : BaseIdEntity
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

    }
}
