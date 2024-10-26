using Bookify.Domain.Apartments;

namespace Bookify.Domain.Bookings;

public record class PricingDetails
(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice
);
