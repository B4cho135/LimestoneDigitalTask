
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class IndividualEntity : BaseEntity<int>
    {
		public string CustomerCode { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public string DateOfBirth { get; set; }
        public string NationalId { get; set; }
    }
}
