using Domain.Entities.Auth;
using Domain.Entities.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Link
{
    public class LinkUserGroup : BaseIdEntity
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }

        public AccessNiveau AccessNiveau { get; set; }

        public User? User { get; set; }

        public Group? Group { get; set; }
    }
}
