using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class OrderExecutionEntry
    {
        
        public long? EventSequenceNo { get; set; }

        public string MarketId { get; set; }

        public string TenantId { get; set; }

        public string UserId { get; set; }

        public string OrderId { get; set; }

        public long? RevisionNo { get; set; }

        [Description("Id of the previous order in this modification chain. When an order is modified and its priority changes, or partially matched, a new order Id is assigned.")]
        public string PreviousOrderId { get; set; }

        [Description("The original order id in this modification chain.")]
        public string OriginalOrderId { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        [Description("UUID for the order, provided by the client to track their own orders")]
        public string ClientOrderId { get; set; }

        [Description("The portfolio id of the current order")]
        public string PortfolioId { get; set; }

        [Description("The contract ids for current order")]
        public List<string> ContractIds { get; set; }

        [Description("The delivery area id of the current order.")]
        public long? DeliveryAreaId { get; set; }

        [Description("BUY/SELL")]
        public OrderSideEnum? Side { get; set; }

        [Description("LIMIT, ICEBERG, USER_DEFINED_BLOCK")]
        public OrderTypeEnum? OrderType { get; set; }

        [Description("Price in Euro cents or pence (based on currency for the area)")]
        public long? UnitPrice { get; set; }

        [Description("Quantity in kW")]
        public long? Quantity { get; set; }

        [Description("IOC, FOK, AON, NON, GTD, GFS")]
        public TimeInForceEnum? TimeInForce { get; set; }

        [Description("If timeInForce is set to GTD (Good Till Date), the expireTime will determine when the order expires")]
        public DateTimeOffset? ExpireTime { get; set; }

        public string Text { get; set; }

        [Description("ACTI — Active, IACT — Closed, matched(will never be reopened), HIBE — Deactivated(can be reopened)")]
        public OrderStateEnum? State { get; set; }

        [Description("Action")]
        public OrderActionEnum? Action { get; set; }

        [Description("For iceberg orders only; the size of one clip")]
        public long? ClipSize { get; set; }

        [Description("For iceberg orders only; the price change after each clip is consumed")]
        public long? ClipPriceChange { get; set; }
        public long? RemainingQuantity { get; set; }
        public List<Error> Errors { get; set; }
    }

}
