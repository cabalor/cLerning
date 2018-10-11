namespace FirstApp
{

       public interface IShipCalc
    {

        float CalculateShipping(Order order);


    }
        


    public class ShipCalc : IShipCalc
    {
        public float CalculateShipping(Order order)
        {
            if(order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }
            return 0;
        }


    }
}
