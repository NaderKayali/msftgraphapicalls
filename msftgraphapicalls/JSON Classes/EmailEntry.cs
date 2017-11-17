using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    public class EmailEntry
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

        [JsonProperty("createdDateTime")] //check
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

        [JsonProperty("receivedDateTime")]
        public DateTime receivedDateTime
        {
            get;
            set;
        }

        [JsonProperty("sentDateTime")]
        public DateTime sentDateTime
        {
            get;
            set;
        }

        [JsonProperty("hasAttachments")]
        public bool hasAttachments
        {
            get;
            set;
        }

        [JsonProperty("internetMessageId")]
        public string internetMessageId
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

        [JsonProperty("importance")]
        public string importance
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

        [JsonProperty("conversationId")]
        public string conversationId
        {
            get;
            set;
        }

        [JsonProperty("isDeliveryReceiptRequested")]
        public bool? isDeliveryReceiptRequested
        {
            get;
            set;
        }

        [JsonProperty("isReadReceiptRequested")]
        public bool isReadReceiptRequested
        {
            get;
            set;
        }

        [JsonProperty("isRead")]
        public bool isRead
        {
            get;
            set;
        }

        [JsonProperty("isDraft")]
        public bool isDraft
        {
            get;
            set;
        }

        [JsonProperty("webLink")]
        public string webLink
        {
            get;
            set;
        }

        [JsonProperty("inferenceClassification")]
        public string inferenceClassification
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

        [JsonProperty("sender")]
        public EmailExchangeMember sender
        {
            get;
            set;
        }

        [JsonProperty("from")]
        public EmailExchangeMember from
        {
            get;
            set;
        }

        [JsonProperty("toRecipients")]
        public List<EmailExchangeMember> toRecipients
        {
            get;
            set;
        }

        [JsonProperty("ccRecipients")]
        public List<EmailExchangeMember> ccRecipients
        {
            get;
            set;
        }

        [JsonProperty("bccRecipients")]
        public List<EmailExchangeMember> bccRecipients
        {
            get;
            set;
        }

        [JsonProperty("replyTo")]
        public List<object> replyTo
        {
            get;
            set;
        }

    }
}
