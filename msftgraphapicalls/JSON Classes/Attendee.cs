using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class Attendee
    {
        [JsonProperty("type")]
        public string type
        {
            get;
            set;
        }

        [JsonProperty("status")]
        public Status status
        {
            get;
            set;
        }

        [JsonProperty("emailAddress")]
        public EmailAddress emailAddress
        {
            get;
            set;
        }
    }
}
