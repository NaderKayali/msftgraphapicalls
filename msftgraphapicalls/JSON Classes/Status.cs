using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class Status
    {
        [JsonProperty("response")]
        public string response
        {
            get;
            set;
        }

        [JsonProperty("time")]
        public DateTime time
        {
            get;
            set;
        }
    }
}
