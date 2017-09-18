using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    [Description("Delivery area portfolio")]
    public class DeliveryAreaPortfolio
    {
        [Description("Area's unique identifier;")]
        public int AreaId { get; set; }
        [Description("Start of portfolio validity period for said area.")]
        public DateTimeOffset ValidFrom { get; set; }
        [Description("End of portfolio validity period for said area.")]
        public DateTimeOffset ValidTo { get; set; }
    }
}
