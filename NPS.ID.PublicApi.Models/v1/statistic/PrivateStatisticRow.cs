/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;

namespace Nordpool.ID.PublicApi.v1.Statistic
{
	public class PrivateStatisticRow : BaseStatisticRow
	{
		public string PortfolioId { get; set; }
		
		public long? OwnBuyQuantity { get; set; }
		
		public long? OwnBuyAveragePrice { get; set; }
		
		public long? OwnSellQuantity { get; set; }
		
		public long? OwnSellAveragePrice { get; set; }
		
		public long? NetQuantity { get; set; }
		
		public long? NetPosition { get; set; }
		
		public DateTimeOffset? LastTradeTime { get; set; }
		
		public bool Deleted { get; set; }
	}
}
