using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class BaseStatisticRow  :BaseRow
    {
        [Description("Delivery area ID")]
        public long DeliveryAreaId { get; set; }

        [Description("Identifier for a contract")]
        public string ContractId { get; set; }
    }
}
