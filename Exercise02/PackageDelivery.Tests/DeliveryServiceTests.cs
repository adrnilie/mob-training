namespace PackageDelivery.Tests;

/*
 * Implement the Solitary tests for the package delivery service in the following order:
 *
 * On-time delivery:
 *   - update the delivery (Arrived = true, OnTime = true, TimeOfDelivery = actual time of delivery)
 *   - email to the addressee
 * Late delivery:
 *   - update the delivery (same as on-time delivery, except OnTime = false)
 * Invalid ID:
 *   - returns an error that indicates a delivery could not be found
 *
 * Implement the `DeliveryRepositoryStub` and `EmailSenderSpy` as you work your way through the tests
 */

public class DeliveryServiceTests
{
}