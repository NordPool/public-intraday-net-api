using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    [Description("The Intraday Platform uses Heartbeat Ping messages to inform a client that the server is alive and to let the client perform consistency checking of the data received.")]
    public class HeartbeatMessage
    {
        [Description("Timestamp of the Heartbeat generation in Unix Epoch Milliseconds format.")]
        public long Timestamp { get; set; }
        public List<HeartBeatItem> HeartBeats { get; set; }

    }
}
