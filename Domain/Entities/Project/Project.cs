using Domain.Entities.Auth;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Project
{
    public class Project : BaseIdEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string Number { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string? Location { get; set; }

        public int CompanyId { get; set; }
        public Company? Company { get; set; }

        

    }
}
