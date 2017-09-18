using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class LocalViewRow : BaseRow
    {
        [Description("Basic data for BUY orders")]
        public List<Order> BuyOrders { get; set; }

        [Description("Basic data for SELL orders")]
        public List<Order> SellOrders { get; set; }

        [Description("ID of the contract that this order belongs to")]
        public string ContractId { get; set; }

        [Description("The timestamp at which this order was received by the system")]
        public DateTimeOffset? CreatedAt { get; set; }

        [Description("ID of the delivery area that this local view represents")]
        public long DeliveryAreaId { get; set; }

        [Description("FOK — Fill or Kill, IOC — Immediate or Cancel, NON — No specific restriction, AON — All or none")]
        public string OrderExecutionRestriction { get; set; }
    }
}
