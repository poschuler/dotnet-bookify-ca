using System;
using Bookify.Domain.Apartments;

namespace Bookify.Application.UnitTests.Apartments;

public class ApartmentData
{
    public static Apartment Create() => new Apartment(
        Guid.NewGuid(),
        new Name("Test apartment"),
        new Description("Test description"),
        new Address("Country", "State", "ZipCode", "City", "Street"),
        new Money(100.0m, Currency.Usd),
        Money.Zero(),
        []);

}
