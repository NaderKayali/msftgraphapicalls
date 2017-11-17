using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class ListOfCalendarEvents
    {
        [JsonProperty("@odata.context")]
        public string odatacontext
        {
            get;
            set;
        }

        [JsonProperty("@odata.nextLink")]
        public string odatanextLink
        {
            get;
            set;
        }

        [JsonProperty("value")]
        public IList<CalendarEventEntry> CalendarEntry
        {
            get;
            set;
        }
    }
}
