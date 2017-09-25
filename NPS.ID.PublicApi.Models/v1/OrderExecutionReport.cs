/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	/// <summary>In response to an order creation or modification request described in Creating and modifying orders and for any order updates, the Intraday Platform will send an Order Execution Report message.</summary>
	public class OrderExecutionReport
	{
		/// <summary>Unique identifier for this request, provided by the client to track their own requests</summary>
		public string RequestId { get; set; }

		/// <summary>Member ID</summary>
		public string MemberId { get; set; }

		/// <summary>Technical field about message originator.</summary>
		public ErrorTypeEnum ErrorType { get; set; }

		/// <summary>An array of objects that contain fields errorCode and errorMessage.</summary>
		public System.Collections.Generic.List<Error> Errors { get; set; }

		/// <summary>Order execution entries</summary>
		public System.Collections.Generic.List<OrderExecutionEntry> Orders { get; set; }

		/// <summary>Last modification time (status change) of data</summary>
		public System.DateTimeOffset UpdatedAt { get; set; }

	}
}
