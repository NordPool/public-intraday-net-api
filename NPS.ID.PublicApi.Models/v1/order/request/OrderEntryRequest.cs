/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Order.Request
{
	public class OrderEntryRequest 
	{
		/// <summary>Unique identifier for this request, provided by the client to track their own requests</summary>
		public string RequestId { get; set; }

		/// <summary>Should the message be completely rejected if only some of the entered orders cause errors.</summary>
		public bool RejectPartially { get; set; }

		/// <summary>List of orders</summary>
		public List<Nordpool.ID.PublicApi.v1.Order.OrderEntry> Orders { get; set; }

	}
}
