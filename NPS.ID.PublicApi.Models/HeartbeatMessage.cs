//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.6.3.0 (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace NPS.ID.PublicApi.Models
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public partial class HeartBeatItem 
    {
        /// <summary>A topic that the current user is subscribed to</summary>
        [Newtonsoft.Json.JsonProperty("topic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Topic { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastSequenceNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long LastSequenceNumber { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static HeartBeatItem FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HeartBeatItem>(data);
        }
    }
    
    /// <summary>The Intraday Platform uses Heartbeat Ping messages to inform a client that the server is alive and to let the client perform consistency checking of the data received.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public partial class HeartbeatMessage 
    {
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Timestamp { get; set; }
    
        [Newtonsoft.Json.JsonProperty("heartBeats", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<HeartBeatItem> HeartBeats { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static HeartbeatMessage FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<HeartbeatMessage>(data);
        }
    }
}