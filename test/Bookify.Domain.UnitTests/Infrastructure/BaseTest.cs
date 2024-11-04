using System;
using Bookify.Domain.Abstractions;

namespace Bookify.Domain.UnitTests.Infrastructure;

public abstract class BaseTest
{
    public static T AssertDomainEventsWasPublished<T>(Entity entity)
        where T : IDomainEvent
    {
        var domainEvent = entity.GetDomainEvents().OfType<T>().SingleOrDefault();

        if (domainEvent == null)
        {
            throw new Exception($"{typeof(T).Name} was not published");
        }

        return domainEvent;
    }

}
