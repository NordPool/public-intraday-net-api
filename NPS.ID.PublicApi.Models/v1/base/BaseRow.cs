/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Base
{
	/// <summary>Class with base fields for UI models</summary>
	public class BaseRow 
	{
		/// <summary>Last modification time (status change) of data</summary>
		public DateTimeOffset? UpdatedAt { get; set; }

	}
}
