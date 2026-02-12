/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;

namespace Nordpool.ID.PublicApi.v1.Statistic
{
	/// <summary>
	/// Represents aggregated private statistical data for a specific contract in a delivery area,
	/// including portfolio, buy/sell quantities and prices, net position, and last trade information.
	/// </summary>
	public class PrivateStatisticRow : BaseStatisticRow
	{
		public string PortfolioId { get; set; }
		
		public long OwnBuyQuantity { get; set; }
		
		public long OwnBuyAveragePrice { get; set; }
		
		public long OwnSellQuantity { get; set; }
		
		public long OwnSellAveragePrice { get; set; }
		
		public long NetQuantity { get; set; }
		
		public long NetPosition { get; set; }
		
		/// <summary>Time of the last trade</summary>
		public DateTimeOffset LastTradeTime { get; set; }
		
		/// <summary>If false: update information with the contents received, If true: delete entity indicated in the message</summary>
		public bool Deleted { get; set; }
	}
}
