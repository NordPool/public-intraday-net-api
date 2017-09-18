//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.6.3.0 (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace NPS.ID.PublicApi.Models
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public partial class OrderModification 
    {
        [Newtonsoft.Json.JsonProperty("revisionNo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long RevisionNo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("clientOrderId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ClientOrderId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("orderId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("portfolioId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PortfolioId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("contractIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> ContractIds { get; set; }
    
        [Newtonsoft.Json.JsonProperty("orderType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderModificationOrderType OrderType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unitPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long UnitPrice { get; set; }
    
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Quantity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("timeInForce", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderModificationTimeInForce TimeInForce { get; set; }
    
        [Newtonsoft.Json.JsonProperty("executionRestriction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderModificationExecutionRestriction ExecutionRestriction { get; set; }
    
        [Newtonsoft.Json.JsonProperty("expireTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ExpireTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }
    
        [Newtonsoft.Json.JsonProperty("clipSize", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long ClipSize { get; set; }
    
        [Newtonsoft.Json.JsonProperty("clipPriceChange", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long ClipPriceChange { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static OrderModification FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderModification>(data);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public partial class OrderModificationRequest 
    {
        /// <summary>Unique identifier for this request, provided by the client to track their own requests</summary>
        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RequestId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("orderModificationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OrderModificationRequestOrderModificationType OrderModificationType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("orders", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<OrderModification> Orders { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static OrderModificationRequest FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderModificationRequest>(data);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public enum OrderModificationOrderType
    {
        [System.Runtime.Serialization.EnumMember(Value = "LIMIT")]
        LIMIT = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "ICEBERG")]
        ICEBERG = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "USER_DEFINED_BLOCK")]
        USER_DEFINED_BLOCK = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public enum OrderModificationTimeInForce
    {
        [System.Runtime.Serialization.EnumMember(Value = "IOC")]
        IOC = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "FOK")]
        FOK = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "NON")]
        NON = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = "GTD")]
        GTD = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = "GFS")]
        GFS = 4,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public enum OrderModificationExecutionRestriction
    {
        [System.Runtime.Serialization.EnumMember(Value = "AON")]
        AON = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "NON")]
        NON = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.6.3.0")]
    public enum OrderModificationRequestOrderModificationType
    {
        [System.Runtime.Serialization.EnumMember(Value = "ACTI")]
        ACTI = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "DEAC")]
        DEAC = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = "MODI")]
        MODI = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = "DELE")]
        DELE = 3,
    
    }
}