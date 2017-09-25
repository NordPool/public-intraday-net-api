/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	public class OrderModification
	{
		public long RevisionNo { get; set; }

		public string ClientOrderId { get; set; }

		public string OrderId { get; set; }

		public string PortfolioId { get; set; }

		public System.Collections.Generic.List<string> ContractIds { get; set; }

		public OrderTypeEnum OrderType { get; set; }

		public long UnitPrice { get; set; }

		public long Quantity { get; set; }

		public TimeInForceEnum TimeInForce { get; set; }

		public ExecutionRestrictionEnum ExecutionRestriction { get; set; }

		public System.DateTimeOffset ExpireTime { get; set; }

		public string Text { get; set; }

		public long ClipSize { get; set; }

		public long ClipPriceChange { get; set; }

	}
}
