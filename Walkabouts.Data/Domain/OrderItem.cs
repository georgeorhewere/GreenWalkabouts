namespace Walkabouts.Data.Domain
{
    public class OrderItem : BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public long? ShoppingCartId { get; set; }

    }
}