using Microsoft.Extensions.Caching.Distributed;

namespace Bookify.Infrastructure.Caching;

public static class CacheOptions
{
    public static DistributedCacheEntryOptions DefaultExpirations => new()
    {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1)
    };

    public static DistributedCacheEntryOptions Create(TimeSpan? expiration) => 
        expiration is not null ? 
            new DistributedCacheEntryOptions { AbsoluteExpirationRelativeToNow = expiration } : 
            DefaultExpirations;

}
