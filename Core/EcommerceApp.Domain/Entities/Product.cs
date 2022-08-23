namespace EcommerceApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
