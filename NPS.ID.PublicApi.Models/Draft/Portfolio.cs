using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{

    public class Portfolio
    {
        [DisplayName("Portfolio Id")]
        [Description("Portfolio unique identifier created by the trading platform.")]
        [MaxLength(10)]
        public string Id { get; set; }

        [DisplayName("Tenant Id")]
        [Description("[TODO TenantId description]")]
        public string TenantId { get; set; }

        [DisplayName("Name")]
        [Description("Portfolio name in a human readable format.")]
        [MaxLength(30)]
        public string Name { get; set; }

        [DisplayName("Short name")]
        [Description("Portfolio short name")]
        [MaxLength(15)]
        public string ShortName { get; set; }

        [DisplayName("Company Id")]
        [Description("Company unique identifier that portfolios are assigned to.")]
        [MaxLength(6)]
        public string CompanyId { get; set; }

        [DisplayName("Valid from")]
        [Description("Start of portfolio validity period.")]
        public DateTimeOffset ValidFrom { get; set; }

        [DisplayName("Valid to")]
        [Description("End of portfolio validity period.")]
        public DateTimeOffset ValidTo { get; set; }

        [DisplayName("Deleted")]
        [Description("If false: update information with the contents received. If true: delete entity indicated in the message")]
        public bool Deleted { get; set; }

        [DisplayName("State")]
        [Description("ACTI: Active, IACT: Expired(will never be reopened), HIBE: Closed(can be reopened)")]
        [EnumDataType(typeof(ContractStateEnum))]
        public ContractStateEnum State { get; set; }

        [DisplayName("Currency")]
        [Description("Currency used for the portfolio")]
        public string Currency { get; set; }

        [DisplayName("Areas")]
        [Description("List of areas in which the portfolio is valid")]
        public List<DeliveryAreaPortfolio> Areas { get; set; }

        [DisplayName("Markets")]
        [Description("List of markets where given portfolio can trade")]
        public List<MarketPortfolio> Markets { get; set; }
    }
}
