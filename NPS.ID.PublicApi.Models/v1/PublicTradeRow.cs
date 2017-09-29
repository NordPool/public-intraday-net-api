/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	public class PublicTradeRow
	{
		public System.DateTimeOffset UpdatedAt { get; set; }

		/// <summary>Trade ID</summary>
		public string TradeId { get; set; }

		public System.DateTimeOffset TradeTime { get; set; }

		public TradeState TradeState { get; set; }

		/// <summary>Basic data about orders participated in the trade</summary>
		public System.Collections.Generic.List<PublicTradeLeg> Legs { get; set; }

		/// <summary>Currency code</summary>
		public string Currency { get; set; }

		public long EventSequenceNo { get; set; }

		/// <summary>A flag that indicates if this trade should no longer be visible on the market (old trade).</summary>
		public bool Deleted { get; set; }

		/// <summary>A medium length display name for the contract.</summary>
		public string MediumDisplayName { get; set; }

	}
}
