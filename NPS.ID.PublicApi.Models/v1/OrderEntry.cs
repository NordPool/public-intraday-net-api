/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	public class OrderEntry
	{
		/// <summary>The portfolio id of the current order</summary>
		public string PortfolioId { get; set; }

		/// <summary>The contract ids that the current order should be placed on. For limit orders, only one value is allowed, for custom block orders all the contracts that the block spans should be included</summary>
		public System.Collections.Generic.List<string> ContractIds { get; set; }

		public long DeliveryAreaId { get; set; }

		/// <summary>BUY/SELL</summary>
		public SideEnum Side { get; set; }

		public long? ClipSize { get; set; }

		public long? ClipPriceChange { get; set; }

		/// <summary>LIMIT, ICEBERG, USER_DEFINED_BLOCK</summary>
		public OrderTypeEnum OrderType { get; set; }

		public long UnitPrice { get; set; }

		public long Quantity { get; set; }

		/// <summary>IOC, FOK, AON, NON, GTD, GFS</summary>
		public TimeInForceEnum TimeInForce { get; set; }

		/// <summary>“AON” (All or None): The order must be filled completely or not at all. The order stays in the order book until it is executed or removed by the system or user. This execution restriction can be used only in combination with User Defined Block Orders. “NON”: No restrictions.</summary>
		public ExecutionRestrictionEnum ExecutionRestriction { get; set; }

		public System.DateTimeOffset ExpireTime { get; set; }

		/// <summary>ACTI — Active, IACT — Closed, matched(will never be reopened), HIBE — Deactivated(can be reopened)</summary>
		public StateEnum State { get; set; }

		/// <summary>UUID for the order, provided by the client to track their own orders</summary>
		public string ClientOrderId { get; set; }

	}
}
