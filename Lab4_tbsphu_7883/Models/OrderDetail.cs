namespace Lab4_tbsphu_7883.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Order? Order { get; set; }
        public  Product? Product { get; set; }
        public decimal Price { get; internal set; }
    }
}
