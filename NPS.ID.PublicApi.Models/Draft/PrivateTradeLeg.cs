using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class PrivateTradeLeg : BaseTradeLeg
    {
        public string PortfolioId { get; set; }
        public string RefOrderId { get; set; }
        public string UserId { get; set; }
        public long DeliveryStart { get; set; }
        public long DeliveryEnd { get; set; }
        public OrderStateEnum OrderState { get; set; }
        public OrderTypeEnum OrderType { get; set; }
        public string Text { get; set; }
        public OrderActionEnum OrderAction { get; set; }

        public TimeInForceEnum? TimeInForce { get; set; }
    }
}
