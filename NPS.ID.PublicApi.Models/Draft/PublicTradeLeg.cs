using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class PublicTradeLeg : BaseTradeLeg
    {
        [Description("OWN_BUY, OWN_SELL - the leg (order) is placed by current user and is on Buy or Sell side, respectively. COMPANY_BUY, COMPANY_SELL - the order was placed by different user from same Company.Order is on Buy or Sell side, respectively. OTHER - the order was placed by different company than user's.")]
        public LegOwnershipEnum Ownership { get; set; }
    }
}
