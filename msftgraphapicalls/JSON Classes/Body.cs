using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class Body
    {
        [JsonProperty("contentType")]
        public string contentType
        {
            get;
            set;
        }

        [JsonProperty("content")]
        public string content
        {
            get;
            set;
        }
    }
}
