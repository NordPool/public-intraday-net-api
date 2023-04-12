using System;
using Nordpool.ID.PublicApi.v1.Base;
using Nordpool.ID.PublicApi.v1.Trade;

namespace NPS.ID.PublicApi.Models.v2.Trade
{
    /// <summary>Class with base trade fields</summary>
    public class BaseTradeRow : BaseRow
    {
        public string TradeId { get; set; }

        public DateTimeOffset TradeTime { get; set; }

        public TradeState? State { get; set; }

        public Currency? Currency { get; set; }

        public long EventSequenceNo { get; set; }
        
        public long RevisionNo { get; set; }
        
        /// <summary>A medium length display name for the contract.</summary>
        public string MediumDisplayName { get; set; }
        
        public bool? SelfTrade { get; set; }
    }
}