/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Order
{
	public class OrderEntry 
	{
		/// <summary>UUID for the order, provided by the client to track their own orders</summary>
		public Guid ClientOrderId { get; set; }

		/// <summary>The portfolio id of the current order</summary>
		public string PortfolioId { get; set; }

		/// <summary>The contract ids that the current order should be placed on. For limit orders, only one value is allowed, for custom block orders all the contracts that the block spans should be included</summary>
		public List<string> ContractIds { get; set; }

		public long DeliveryAreaId { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.OrderSide Side { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.OrderType OrderType { get; set; }

		public long UnitPrice { get; set; }

		public long Quantity { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.TimeInForce TimeInForce { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.ExecutionRestriction ExecutionRestriction { get; set; }

		public DateTimeOffset ExpireTime { get; set; }

		public string Text { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.OrderState State { get; set; }

		public long ClipSize { get; set; }

		public long ClipPriceChange { get; set; }

	}
}
