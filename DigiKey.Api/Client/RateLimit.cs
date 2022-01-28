using System;
using System.Linq;

namespace DigiKey.Api.Client
{
    public class RateLimit
    {
        public RateLimit(int retryAfter, int limit, int remaining, int reset, DateTime resetTime)
        {
            RetryAfter = retryAfter;
            Limit = limit;
            Remaining = remaining;
            Reset = reset;
            ResetTime = resetTime;
        }

        /// <summary>
        /// The seconds until you can retry the request
        /// </summary>
        public int RetryAfter { get; set; }
        /// <summary>
        /// The maximum number of requests allowed for the API, number per minute
        /// </summary>
        public int Limit { get; set; }
        /// <summary>
        /// The number of requests remaining in the current rate limit window.
        /// </summary>
        public int Remaining { get; set; }
        /// <summary>
        /// The seconds until the burst limit window resets
        /// </summary>
        public int Reset { get; set; }
        /// <summary>
        /// The time when the burst limit window resets, GMT
        /// </summary>
        public DateTime ResetTime { get; set; }
    }
}
