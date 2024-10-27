using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBooking;

public record class GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
