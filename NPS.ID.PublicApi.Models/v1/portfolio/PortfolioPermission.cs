/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */


namespace Nordpool.ID.PublicApi.v1.Portfolio
{
	/// <summary>READ: user can view private orders and private trades, WRITE: user can view private orders and private trades. Also, user can place and modify orders and trades.</summary>
	public enum PortfolioPermission 
	{
		NONE,
		READ,
		WRITE,
	}
}
