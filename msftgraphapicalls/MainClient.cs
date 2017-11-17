using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace msftgraphapicalls
{

    public static class MainClient
    {
        public static Microsoft.Identity.Client.AuthenticationResult authResult { get; set; }

        public static string[] scopes
        {
            get
            {
                string[] scopes = { "Calendars.Read", "Calendars.ReadWrite", "Contacts.Read", "Contacts.ReadWrite", "Mail.Read", "Mail.ReadWrite", "Mail.Send", "Notes.Create", "Notes.Read", "Notes.Read.All", "Notes.ReadWrite", "Notes.ReadWrite.All", "People.Read", "User.Read" };
                return scopes;
            }
        }

        public static string ClientID
        {
            get { return "e7554ab4-6f7f-49e5-a6e6-0ce2d52c03e2"; }
        }

        public static string GraphResource
        {
            get { return "https://graph.microsoft.com/"; }
        }

        public static string GraphVersion
        {
            get { return "v1.0"; }
        }

        public static HttpClient GetHttpClient(string accessToken)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            return httpClient;
        }



        public static async Task<ListOfCalendarEvents> getUserEvents()
        {

            var accessToken = await GetAccessToken();
            var httpClient = GetHttpClient(accessToken);

            var callResponse = await httpClient.GetStringAsync(GraphResource + GraphVersion + "/me/events");

            ListOfCalendarEvents eventList = JsonConvert.DeserializeObject<ListOfCalendarEvents>(callResponse);
            return eventList;

        }


        public static async Task<ListOfEmails> getUserEmails()
        {

            var accessToken = await GetAccessToken();
            var httpClient = GetHttpClient(accessToken);

            var callResponse = await httpClient.GetStringAsync(GraphResource + GraphVersion + "/me/messages");

            ListOfEmails emailList = JsonConvert.DeserializeObject<ListOfEmails>(callResponse);
            return emailList;

        }


        public static async Task<ListOfContacts> getUserContacts()
        {

            var accessToken = await GetAccessToken();
            var httpClient = GetHttpClient(accessToken);

            var callResponse = await httpClient.GetStringAsync(GraphResource + GraphVersion + "/me/contacts");

            ListOfContacts contactList = JsonConvert.DeserializeObject<ListOfContacts>(callResponse);
            return contactList;

        }




        public static async Task<UserProfile> getUserInfo()
        {

            var accessToken = await GetAccessToken();
            var httpClient = GetHttpClient(accessToken);
            var user = await GetUserAsync(httpClient);
            return user;
        }

        public static async Task<UserProfile> GetUserAsync(HttpClient httpClient)
        {
            var userResponse = await httpClient.GetStringAsync(GraphResource + GraphVersion + "/me/");
            var user = JsonConvert.DeserializeObject<UserProfile>(userResponse);
            return user;
        }

        public static EmailToSend CreateMail(string subject, string body, params string[] recipients)
        {
            var mail = new EmailToSend
            {
                message = new EmailMessage
                {
                    ToRecipients = recipients.Select(recipient => new EmailExchangeMember
                    {
                        emailAddress = new EmailAddress
                        {
                            address = recipient
                        }
                    }).ToList(),
                    Subject = subject,
                    Body = new Body
                    {
                        contentType = "html",
                        content = body
                    }
                }
            };
            return mail;
        }
        private static async Task<bool> SendMailAsync(HttpClient httpClient, EmailToSend mail)
        {

            var stringContent = JsonConvert.SerializeObject(mail);

            var response = await httpClient.PostAsync(GraphResource + GraphVersion + "/me/microsoft.graph.sendMail",
                new StringContent(stringContent, Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public static async Task SendMeAsync(string subject, string content, params string[] recipients)
        {

            var accessToken = await GetAccessToken();
            var httpClient = GetHttpClient(accessToken);

            var user = await GetUserAsync(httpClient);

            var mail = CreateMail(subject, content, recipients);


            var isSuccess = await SendMailAsync(httpClient, mail);
            if (isSuccess)
            {
                Console.WriteLine("Email successfully sent.");
            }
            else
            {
                // TODO: Handle error
                Console.WriteLine("Something went wrong with sending the email.");
            }
        }

        public async static Task<string> GetAccessToken()
        {
            var clientApplication = new PublicClientApplication(ClientID);
            //var authenticationResult = await clientApplication.AcquireTokenAsync(scopes);
            //return authenticationResult.AccessToken;


            string token = null;


            try
            {
                if (authResult == null)
                {
                    authResult = await clientApplication.AcquireTokenSilentAsync(scopes, clientApplication.Users.FirstOrDefault());
                }
            }
            catch (MsalUiRequiredException ex)
            {
                System.Diagnostics.Debug.WriteLine($"MsalUiRequiredException: {ex.Message}");

                try
                {
                    authResult = await clientApplication.AcquireTokenAsync(scopes);
                }
                catch (MsalException msalex)
                {
                    Console.WriteLine($"Error Acquiring Token:{System.Environment.NewLine}{msalex}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Acquiring Token Silently:{System.Environment.NewLine}{ex}");
            }

            token = authResult.AccessToken;
            return token;
        }

    }
}