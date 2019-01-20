using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace NUBE.DAL
{
    public class NUBEMembershipDBContext : DbContext
    {
        public NUBEMembershipDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Relationship> Relationships { get; set; }
    }
}
