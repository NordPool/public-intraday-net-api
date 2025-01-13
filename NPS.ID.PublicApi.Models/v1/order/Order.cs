/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Order
{
	public class Order 
	{
		public string OrderId { get; set; }

		public long DeliveryAreaId { get; set; }

		/// <summary>The portfolio id of the current order</summary>
		public string PortfolioId { get; set; }

		public long Price { get; set; }

		public long Qty { get; set; }

		/// <summary>Last modification time (status change) of data</summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>Last modification time (status change) of data</summary>
		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>If false: update information with the contents received, If true: delete entity indicated in the message</summary>
		public bool Deleted { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.OrderOwnershipEnum? Ownership { get; set; }

	}
}
