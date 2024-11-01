namespace PackageDelivery;

public interface DeliveryRepository
{
    void Add(Delivery delivery);
    Delivery? Get(long id);
}

public class InMemoryDeliveryRepository : DeliveryRepository
{
    private readonly List<Delivery> deliveries = new();
    
    public void Add(Delivery delivery)
    {
        deliveries.Add(delivery);
    }

    public Delivery? Get(long id)
    {
        return deliveries.SingleOrDefault(delivery => delivery.Id == id);
    }
}