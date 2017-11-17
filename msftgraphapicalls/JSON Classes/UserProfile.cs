using Newtonsoft.Json;
using System.Collections.Generic;

namespace msftgraphapicalls
{
    public class UserProfile
    {
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName
        {
            get;
            set;
        }

        [JsonProperty("businessPhones")]
        public List<string> BusinessPhones
        {
            get;
            set;
        }

        [JsonProperty("displayName")]
        public string DisplayName
        {
            get;
            set;
        }

        [JsonProperty("givenName")]
        public string GivenName
        {
            get;
            set;
        }

        [JsonProperty("jobTitle")]
        public object JobTitle
        {
            get;
            set;
        }

        [JsonProperty("mail")]
        public string Mail
        {
            get;
            set;
        }

        [JsonProperty("mobilePhone")]
        public string MobilePhone
        {
            get;
            set;
        }

        [JsonProperty("officeLocation")]
        public object OfficeLocation
        {
            get;
            set;
        }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage
        {
            get;
            set;
        }

        [JsonProperty("surname")]
        public string Surname
        {
            get;
            set;
        }

    }
}
