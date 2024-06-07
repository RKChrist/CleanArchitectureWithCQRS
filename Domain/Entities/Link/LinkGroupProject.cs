using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Entities.Link
{
    public class LinkGroupProject : BaseIdEntity
    {
        public int GroupId { get; set; }
        public int ProjectId { get; set; }
        public Group? Group { get; set; }
        public Project.Project? Project { get; set; }

    }
}
