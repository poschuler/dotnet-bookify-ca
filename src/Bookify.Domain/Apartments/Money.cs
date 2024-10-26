namespace Bookify.Domain.Apartments;

public record class Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money first, Money second)
    {
        if (first.Currency != second.Currency)
        {
            throw new InvalidOperationException("Currency have to be equal");
        }

        return new Money(first.Amount + second.Amount, first.Currency);
    }

    public static Money Zero() => new Money(0, Currency.None);

}
