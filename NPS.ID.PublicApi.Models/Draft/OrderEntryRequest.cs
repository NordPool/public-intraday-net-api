using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    /// <summary>
    /// NOTE: This class is NOT the official contract for OrderEntryRequest and one should ALWAYS check the required fields from the official documentation: https://developers.nordpoolgroup.com/docs/creating-and-modifying-orders
    /// </summary>
    public class OrderEntryRequest
    {
        [Description("Unique identifier for this request, provided by the client to track their own requests")]
        public string RequestId { get; set; }

        [Description("Should the message be completely rejected if only some of the entered orders cause errors.")]
        public bool RejectPartially { get; set; }

        [Description("List of orders")]
        public List<OrderEntry> Orders { get; set; }


    }
}
