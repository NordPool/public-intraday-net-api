using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    [Description("")]
    public class OrderModification
    {

        public long RevisionNo { get; set; }

        public string ClientOrderId { get; set; }

        public string OrderId { get; set; }

        public string PortfolioId { get; set; }

        public List<string> ContractIds { get; set; }

        public OrderTypeEnum OrderType { get; set; }

        public long UnitPrice { get; set; }

        public long Quantity { get; set; }

        public TimeInForceEnum TimeInForce { get; set; }

        public ExecutionRestrictionEnum ExecutionRestriction { get; set; }

        public DateTimeOffset ExpireTime { get; set; }

        public string Text { get; set; }

        public long ClipSize { get; set; }

        public long ClipPriceChange { get; set; }
    }
}
