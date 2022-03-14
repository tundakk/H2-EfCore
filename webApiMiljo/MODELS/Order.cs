namespace webApiMiljo.MODELS
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFulfilled { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        //navigational properties
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
