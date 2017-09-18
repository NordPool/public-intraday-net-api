using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    [Description("A contract can be available in many delivery areas, and for each delivery area it can have different opening and closing times. So for each area state, openAt and closeAt times are defined.")]
    public class DeliveryAreaState
    {
        [Description("Area ID")]
        public long DlvryAreaId { get; set; }

        [Description("State of the area: HIBE, IACT ACTI. Supposed to be ACTI for a tradeable area.")]
        public ContractStateEnum State { get; set; }
    
        [Description("Validity start time for contract in the area")]
        public DateTimeOffset OpenAt { get; set; }

        [Description("Validity close time for contract in the area")]
        public DateTimeOffset ClosedAt { get; set; }
    }
}
