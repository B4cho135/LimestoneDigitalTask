using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class ContractEntity : BaseEntity<int>
    {
		public string ContractCode { get; set; }
		public ContractDataEntity ContractData { get; set; }
		public List<IndividualEntity> Individual { get; set; } = new List<IndividualEntity>();
		public List<SubjectRoleEntity> SubjectRole { get; set; } = new List<SubjectRoleEntity>();
	}
}
