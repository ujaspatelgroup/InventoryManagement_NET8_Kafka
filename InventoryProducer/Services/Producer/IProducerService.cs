namespace InventoryProducer.Services.Producer
{
    public interface IProducerService
    {
        public Task ProduceAsync(string topic, string message);
    }
}
