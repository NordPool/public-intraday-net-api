/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool’s Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */


namespace Nordpool.ID.PublicApi.v1
{
	/// <summary>Capacity information between areas</summary>
	public class CapacityRow  : Base.BaseRow
	{
		public int EventSequenceNo { get; set; }

		/// <summary>true - capacity data produced by internal Nord Pool Matcher. false - capacity data came</summary>
		public bool Internal { get; set; }

		public System.DateTimeOffset PublicationTime { get; set; }

		public long DeliveryAreaFrom { get; set; }

		public long DeliveryAreaTo { get; set; }

		public long DeliveryStart { get; set; }

		public long DeliveryEnd { get; set; }

		public int InCapacity { get; set; }

		public int OutCapacity { get; set; }

	}
}
