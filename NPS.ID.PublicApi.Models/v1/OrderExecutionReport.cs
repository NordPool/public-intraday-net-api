/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1
{
	/// <summary>In response to an order creation or modification request described in Creating and modifying orders and for any order updates, the Intraday Platform will send an Order Execution Report message.</summary>
	public class OrderExecutionReport  : Base.BaseRow
	{
		/// <summary>Unique identifier for this request, provided by the client to track their own requests</summary>
		public string RequestId { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.Error.ErrorType? ErrorType { get; set; }

		/// <summary>An array of objects that contain fields errorCode and errorMessage.</summary>
		public List<Nordpool.ID.PublicApi.v1.Order.Error.Error> Errors { get; set; }

		/// <summary>Order execution entries</summary>
		public List<Nordpool.ID.PublicApi.v1.Order.OrderExecutionEntry> Orders { get; set; }

	}
}
