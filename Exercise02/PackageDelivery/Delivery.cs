namespace PackageDelivery;

public class Delivery
{
    public long Id { get; }
    public string ContactEmail { get; }
    public DateTime TimeOfDelivery { get; }
    public bool HasArrived { get; }
    public bool OnTime { get; }
    
    public Delivery(long id, string contactEmail, DateTime timeOfDelivery)
    {
        Id = id;
        ContactEmail = contactEmail;
        TimeOfDelivery = timeOfDelivery;
    }
}