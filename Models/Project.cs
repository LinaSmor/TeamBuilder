﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamBuilder.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
        public List<ProjectUser> Admins { get; set; }
        public List<ProjectJury> Jury { get; set; }
        public DateTime Date { get; set; }
        public List<New> News { get; set; }

        public bool IsMarksOpen { get; set; }

    }
}
