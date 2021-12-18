using Models.CreditInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto.CreditInfo
{
    public class ContractDto
    {
		public string PhaseOfContract { get; set; }
		public OriginalAmount OriginalAmount { get; set; }
		public InstallmentAmount InstallmentAmount { get; set; }
		public CurrentBalance CurrentBalance { get; set; }
		public OverdueBalance OverdueBalance { get; set; }
		public string DateOfLastPayment { get; set; }
		public string NextPaymentDate { get; set; }
		public string DateAccountOpened { get; set; }
		public string RealEndDate { get; set; }
	}
}
