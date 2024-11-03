using Bookify.Application.Abstractions.Caching;
using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBooking;

public record class GetBookingQuery(Guid BookingId) : ICachedQuery<BookingResponse>
{
    public string CacheKey => $"booking-{BookingId}";

    public TimeSpan? Expiration => null;
}
