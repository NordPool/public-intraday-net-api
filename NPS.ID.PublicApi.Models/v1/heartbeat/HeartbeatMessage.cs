/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Heartbeat
{
	/// <summary>The Intraday Platform uses Heartbeat Ping messages to inform a client that the server is alive and to let the client perform consistency checking of the data received.</summary>
	public class HeartbeatMessage 
	{
		public long Timestamp { get; set; }

		public List<Nordpool.ID.PublicApi.v1.Heartbeat.HeartbeatItem> Heartbeat { get; set; }

	}
}
