using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.Models.Draft
{
    [Description("Configuration row. See documentation from: https://developers.nordpoolgroup.com/docs/configuration")]
    public class ConfigurationRow
    {
        [DisplayName("Throttling limits")]
        [Description("An array of throttling limits")]
        public List<long> ThrottlingLimit { get; set; }

        [DisplayName("Portfolios")]
        [Description("An array of portfolios which are accessible for the logged in user.")]
        public List<Portfolio> Portfolios { get; set; }
    }

}
