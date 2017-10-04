/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Base
{
	/// <summary>Class with base trade fields</summary>
	public class BaseTradeRow  : BaseRow
	{
		/// <summary>Trade ID</summary>
		public string TradeId { get; set; }

		public DateTimeOffset TradeTime { get; set; }

		public Nordpool.ID.PublicApi.v1.Trade.TradeState TradeState { get; set; }

		/// <summary>Currency code</summary>
		public string Currency { get; set; }

		public long EventSequenceNo { get; set; }

		/// <summary>A flag that indicates if this trade should no longer be visible on the market (old trade).</summary>
		public bool Deleted { get; set; }

		/// <summary>A medium length display name for the contract.</summary>
		public string MediumDisplayName { get; set; }

	}
}
