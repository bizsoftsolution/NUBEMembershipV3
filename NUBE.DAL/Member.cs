using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class Member
    {
        public int Id { get; set; }

        public char MemberType { get; set; }
        public char Gender { get; set; }
        public char Race { get; set; }
        public char MembeerStatus { get; set; }

        public string MemberNo { get; set; }
        
        public string MemberName { get; set; }        

        public bool ReJoin { get; set; }
        public bool Resign { get; set; }
        public string NRIC_O { get; set; }
        public string NRIC_N { get; set; }
        public string BFNo { get; set; }

        public string MemberName_ByBank { get; set; }
        public string NRIC_ByBank { get; set; }
        public string BankCode_ByBank { get; set; }
        public string BranchMemberCode { get; set; }

        public DateTime? DOB { get; set; }
        public DateTime? DOJ { get; set; }
        public DateTime? DOE { get; set; }
        public DateTime? DOL { get; set; }
        public DateTime? LevyPayDate { get; set; }
        public DateTime? TDFPayDate { get; set; }

        public int TotalMonthPaid { get; set; }
        public int TotalMonthDue { get; set; }

        public decimal Salary { get; set; }
        public char Levy { get; set; }
        public decimal LevyAmount { get; set; }
        public char  TDF { get; set; }
        public decimal TDFAmount { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string EMailId { get; set; }


        public int? PersonTitleId { get; set; }
        public PersonTitle PersonTitle { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }

        public int BankBranchId { get; set; }
        public BankBranch BankBranch { get; set; }

        public List<MemberNominee> MemberNominees{ get; set; }

        public MemberGuardian MemberGuardian { get; set; }
        public MemberFundDetail MemberFundDetail { get; set; }

        public string MemberCode { get; set; }

    }
}
