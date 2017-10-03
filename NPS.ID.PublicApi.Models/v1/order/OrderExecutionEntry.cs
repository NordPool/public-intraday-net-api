/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	public class OrderExecutionEntry 
	{
		public long? EventSequenceNo { get; set; }

		public string MarketId { get; set; }

		public string TenantId { get; set; }

		public string UserId { get; set; }

		public string OrderId { get; set; }

		public long? RevisionNo { get; set; }

		/// <summary>Id of the previous order in this modification chain. When an order is modified and its priority changes, or partially matched, a new order Id is assigned.</summary>
		public string PreviousOrderId { get; set; }

		/// <summary>The original order id in this modification chain.</summary>
		public string OriginalOrderId { get; set; }

		public System.DateTimeOffset UpdatedAt { get; set; }

		/// <summary>UUID for the order, provided by the client to track their own orders</summary>
		public string ClientOrderId { get; set; }

		/// <summary>The portfolio id of the current order</summary>
		public string PortfolioId { get; set; }

		/// <summary>The contract ids for current order</summary>
		public System.Collections.Generic.List<string> ContractIds { get; set; }

		public long? DeliveryAreaId { get; set; }

		public OrderSide Side { get; set; }

		public OrderType OrderType { get; set; }

		public long? UnitPrice { get; set; }

		public long? Quantity { get; set; }

		public TimeInForce TimeInForce { get; set; }

		/// <summary>If timeInForce is set to GTD (Good Till Date), the expireTime will determine when the order expires</summary>
		public System.DateTimeOffset ExpireTime { get; set; }

		public string Text { get; set; }

		public OrderState State { get; set; }

		public OrderAction Action { get; set; }

		public long? ClipSize { get; set; }

		public long? ClipPriceChange { get; set; }

		public long? RemainingQuantity { get; set; }

		public System.Collections.Generic.List<Error> Errors { get; set; }

	}
}
