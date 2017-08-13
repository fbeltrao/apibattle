namespace CustomerAPI.Models 
{
    public class OrderProcessModel
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public decimal OrderTotal { get; set; }

        // Constructor
        public OrderProcessModel(int orderID, int customerID, decimal orderTotal)
        {
            this.OrderID = orderID;
            this.CustomerID = customerID;
            this.OrderTotal = orderTotal;
        }
    }


}