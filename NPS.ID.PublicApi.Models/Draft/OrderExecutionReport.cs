using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NPS.ID.PublicApi.Models.Draft
{

    [Description("In response to an order creation or modification request described in Creating and modifying orders and for any order updates, the Intraday Platform will send an Order Execution Report message.")]
    public class OrderExecutionReport : BaseRow
    {
        [Description("Unique identifier for this request, provided by the client to track their own requests")]
        public string RequestId { get; set; }

        [Description("Member ID")]
        public string MemberId { get; set; }

        [Description("Technical field about message originator.")]
        public ErrorTypeEnum? ErrorType { get; set; }

        [Description("An array of objects that contain fields errorCode and errorMessage.")]
        public List<Error> Errors { get; set; }

        [Description("Order execution entries")]
        public List<OrderExecutionEntry> Orders { get; set; }
    }
   
}
