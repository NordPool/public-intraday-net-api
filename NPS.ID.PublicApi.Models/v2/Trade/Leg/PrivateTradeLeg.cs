using System;
using Nordpool.ID.PublicApi.v1.Order;

namespace NPS.ID.PublicApi.Models.v2.Trade.Leg
{
    public class PrivateTradeLeg : BaseTradeLeg
    {
        public string UserId { get; set; }

        public string PortfolioId { get; set; }

        public string ClientOrderId { get; set; }

        public OrderType OrderType { get; set; }

        public string OrderId { get; set; }

        public DateTimeOffset DeliveryStart { get; set; }

        public DateTimeOffset DeliveryEnd { get; set; }
    }
}