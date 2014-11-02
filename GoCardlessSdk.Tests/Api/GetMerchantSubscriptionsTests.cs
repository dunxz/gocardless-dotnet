using System;
using GoCardlessSdk.Api;
using NUnit.Framework;

namespace GoCardlessSdk.Tests.Api
{
    public class GetMerchantSubscriptionsTests
    {
        [Test]
        public void CanFetchAndDeserializeCorrectly()
        {
            var expected = new[]
            {
                new SubscriptionResponse
                {
                    Amount = 44.0m,
                    IntervalLength = 1,
                    IntervalUnit = "month",
                    CreatedAt = DateTime.Parse("2011-09-12T13:51:30Z"),
                    Currency = "GBP",
                    Name = "London Gym Membership",
                    Description = "Entitles you to use all of the gyms around London",
                    ExpiresAt = null,
					NextIntervalStart = DateTime.Parse("2011-10-12T13:51:30Z"),
                    Id = "AJKH638A99",
                    MerchantId = "WOQRUJU9OH2HH1",
                    Status = "active",
                    UserId = "HJEH638AJD",
                    Uri = "https://gocardless.com/api/v1/subscriptions/1580",
                    SubResourceUris =
                        {
                            Bills = "https://gocardless.com/api/v1/merchants/WOQRUJU9OH2HH1/bills?source_id=1580"
                        }
                },    new SubscriptionResponse
                {
                    Amount = 44.0m,
                    IntervalLength = 1,
                    IntervalUnit = "month",
					CreatedAt = DateTime.Parse("2011-09-12T13:51:30Z"),
                    Currency = "GBP",
                    Name = "London Gym Membership",
                    Description = "Entitles you to use all of the gyms around London",
                    ExpiresAt = null,
					NextIntervalStart = DateTime.Parse("2011-10-12T13:51:30Z"),
                    Id = "AJKH638A9A",
                    MerchantId = "WOQRUJU9OH2HH1",
                    Status = "active",
                    UserId = "HJEH638AJD",
                    Uri = "https://gocardless.com/api/v1/subscriptions/1580",
                    SubResourceUris =
                        {
                            Bills = "https://gocardless.com/api/v1/merchants/WOQRUJU9OH2HH1/bills?source_id=1580"
                        }
                }

            };
            DeepAssertHelper.AssertIEnumerableDeepEquality(expected, new ApiClient("asdf").GetMerchantSubscriptions("WOQRUJU9OH2HH1"));
        }

    }
}