
using Amazon;
using Amazon.SimpleNotificationService;
using Contracts;
using Publisher;

var client = new AmazonSimpleNotificationServiceClient(RegionEndpoint.EUWest2);

var publisher = new SnsPublisher(client);

var custommerCreated = new CustomerCreated
{
    Id = 1,
    FullName = "Lam.nguyen",
    LifetimeSpent = 420
};

var custommerUpdated = new CustomerUpdated
{
    Id = 1,
    FullName = "Lam.nguyen2",
    LifetimeSpent = 420
};

await publisher.PublishAsync("arn:aws:sns:eu-west-2:430271205792:customer-actions",
    custommerUpdated);


