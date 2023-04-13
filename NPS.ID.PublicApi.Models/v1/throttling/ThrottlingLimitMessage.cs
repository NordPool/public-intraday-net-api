/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Throttling
{
	/// <summary>The Intraday Platform uses Throttling Limit messages to inform a client about the number of orders, logins and it's limits.</summary>
	public class ThrottlingLimitMessage
	{
		public long Timestamp { get; set; }

		public long OrdersPer10s { get; set; }

		public long OrdersPer1h { get; set; }

		public long OrdersPer1day { get; set; }

		public long ThrottlingOrderLimitPer10s { get; set; }

		public long ThrottlingOrderLimitPer1h { get; set; }

		public long LoginsPer20s { get; set; }

		public long LoginsPer20min { get; set; }

		public long ThrottlingLoginLimitPer20s { get; set; }

		public long ThrottlingLoginLimitPer20min { get; set; }

	}

}
