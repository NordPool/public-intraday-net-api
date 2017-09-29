/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	/// <summary>Provides a list of contracts available in the area with id <deliveryAreaId> and aggregated statistical data for each contract.</summary>
	public class PublicStatisticRow
	{
		public long? LastPrice { get; set; }

		public long? LastQuantity { get; set; }

		/// <summary>Time of the last trade</summary>
		public System.DateTimeOffset LastTradeTime { get; set; }

		public long? HighestPrice { get; set; }

		public long? LowestPrice { get; set; }

		public long? Vwap { get; set; }

		public long? Turnover { get; set; }

		public long? DayAheadPrice { get; set; }

		public Tendency Tendency { get; set; }

		public long DeliveryAreaId { get; set; }

		/// <summary>Identifier for a contract</summary>
		public string ContractId { get; set; }

		/// <summary>Last modification time (status change) of data</summary>
		public System.DateTimeOffset UpdatedAt { get; set; }

	}
}
