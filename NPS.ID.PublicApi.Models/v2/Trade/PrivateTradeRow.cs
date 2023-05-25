using System.Collections.Generic;
using NPS.ID.PublicApi.Models.v2.Trade.Leg;

namespace NPS.ID.PublicApi.Models.v2.Trade
{
    public class PrivateTradeRow : BaseTradeRow
    {
        public long SourceTradeId { get; set; }

        public List<PrivateTradeLeg> Legs { get; set; }
    }
}