using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class OrderModificationRequest
    {
        [Description("Unique identifier for this request, provided by the client to track their own requests")]
        public string RequestId { get; set; }

        public OrderModificationTypeEnum OrderModificationType { get; set; }

        public string UserId { get; set; }

        public List<OrderModification> Orders { get; set; }

    }
}
