using Nordpool.ID.PublicApi.v1.Order;

namespace NPS.ID.PublicApi.Models.v2.Trade.Leg
{
    public class BaseTradeLeg
    {
        public string ContractId { get; set; }
        
        public OrderSide? Side { get; set; }

        public long UnitPrice { get; set; }

        public long Quantity { get; set; }

        public long DeliveryAreaId { get; set; }
        
        public bool Aggressor { get; set; }
    }
}