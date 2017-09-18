using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class ContractRow : BaseRow
    {
        [Description("Unique identifier for a contract")]
        public string ContractId { get; set; }

        [Description("A more user friendly name for the contract (PH,QH,HH... etc)")]
        public string ContractName { get; set; }

        [Description("State of the contract:ACTI: Active, IACT: Expired(will never be reopened), HIBE: Closed(can be reopened)")]
        public ContractStateEnum State { get; set; }

        [Description("The total duration of this contract in seconds e.g. hourly contracts have a duration of 3600 seconds.")]
        public long DurationSeconds { get; set; }

        [Description("The minimum resolution of this contract in seconds e.g 15 minute resolution will be 900 seconds.")]
        public long ResolutionSeconds { get; set; }

        [Description("When a custom block order is entered, a new contract is created for that time interval if it does not already exist, in which case predefined would be false.")]
        public bool Predefined { get; set; }

        [Description("If false: update information with the contents received, If true: delete entity indicated in the message.")]
        public bool Deleted { get; set; }

        [Description("The delivery start for this contract")]
        public DateTimeOffset DlvryStart { get; set; }

        [Description("The delivery end for this contract")]
        public DateTimeOffset DlvryEnd { get; set; }

        [Description("A contract can be available in many delivery areas, and for each delivery area it can have different opening and closing times. So for each area state, openAt and closeAt times are defined.")]
        public List<DeliveryAreaState> DlvryAreaState { get; set; }

        [Description("Id of the market that this contract belongs to, for example a code for XBID market.")]
        public string MarketId { get; set; }

        [Description("Short display name for contract")]
        public string ShortDisplayName { get; set; }

        [Description("Medium length display name for contract")]
        public string MediumDisplayName { get; set; }

        [Description("Type of product that this contract belongs to")]
        public ProductTypeEnum ProductType { get; set; }

        [Description("Id of product that this contract belongs to")]
        public string ProductId { get; set; }
    }
}
