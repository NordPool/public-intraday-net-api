using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class OrderEntry
    {

        [Description("The portfolio id of the current order")]
        public string PortfolioId { get; set; }

        [Description("The contract ids that the current order should be placed on. For limit orders, only one value is allowed, for custom block orders all the contracts that the block spans should be included")]
        public string[] ContractIds { get; set; }

        [Description("The delivery area id of the current order.")]
        public long DeliveryAreaId { get; set; }

        [Description("BUY/SELL")]
        public OrderSideEnum Side { get; set; }

        [Description("For iceberg orders only; the size of one clip")]
        public long? ClipSize { get; set; }

        [Description("For iceberg orders only; the price change after each clip is consumed")]
        public long? ClipPriceChange { get; set; }

        [Description("LIMIT, ICEBERG, USER_DEFINED_BLOCK")]
        public OrderTypeEnum OrderType { get; set; }

        [Description("Price in Euro cents or pence (based on currency for the area)")]
        public long UnitPrice { get; set; }

        [Description("Quantity in kW")]
        public long Quantity { get; set; }

        [Description("IOC, FOK, AON, NON, GTD, GFS")]
        public TimeInForceEnum TimeInForce { get; set; }

        [Description("“AON” (All or None): The order must be filled completely or not at all. The order stays in the order book until it is executed or removed by the system or user. This execution restriction can be used only in combination with User Defined Block Orders. “NON”: No restrictions.")]
        public ExecutionRestrictionEnum ExecutionRestriction { get; set; }

        [Description("If timeInForce is set to GTD (Good Till Date), the expireTime will determine when the order expires")]
        public DateTimeOffset ExpireTime { get; set; }

        [Description("ACTI — Active, IACT — Closed, matched(will never be reopened), HIBE — Deactivated(can be reopened)")]
        public OrderStateEnum State { get; set; }

        [Description("UUID for the order, provided by the client to track their own orders")]
        public string ClientOrderId { get; set; }
    }
}
