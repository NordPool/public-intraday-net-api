/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */


namespace Nordpool.ID.PublicApi.v1.Contract
{
	/// <summary>Type of product that this contract belongs to</summary>
	public enum ProductType 
	{
		P15MIN,
		P30MIN,
		P60MIN,
		BLOCK_2H,
		BLOCK_4H,
		DON,
		DB34,
		DP,
		DEP,
		DB,
		CUSTOM_BLOCK,
	}
}
