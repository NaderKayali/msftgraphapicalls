using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class Location
    {
        [JsonProperty("displayName")]
        public string displayName
        {
            get;
            set;
        }

        [JsonProperty("address")]
        public Address address
        {
            get;
            set;
        }
    }
}
