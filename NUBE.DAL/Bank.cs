using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class Bank
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public string BankCode { get; set; }
        public bool isDeleted { get; set; }

        public List<BankBranch> BankBranches { get; set; }
    }
}
