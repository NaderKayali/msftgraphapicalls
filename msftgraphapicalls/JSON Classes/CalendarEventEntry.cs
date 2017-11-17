using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class CalendarEventEntry
    {
        [JsonProperty("@odata.etag")]
        public string odataetag
        {
            get;
            set;
        }

        [JsonProperty("id")]
        public string id
        {
            get;
            set;
        }

        [JsonProperty("subject")]
        public string subject
        {
            get;
            set;
        }

        [JsonProperty("bodyPreview")]
        public string bodyPreview
        {
            get;
            set;
        }

        [JsonProperty("body")]
        public Body body
        {
            get;
            set;
        }

        [JsonProperty("start")]
        public TimeEntry start
        {
            get;
            set;
        }

        [JsonProperty("end")]
        public TimeEntry end
        {
            get;
            set;
        }

        [JsonProperty("location")]
        public Location location
        {
            get;
            set;
        }

        [JsonProperty("attendees")]
        public IList<Attendee> attendees
        {
            get;
            set;
        }

        [JsonProperty("organizer")]
        public Organizer organizer
        {
            get;
            set;
        }
    }
}
