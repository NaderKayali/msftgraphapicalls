using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class ContactEntry
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

        [JsonProperty("createdDateTime")]
        public DateTime createdDateTime
        {
            get;
            set;
        }


        [JsonProperty("lastModifiedDateTime")]
        public DateTime lastModifiedDateTime
        {
            get;
            set;
        }

        [JsonProperty("changeKey")]
        public string changeKey
        {
            get;
            set;
        }


        [JsonProperty("categories")]
        public List<object> categories
        {
            get;
            set;
        }

        [JsonProperty("parentFolderId")]
        public string parentFolderId
        {
            get;
            set;
        }


        [JsonProperty("bithday")]
        public object birthday
        {
            get;
            set;
        }

        [JsonProperty("fileAs")]
        public string fileAs
        {
            get;
            set;
        }

        [JsonProperty("displayName")]
        public string displayName
        {
            get;
            set;
        }

        [JsonProperty("givenName")]
        public string givenName
        {
            get;
            set;
        }

        [JsonProperty("initials")]
        public object initials
        {
            get;
            set;
        }

        [JsonProperty("middleName")]
        public object middleName
        {
            get;
            set;
        }

        [JsonProperty("nickName")]
        public object nickName
        {
            get;
            set;
        }

        [JsonProperty("surname")]
        public string surname
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public object title
        {
            get;
            set;
        }

        [JsonProperty("yomiGivenName")]
        public object yomiGivenName
        {
            get;
            set;
        }

        [JsonProperty("yomiSurname")]
        public object yomiSurname
        {
            get;
            set;
        }

        [JsonProperty("yomiCompanyName")]
        public object yomiCompanyName
        {
            get;
            set;
        }

        [JsonProperty("generation")]
        public object generation
        {
            get;
            set;
        }

        [JsonProperty("imAddresses")]
        public List<object> imAddresses
        {
            get;
            set;
        }

        [JsonProperty("jobTitle")]
        public object jobTitle
        {
            get;
            set;
        }

        [JsonProperty("companyName")]
        public object companyName
        {
            get;
            set;
        }

        [JsonProperty("department")]
        public object department
        {
            get;
            set;
        }

        [JsonProperty("officeLocation")]
        public object officeLocation
        {
            get;
            set;
        }

        [JsonProperty("profession")]
        public object profession
        {
            get;
            set;
        }

        [JsonProperty("businessHomePage")]
        public object businessHomePage
        {
            get;
            set;
        }

        [JsonProperty("assistantName")]
        public object assistantName
        {
            get;
            set;
        }

        [JsonProperty("manager")]
        public object manager
        {
            get;
            set;
        }

        [JsonProperty("homePhones")]
        public List<object> homePhones
        {
            get;
            set;
        }

        [JsonProperty("mobilePhone")]
        public string mobilePhone
        {
            get;
            set;
        }

        [JsonProperty("businessPhones")]
        public List<object> businessPhones
        {
            get;
            set;
        }

        [JsonProperty("spouseName")]
        public object spouseName
        {
            get;
            set;
        }

        [JsonProperty("personalNotes")]
        public string personalNotes
        {
            get;
            set;
        }

        [JsonProperty("children")]
        public List<object> children
        {
            get;
            set;
        }

        [JsonProperty("emailAddresses")]
        public List<object> emailAddresses
        {
            get;
            set;
        }

        [JsonProperty("homeAddress")]
        public Address homeAddress
        {
            get;
            set;
        }

        [JsonProperty("businessAddress")]
        public Address businessAddress
        {
            get;
            set;
        }

        [JsonProperty("otherAddress")]
        public Address otherAddress
        {
            get;
            set;
        }

    }
}
