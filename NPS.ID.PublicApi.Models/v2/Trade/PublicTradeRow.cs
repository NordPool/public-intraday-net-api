using System.Collections.Generic;
using Nordpool.ID.PublicApi.v1.Trade.Leg;

namespace NPS.ID.PublicApi.Models.v2.Trade
{
    public class PublicTradeRow : BaseTradeRow
    {
        /// <summary>Basic data about orders participated in the trade</summary>
        public List<PublicTradeLeg> Legs { get; set; }
    }
}