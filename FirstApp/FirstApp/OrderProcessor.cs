using System;

namespace FirstApp
{
    public class OrderProcessor
    {
        private readonly IShipCalc _shipCalc;

        public OrderProcessor(IShipCalc sCalc)
        {
            _shipCalc = sCalc; ;

        }
        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("nope cant do operation");
            }

            order.shipment = new Shipment
            {
                cost = _shipCalc.CalculateShipping(order),
                shippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}

