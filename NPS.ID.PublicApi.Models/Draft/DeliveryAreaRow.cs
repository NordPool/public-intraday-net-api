using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class DeliveryAreaRow : BaseRow
    {
        [Description("Delivery Area ID")]
        public long DeliveryAreaId { get; set; }

        [Description("Delivery area EIC (Energy Identification Code)")]
        public string EicCode { get; set; }

        [Description("Currency code used in the area")]
        public string CurrencyCode { get; set; }

        [Description("Delivery area code")]
        public string AreaCode { get; set; }

        [Description("Time zone used in the area")]
        public string TimeZone { get; set; }

        [Description("Country ISO code")]
        public string CountryIsoCode { get; set; }

        [Description("Product types available in the area")]
        public List<string> ProductTypes { get; set; }

        [Description("If false: update information with the contents received, If true: delete entity indicated in the message")]
        public bool Deleted { get; set; }
    }
}
