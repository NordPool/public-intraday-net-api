/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

namespace NPS.ID.PublicApi.Models.v1
{
	public class PublicTradeRow  : BaseTradeRow
	{
		/// <summary>Basic data about orders participated in the trade</summary>
		public System.Collections.Generic.List<PublicTradeLeg> Legs { get; set; }

	}
}
