/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */


namespace Nordpool.ID.PublicApi.v1
{
	public class LocalViewRow  : Base.BaseRow
	{
		/// <summary>Basic data for BUY orders</summary>
		public System.Collections.Generic.List<Nordpool.ID.PublicApi.v1.Order.Order> BuyOrders { get; set; }

		/// <summary>Basic data for SELL orders</summary>
		public System.Collections.Generic.List<Nordpool.ID.PublicApi.v1.Order.Order> SellOrders { get; set; }

		/// <summary>ID of the contract that this order belongs to</summary>
		public string ContractId { get; set; }

		/// <summary>The timestamp at which this order was received by the system</summary>
		public System.DateTimeOffset CreatedAt { get; set; }

		public long DeliveryAreaId { get; set; }

		/// <summary>FOK — Fill or Kill, IOC — Immediate or Cancel, NON — No specific restriction, AON — All or none</summary>
		public string OrderExecutionRestriction { get; set; }

	}
}
