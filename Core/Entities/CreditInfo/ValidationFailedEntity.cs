using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class ValidationFailedEntity : BaseEntity<int>
    {
        public string ContractCode { get; set; }
        public string ValidationError { get; set; }
        public string XmlData { get; set; }
    }
}
