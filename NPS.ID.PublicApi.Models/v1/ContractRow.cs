/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1
{
	public class ContractRow  : Base.BaseRow
	{
		/// <summary>Unique identifier for a contract</summary>
		public string ContractId { get; set; }

		/// <summary>A more user friendly name for the contract (PH,QH,HH... etc)</summary>
		public string ContractName { get; set; }

		public long DurationSeconds { get; set; }

		public long ResolutionSeconds { get; set; }

		/// <summary>When a custom block order is entered, a new contract is created for that time interval if it does not already exist, in which case predefined would be false.</summary>
		public bool Predefined { get; set; }

		/// <summary>If false: update information with the contents received, If true: delete entity indicated in the message.</summary>
		public bool Deleted { get; set; }

		public DateTimeOffset DlvryStart { get; set; }

		public DateTimeOffset DlvryEnd { get; set; }

		/// <summary>A contract can be available in many delivery areas, and for each delivery area it can have different opening and closing times. So for each area state, openAt and closeAt times are defined.</summary>
		public List<Nordpool.ID.PublicApi.v1.Area.DeliveryAreaState> DlvryAreaState { get; set; }

		/// <summary>Id of the market that this contract belongs to, for example a code for XBID market.</summary>
		public string MarketId { get; set; }

		/// <summary>Short display name for contract</summary>
		public string ShortDisplayName { get; set; }

		/// <summary>Medium length display name for contract</summary>
		public string MediumDisplayName { get; set; }

		public Nordpool.ID.PublicApi.v1.Contract.ProductType? ProductType { get; set; }

		/// <summary>Id of product that this contract belongs to</summary>
		public string ProductId { get; set; }

	}
}
