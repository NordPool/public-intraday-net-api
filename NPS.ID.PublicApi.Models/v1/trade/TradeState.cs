/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	/// <summary>COMPLETED - the trade is completed, CANCELLED - the trade is cancelled.</summary>
	public enum TradeState
	{
		COMPLETED,
		DISPUTED,
		NOT_CANCELLED,
		CANCELLED,
	}
}
