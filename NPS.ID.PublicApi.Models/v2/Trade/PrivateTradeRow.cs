using System.Collections.Generic;
using NPS.ID.PublicApi.Models.v1.trade;
using NPS.ID.PublicApi.Models.v2.Trade.Leg;

namespace NPS.ID.PublicApi.Models.v2.Trade
{
    public class PrivateTradeRow : BaseTradeRow
    {
        public TradeContractPhaseEnum ContractPhase { get; set; }
        
        public List<PrivateTradeLeg> Legs { get; set; }
    }
}