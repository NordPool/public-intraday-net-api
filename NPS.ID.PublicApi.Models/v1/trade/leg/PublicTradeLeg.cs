/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Trade.Leg
{
	public class PublicTradeLeg  : BaseTradeLeg
	{
		public Nordpool.ID.PublicApi.v1.Trade.Leg.LegOwnershipEnum Ownership { get; set; }

	}
}
