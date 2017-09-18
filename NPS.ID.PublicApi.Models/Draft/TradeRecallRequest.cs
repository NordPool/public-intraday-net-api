using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class TradeRecallRequest
    {
        public string TradeId { get; set; }
        public string RevisionNo { get; set; }
    }
}
