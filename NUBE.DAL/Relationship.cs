﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class Relationship
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<MemberNominee> MemberNominees { get; set; }
        public List<MemberGuardian> MemberGuardians { get; set; }

    }
}
