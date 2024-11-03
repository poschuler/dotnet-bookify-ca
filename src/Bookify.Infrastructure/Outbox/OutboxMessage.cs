using System;

namespace Bookify.Infrastructure.Outbox;

public sealed class OutboxMessage
{
    public OutboxMessage(Guid id, DateTime ocurredOnUtc, string type, string content)
    {
        Id = id;
        OcurredOnUtc = ocurredOnUtc;
        Content = content;
        Type = type;
    }

    public Guid Id { get; init; }
    public DateTime OcurredOnUtc { get; init; }
    public string Type { get; init; }

    public string Content { get; init; }

    public DateTime? ProcessedOnUtc { get; set; }

    public string? Error { get; set; }

}
