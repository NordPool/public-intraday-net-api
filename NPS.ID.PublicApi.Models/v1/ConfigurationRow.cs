/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1
{
	/// <summary>Configuration row. See documentation from: https://developers.nordpoolgroup.com/docs/configuration</summary>
	public class ConfigurationRow 
	{
		public string UserUUID { get; set; }

		/// <summary>An array of throttling limits</summary>
		public List<long> ThrottlingLimit { get; set; }

		/// <summary>An array of portfolios which are accessible for the logged in user.</summary>
		public List<Nordpool.ID.PublicApi.v1.Portfolio.Portfolio> Portfolios { get; set; }

		/// <summary>Map of user name to user UUID relations</summary>
		public object CompanyUsers { get; set; }

	}
}
