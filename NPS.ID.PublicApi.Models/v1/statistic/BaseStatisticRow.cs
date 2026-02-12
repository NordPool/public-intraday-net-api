/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Statistic
{
	/// <summary>Capacity information between areas</summary>
	public class BaseStatisticRow  : Base.BaseRow
	{
		public long DeliveryAreaId { get; set; }

		/// <summary>Unique identifier for a contract</summary>
		public string ContractId { get; set; }
	}
}
