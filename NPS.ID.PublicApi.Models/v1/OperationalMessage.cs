/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1
{
	/// <summary>
	/// Operational Message
	/// </summary>
	public class OperationalMessage 
	{
		/// <summary>
		/// Id
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Message Title
		/// </summary>
		public string MessageTitle { get; set; }
		
		/// <summary>
		/// Message Body
		/// </summary>
		public string MessageBody { get; set; }
		
		/// <summary>
		/// Message Body
		/// </summary>
		public string IsRead { get; set; }

		/// <summary>
		/// Valid From
		/// </summary>
		public DateTimeOffset ValidFrom { get; set; }

		/// <summary>
		/// Valid To
		/// </summary>
		public DateTimeOffset ValidTo { get; set; }

		/// <summary>
		/// Created
		/// </summary>
		public DateTimeOffset Created { get; set; }
	}
}
