/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	/// <summary>Configuration row. See documentation from: https://developers.nordpoolgroup.com/docs/configuration</summary>
	public class ConfigurationRow 
	{
		/// <summary>An array of throttling limits</summary>
		public System.Collections.Generic.List<long> ThrottlingLimit { get; set; }

		/// <summary>An array of portfolios which are accessible for the logged in user.</summary>
		public System.Collections.Generic.List<Portfolio> Portfolios { get; set; }

	}
}
