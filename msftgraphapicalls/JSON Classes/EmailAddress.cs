using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class EmailAddress
    {
        [JsonProperty("name")]
        public string name
        {
            get;
            set;
        }

        [JsonProperty("address")]
        public string address
        {
            get;
            set;
        }
    }
}
