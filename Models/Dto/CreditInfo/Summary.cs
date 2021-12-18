using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto.CreditInfo
{
    public class Summary
    {
        public SumOfOriginalAmounts SumOfOriginalAmounts { get; set; }
        public SumOfInstallments SumOfOriginalInstallments { get; set; }
        public MaxOfOverdueBalance MaxOverdueBalance { get; set; }
    }
}
