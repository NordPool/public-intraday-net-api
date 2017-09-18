using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    [Description("Provides a list of contracts available in the area with id <deliveryAreaId> and aggregated statistical data for each contract.")]
    public class PublicStatisticRow : BaseStatisticRow
    {
        [Description("Last traded price")]
        public long LastPrice { get; set; }

        [Description("Last traded quantity")]
        public long LastQuantity { get; set; }

        [Description("Time of the last trade")]
        public DateTimeOffset LastTradeTime { get; set; }

        [Description("Highest traded price")]
        public long HighestPrice { get; set; }

        [Description("Lowest traded price")]
        public long LowestPrice { get; set; }

        [Description("Volume Weighted Average Price for this contract")]
        public long Vwap { get; set; }

        [Description("Total Contract turnover")]
        public long Turnover { get; set; }

        [Description("Day Ahead Price for this contract")]
        public long? DayAheadPrice { get; set; }

        [Description("UP - Last price is higher than a previous price, DOWN - Last price is lower than a previous price, EQUAL - Last price is equal to a previous price")]
        public TendencyEnum? Tendency { get; set; }
    }
}
