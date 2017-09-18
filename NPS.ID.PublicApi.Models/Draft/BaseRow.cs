using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    public class BaseRow
    {
        [Description("Last modification time (status change) of data")]
        public DateTimeOffset? UpdatedAt { get; set; }

    }
}
