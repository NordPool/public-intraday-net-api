namespace Nordpool.ID.PublicApi.v1.Throttling
{
	public class MarketOrderLimits
	{
		public string Market { get; set; }

		public long Current10s { get; set; }

		public long Current1h { get; set; }

		public long Limit10s { get; set; }

		public long Limit1h { get; set; }
	}
}
