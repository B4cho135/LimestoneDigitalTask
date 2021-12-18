﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.CreditInfo
{
    public class CurrentBalanceEntity : BaseEntity<int>
    {
        public string Value { get; set; }
        public string Currency { get; set; }
    }
}
