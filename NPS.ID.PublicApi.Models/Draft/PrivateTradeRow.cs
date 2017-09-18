using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class PrivateTradeRow : BaseTradeRow<PrivateTradeLeg>
    {
        [Description("Cancellation fee for this trade")]
        public long CancellationFee { get; set; }

        [Description("There is a deadline for trade cancellation, in accordance with market rules")]
        public string CancellationDeadLine { get; set; }


        public long RevisionNo { get; set; }
    }
}
