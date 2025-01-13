/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace Nordpool.ID.PublicApi.v1.Trade.leg.LegOwnershipEnum
{
	/// <summary>OWN_BUY, OWN_SELL - the leg (order) is placed by current user and is on Buy or Sell side, respectively. COMPANY_BUY, COMPANY_SELL - the order was placed by different user from same Company.Order is on Buy or Sell side, respectively. OTHER - the order was placed by different company than user's.</summary>
	public enum LegOwnerShip 
	{
		OWN_BUY,
		OWN_SELL,
		COMPANY_BUY,
		COMPANY_SELL,
		OTHER,
	}
}
