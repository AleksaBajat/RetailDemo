using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Sales
{
    public class PlaceOrderHandler:IHandleMessages<PlaceOrder>
    {
        private static ILog log = LogManager.GetLogger<PlaceOrderHandler>(); // Expensive

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Recieved PlaceOrder , OrderId = {message.OrderId}");

            var orderPlaced = new OrderPlaced()
            {
                OrderId = message.OrderId
            };

            return context.Publish(orderPlaced);
        }
    }
}
