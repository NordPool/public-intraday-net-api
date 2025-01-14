/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1
{
    /// <summary>Capacity information between areas</summary>
    public class AtcCapacityRow
    {
        public long EventSequenceNo { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public long DeliveryAreaFrom { get; set; }

        public long DeliveryAreaTo { get; set; }

        public long DeliveryStart { get; set; }

        public long DeliveryEnd { get; set; }

        public long Capacity { get; set; }
        
        public string Border { get; set; }

    }
}