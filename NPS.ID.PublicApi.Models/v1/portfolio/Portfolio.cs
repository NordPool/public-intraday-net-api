/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Portfolio
{
	public class Portfolio 
	{
		/// <summary>Portfolio unique identifier created by the trading platform.</summary>
		public string Id { get; set; }

		/// <summary>Portfolio name in a human readable format.</summary>
		public string Name { get; set; }

		/// <summary>Portfolio short name</summary>
		public string ShortName { get; set; }

		/// <summary>Company unique identifier that portfolios are assigned to.</summary>
		public string CompanyId { get; set; }

		public Nordpool.ID.PublicApi.v1.Portfolio.PortfolioPermission? Permission { get; set; }

		public DateTimeOffset ValidFrom { get; set; }

		public DateTimeOffset ValidTo { get; set; }

		/// <summary>If false: update information with the contents received. If true: delete entity indicated in the message</summary>
		public bool Deleted { get; set; }

		public Nordpool.ID.PublicApi.v1.Contract.ContractState? State { get; set; }

		/// <summary>Currency used for the portfolio</summary>
		public string Currency { get; set; }

		/// <summary>List of areas in which the portfolio is valid</summary>
		public List<Nordpool.ID.PublicApi.v1.Area.DeliveryAreaPortfolio> Areas { get; set; }

		/// <summary>List of markets where given portfolio can trade</summary>
		public List<Nordpool.ID.PublicApi.v1.Market.MarketPortfolio> Markets { get; set; }

	}
}
