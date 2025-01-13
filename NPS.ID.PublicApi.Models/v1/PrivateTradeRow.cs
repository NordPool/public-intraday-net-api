/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System.Collections.Generic;
using NPS.ID.PublicApi.Models.v1.trade;

namespace Nordpool.ID.PublicApi.v1
{
	public class PrivateTradeRow  : Base.BaseTradeRow
	{
		/// <summary>Basic data about orders participated in the trade</summary>
		public List<Nordpool.ID.PublicApi.v1.Trade.Leg.PrivateTradeLeg> Legs { get; set; }

		public long CancellationFee { get; set; }

		/// <summary>There is a deadline for trade cancellation, in accordance with market rules</summary>
		public string CancellationDeadLine { get; set; }

		public long RevisionNo { get; set; }
		
		public TradeContractPhaseEnum ContractPhase { get; set; }

	}
}
