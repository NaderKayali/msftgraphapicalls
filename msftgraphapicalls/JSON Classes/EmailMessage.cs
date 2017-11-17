using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class EmailMessage
    {
        [JsonProperty("subject")]
        public string Subject
        {
            get;
            set;
        }

        [JsonProperty("body")]
        public Body Body
        {
            get;
            set;
        }

        [JsonProperty("toRecipients")]
        public List<EmailExchangeMember> ToRecipients
        {
            get;
            set;
        }
    }
}
