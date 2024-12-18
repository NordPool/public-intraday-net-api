/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Statistic
{
	/// <summary>Provides a list of contracts available in the area with id <deliveryAreaId> and aggregated statistical data for each contract.</summary>
	public class PublicStatisticRow  : BaseStatisticRow
	{
		public long? LastPrice { get; set; }

		public long? LastQuantity { get; set; }

		/// <summary>Time of the last trade</summary>
		public DateTimeOffset? LastTradeTime { get; set; }

		public long? HighestPrice { get; set; }

		public long? LowestPrice { get; set; }

		public long? Vwap { get; set; }

		public long? Turnover { get; set; }

		public long? DayAheadPrice { get; set; }

		/// <summary>If false: update information with the contents received, If true: delete entity indicated in the message</summary>
		public bool Deleted { get; set; }

		public Nordpool.ID.PublicApi.v1.Statistic.Tendency? Tendency { get; set; }

		/// <summary>List of trade histories</summary>
		public List<Nordpool.ID.PublicApi.v1.Statistic.TradeHistory> Histories { get; set; }

	}
}
