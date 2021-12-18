using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class ContractDataEntity : BaseEntity<int>
    {
		public string PhaseOfContract { get; set; }
		public OriginalAmountEntity OriginalAmount { get; set; }
		public int? OriginalAmountId { get; set; }
		public InstallmentAmountEntity InstallmentAmount { get; set; }
		public int? InstallmentAmountId { get; set; }
		public CurrentBalanceEntity CurrentBalance { get; set; }
		public int? CurrentBalanceId { get; set; }
		public OverdueBalanceEntity OverdueBalance { get; set; }
		public int? OverdueBalanceId { get; set; }
		public string DateOfLastPayment { get; set; }
		public string NextPaymentDate { get; set; }
		public string DateAccountOpened { get; set; }
		public string RealEndDate { get; set; }
	}
}
