using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class Order
    {
        public string OrderId { get; set; }
        public long DeliveryAreaId { get; set; }
        public long Price { get; set; }
        public long Qty { get; set; }
    }
}
