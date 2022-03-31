using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing.Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping
{
    internal class OrderBilledHandler:IHandleMessages<OrderBilled>
    {
        private static ILog log = LogManager.GetLogger(typeof(OrderBilledHandler));

        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderBilled, OrderId = {message.OrderId} - Should we ship now?");

            var orderBilled = new OrderBilled
            {
                OrderId = Guid.NewGuid().ToString()
            };

            return Task.CompletedTask;
        }
    }
}
