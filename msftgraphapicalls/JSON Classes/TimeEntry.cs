using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class TimeEntry
    {

        [JsonProperty("dateTime")]
        public DateTime dateTime
        {
            get;
            set;
        }

        [JsonProperty("timeZone")]
        public string timeZone
        {
            get;
            set;
        }
    }
}
