﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Billing.Messages
{
    public class OrderBilled:IEvent
    {
        public string OrderId { get; set; }
    }
}
