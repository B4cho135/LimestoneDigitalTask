using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class SubjectRoleEntity : BaseEntity<int>
    {
		public string CustomerCode { get; set; }
		public string RoleOfCustomer { get; set; }
		public GuaranteeAmountEntity GuaranteeAmount { get; set; }
		public int? GuaranteeAmountId { get; set; }
	}
}
