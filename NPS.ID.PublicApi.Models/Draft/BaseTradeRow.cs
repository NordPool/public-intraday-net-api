using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class BaseTradeRow<LEG> where LEG : BaseTradeLeg
    {

        [Description("The timestamp at which this trade was updated (in case of trade cancellation).")]
        public DateTimeOffset UpdatedAt { get; set; }

        [Description("Trade ID")]
        public string TradeId { get; set; }

        [Description("The timestamp when the trade was created.")]
        public DateTimeOffset TradeTime { get; set; }

        [Description("COMPLETED - the trade is completed, CANCELLED - the trade is cancelled.")]
        public TradeStateEnum State { get; set; }

        [Description("Basic data about orders participated in the trade")]
        public List<LEG> Legs { get; set; }

        [Description("Currency code")]
        public string Currency { get; set; }

        [Description("Sequence number for tracking received ticker events")]
        public long EventSequenceNo { get; set; }

        [Description("A flag that indicates if this trade should no longer be visible on the market (old trade).")]
        public bool Deleted { get; set; }

        [Description("A medium length display name for the contract.")]
        public string MediumDisplayName { get; set; }
    }
}
