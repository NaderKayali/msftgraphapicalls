using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class EmailToSend
    {
        [JsonProperty("message")]
        public EmailMessage message
        {
            get;
            set;
        }
    }
}
