using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class BalanceEntity : BaseEntity<int>
    {
        public decimal Amount { get; set; }
        public CurrencyEntity Currency { get; set; }
        public int? CurrencyId { get; set; }
    }
}
