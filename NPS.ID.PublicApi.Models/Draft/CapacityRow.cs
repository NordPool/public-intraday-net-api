using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    [Description("Capacity information between areas")]
    public class CapacityRow : BaseRow
    {
        [Description("An event counter that increments as list of capacities gets updated")]
        public int EventSequenceNo { get; set; }

        [Description("true - capacity data produced by internal Nord Pool Matcher. false - capacity data came")]
        public bool Internal { get; set; }

        [Description("When the ATC data was received from the Capacity system")]
        public DateTimeOffset PublicationTime { get; set; }

        [Description("The outgoing Market Area Code")]
        public long DeliveryAreaFrom { get; set; }

        [Description("The incoming Market Area Code")]
        public long DeliveryAreaTo { get; set; }

        [Description("Delivery start date, expressed as Long for performance reasons")]
        public long DeliveryAreaStart { get; set; }

        [Description("Delivery end date, expressed as Long for performance reasons")]
        public long DeliveryAreaEnd { get; set; }

        [Description("Available capacity incomingMarketArea -> outgoingMarketArea")]
        public int InCapacity { get; set; }

        [Description("Available capacity ougoingMarketArea -> incomingMarketArea")]
        public int OutCapacity { get; set; }
    }
}
