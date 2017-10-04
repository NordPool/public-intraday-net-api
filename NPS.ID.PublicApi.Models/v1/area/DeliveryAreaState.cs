/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Area
{
	/// <summary>A contract can be available in many delivery areas, and for each delivery area it can have different opening and closing times. So for each area state, openAt and closeAt times are defined.</summary>
	public class DeliveryAreaState 
	{
		public long DlvryAreaId { get; set; }

		public Nordpool.ID.PublicApi.v1.Contract.ContractState State { get; set; }

		public DateTimeOffset OpenAt { get; set; }

		public DateTimeOffset ClosedAt { get; set; }

	}
}
