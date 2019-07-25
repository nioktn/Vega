using System;
using System.Collections.Generic;

namespace Vega.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public KeyValuePairResource Make { get; set; }
        public KeyValuePairResource Model { get; set; }
        public bool IsRegistered { get; set; }
        public ContactResource Contact { get; set; }
        public DateTime LastUpdate { get; set; }
        public IList<KeyValuePairResource> Features { get; set; }
        public VehicleResource()
        {
            Features = new List<KeyValuePairResource>();
        }

    }
}
