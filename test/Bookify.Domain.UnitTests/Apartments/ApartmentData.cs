using System;
using Bookify.Domain.Apartments;

namespace Bookify.Domain.UnitTests.Apartments;

public class ApartmentData
{
    public static Apartment Create(Money price, Money? cleaningFee = null) => new Apartment(
        Guid.NewGuid(),
        new Name("Test apartment"),
        new Description("Test description"),
        new Address("Country", "State", "ZipCode", "City", "Street"),
        price,
        cleaningFee ?? Money.Zero(),
        []);

}
