using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class CurrencyEntity : BaseEntity<int>
    {
        public string Currency { get; set; }
    }
}
