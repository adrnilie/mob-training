namespace PackageDelivery;

public class DeliveryEvent(long id, DateTime timeOfDelivery)
{
    public long Id { get; } = id;
    public DateTime TimeOfDelivery { get; } = timeOfDelivery;
}

public class DeliveryService(DeliveryRepository deliveryRepository, EmailSender emailSender)
{
    private readonly DeliveryRepository _deliveryRepository = deliveryRepository;
    private readonly EmailSender _emailSender = emailSender;

    public void UpdateDelivery(DeliveryEvent deliveryEvent)
    {}
}
