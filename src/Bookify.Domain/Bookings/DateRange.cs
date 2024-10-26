namespace Bookify.Domain.Bookings;

public record class DateRange
{
    private DateRange(){}

    public DateOnly Start { get; init; }

    public DateOnly End { get; init; }

    public int LegthInDays => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ArgumentException("End date precedes start date");
        }

        return new DateRange
        {
            Start = start,
            End = end
        };
    }

}