using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUBE.DAL
{
    public class MemberFundDetail
    {
        public int Id { get; set; }
        public Decimal HQFee { get; set; }
        public Decimal EntranceFee { get; set; }
        public decimal RegistrationFee { get; set; }
        public Decimal BuildingFund { get; set; }
        public Decimal AccBenefit { get; set; }
        public Decimal BadgeAmt { get; set; }
        public Decimal ServicePeriod { get; set; }
        public Decimal SubsMonthly { get; set; }
        public Decimal SubsYtd { get; set; }
        public Decimal SubsAcc { get; set; }
        public Decimal SubsPaid { get; set; }
        public Decimal SubsDue { get; set; }
        public Decimal BFMonthly { get; set; }
        public Decimal BFYtd { get; set; }
        public Decimal BFAcc { get; set; }
        public Decimal BFPaid { get; set; }
        public Decimal BFDue { get; set; }
        public Decimal UCMonthly { get; set; }
        public Decimal UCYtd { get; set; }
        public Decimal UCAcc { get; set; }
        public Decimal UCPaid { get; set; }
        public Decimal UCDue { get; set; }
        public Decimal InsMonthly { get; set; }
        public Decimal InsYtd { get; set; }
        public Decimal InsAcc { get; set; }
        public Decimal InsPaid { get; set; }
        public Decimal InsDue { get; set; }
        public bool GE_Insurance { get; set; }
        public bool AI_Insurance { get; set; }
        public string AI_InsuranceNo { get; set; }
        public string GE_ContractNo { get; set; }
        public Decimal TakafulPaidMonths { get; set; }
        public Decimal TDF { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
