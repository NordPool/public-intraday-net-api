using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public abstract class BaseTradeLeg
    {
        [Description("Contract Id for the order")]
        public string ContractId { get; set; }

        [Description("Buy or Sell")]
        public OrderSideEnum Side { get; set; }

        [Description("Price")]
        public long UnitPrice { get; set; }

        [Description("Quantity")]
        public long Quantity { get; set; }

        [Description("Delivery area Id of the order.")]
        public long DeliveryAreaId { get; set; }

        [Description("true if leg is the aggressor, null if the information is unavailable (for XBID trades)")]
        public bool Aggressor { get; set; }
    }
}
