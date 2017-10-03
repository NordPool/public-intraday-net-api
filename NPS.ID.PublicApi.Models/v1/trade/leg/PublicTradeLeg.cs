/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using  Nordpool.ID.PublicApi.v1.Trade.Leg;
using  Nordpool.ID.PublicApi.v1.Order;

namespace Nordpool.ID.PublicApi.v1.Trade.Leg
{
	public class PublicTradeLeg 
	{
		public Nordpool.ID.PublicApi.v1.Trade.Leg.LegOwnershipEnum Ownership { get; set; }

		/// <summary>Contract Id for the order</summary>
		public string ContractId { get; set; }

		public Nordpool.ID.PublicApi.v1.Order.OrderSide Side { get; set; }

		public long UnitPrice { get; set; }

		public long Quantity { get; set; }

		public long DeliveryAreaId { get; set; }

		/// <summary>true if leg is the aggressor, null if the information is unavailable (for XBID trades)</summary>
		public bool Aggressor { get; set; }

	}
}
