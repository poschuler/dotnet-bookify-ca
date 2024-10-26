using System;
using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public static class BookingErrors
{
    public static Error NotFound = new(
        "Booking.NotFound",
        "The booking with the specified indentifier was not found");

    public static Error Overlap = new(
        "Booking.Overlap",
        "The current booking is overlapping with and existing one");

    public static Error NotReserved = new(
    "Booking.NotReserved",
    "The booking is not pending");

    public static Error NotConfirmed = new(
    "Booking.NotReserved",
    "The booking is not confirmed");

    public static Error AlreadyStarted = new(
    "Booking.AlreadyStarted",
    "The booking has already started");

}
