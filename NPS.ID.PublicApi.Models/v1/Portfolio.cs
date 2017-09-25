/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	public class Portfolio
	{
		/// <summary>Portfolio unique identifier created by the trading platform.</summary>
		public string Id { get; set; }

		/// <summary>[TODO TenantId description]</summary>
		public string TenantId { get; set; }

		/// <summary>Portfolio name in a human readable format.</summary>
		public string Name { get; set; }

		/// <summary>Portfolio short name</summary>
		public string ShortName { get; set; }

		/// <summary>Company unique identifier that portfolios are assigned to.</summary>
		public string CompanyId { get; set; }

		public System.DateTimeOffset ValidFrom { get; set; }

		public System.DateTimeOffset ValidTo { get; set; }

		/// <summary>If false: update information with the contents received. If true: delete entity indicated in the message</summary>
		public bool Deleted { get; set; }

		/// <summary>ACTI: Active, IACT: Expired(will never be reopened), HIBE: Closed(can be reopened)</summary>
		public StateEnum State { get; set; }

		/// <summary>Currency used for the portfolio</summary>
		public string Currency { get; set; }

		/// <summary>List of areas in which the portfolio is valid</summary>
		public System.Collections.Generic.List<DeliveryAreaPortfolio> Areas { get; set; }

		/// <summary>List of markets where given portfolio can trade</summary>
		public System.Collections.Generic.List<MarketPortfolio> Markets { get; set; }

	}
}
