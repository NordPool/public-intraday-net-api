/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	public class PublicTradeLeg
	{
		/// <summary>OWN_BUY, OWN_SELL - the leg (order) is placed by current user and is on Buy or Sell side, respectively. COMPANY_BUY, COMPANY_SELL - the order was placed by different user from same Company.Order is on Buy or Sell side, respectively. OTHER - the order was placed by different company than user's.</summary>
		public OwnershipEnum Ownership { get; set; }

		/// <summary>Contract Id for the order</summary>
		public string ContractId { get; set; }

		/// <summary>Buy or Sell</summary>
		public SideEnum Side { get; set; }

		public long UnitPrice { get; set; }

		public long Quantity { get; set; }

		public long DeliveryAreaId { get; set; }

		/// <summary>true if leg is the aggressor, null if the information is unavailable (for XBID trades)</summary>
		public bool Aggressor { get; set; }

	}
}
