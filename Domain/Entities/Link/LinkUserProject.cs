﻿using Domain.Entities.Auth;
using Domain.Entities.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Link
{
    public class LinkUserProject : BaseIdEntity
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        public AccessNiveau AccessNiveau { get; set; }

        public User? User { get; set; }

        public Project.Project? Project { get; set; }
    }
}
