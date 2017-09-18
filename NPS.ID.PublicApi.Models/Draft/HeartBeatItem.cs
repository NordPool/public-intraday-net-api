using System.ComponentModel;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class HeartBeatItem
    {
        [Description("A topic that the current user is subscribed to")]
        public string Topic { get; set; }

        [Description("Last x-nps-sequenceNo value for packets sent to the topic (see Message sequencing)")]
        public long LastSequenceNumber { get; set; }
    }
}