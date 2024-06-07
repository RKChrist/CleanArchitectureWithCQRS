using Domain.Entities.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Project
{
    public class AgreementPlan : BaseEntity
    {

        public string Description { get; set; } = string.Empty;
        public AgreementPlanStatus Status { get; set; }
        public DateTime? LastAnswerDate { get; set; }

        public string? Reference { get; set; } = string.Empty;

        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

    }
}
