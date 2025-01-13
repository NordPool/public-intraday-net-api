/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1
{
	/// <summary>Operational Message</summary>
	public class OperationalMessage 
	{
		/// <summary>id</summary>
		public Guid Id { get; set; }

		/// <summary>tenant</summary>
		public string Tenant { get; set; }

		/// <summary>Delivery areas</summary>
		public List<string> Areas { get; set; }

		/// <summary>message</summary>
		public string Message { get; set; }

		/// <summary>Is active</summary>
		public bool IsActive { get; set; }

		public DateTimeOffset ValidFrom { get; set; }

		public DateTimeOffset ValidTo { get; set; }

		public DateTimeOffset Created { get; set; }

	}
}
