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
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PersonTitle> PersonTitles { get; set; }
        public DbSet<OrganisationDetail> OrganisationDetails { get; set; }
        public DbSet<OrganisationBranchDetail> OrganisationBranchDetails { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankBranch> BankBranches { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }

    }
}
