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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
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
        public DbSet<ENumType> ENumTypes { get; set; }
        public DbSet<ENumData> ENumDatas { get; set; }
        public DbSet<Member> Members { get; set; }  
        public DbSet<MemberNominee> MemberNominees { get; set; }
        public DbSet<MemberGuardian> MemberGuardians { get; set; }
    }
}
