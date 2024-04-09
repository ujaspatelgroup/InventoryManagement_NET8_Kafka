namespace InventoryConsumer.Models
{
    public class InventoryRequest
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }
}
