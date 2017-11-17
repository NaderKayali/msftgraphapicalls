using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msftgraphapicalls
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            //Console.WriteLine();
            //Console.WriteLine("SENDING EMAIL");
            //Console.WriteLine();

            //string emailSubject = "sent email test Subject";
            //string emailContent = "sent email test Content";
            //string[] emailRecipients = { "nader-kayali@hotmail.com" };
            //MainClient.SendMeAsync(emailSubject, emailContent, emailRecipients).Wait();


            //Console.WriteLine();
            //Console.WriteLine("Getting User Info");
            //Console.WriteLine();

            //UserProfile currentUser = MainClient.getUserInfo().Result;
            //Console.WriteLine(currentUser.DisplayName);
            //Console.WriteLine(currentUser.Mail);
            //Console.WriteLine(currentUser.GivenName);


            //Console.WriteLine();
            //Console.WriteLine("Getting User Events");
            //Console.WriteLine();

            //ListOfCalendarEvents userList = MainClient.getUserEvents().Result;
            //Console.WriteLine(userList.CalendarEntry.Count);

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(userList.CalendarEntry[i].subject);
            //}


            //Console.WriteLine();
            //Console.WriteLine("Getting User Contacts");
            //Console.WriteLine();

            //ListOfContacts userContactList = MainClient.getUserContacts().Result;
            //Console.WriteLine(userContactList.ContactEntry.Count);

            //for (int i = 0; i < userContactList.ContactEntry.Count; i++)
            //{
            //    Console.WriteLine(userContactList.ContactEntry[i].displayName);
            //}


            //Console.WriteLine();
            //Console.WriteLine("Getting User Emails");
            //Console.WriteLine();

            //ListOfEmails userMails = MainClient.getUserEmails().Result;
            //Console.WriteLine(userMails.UserEmailEntry.Count);

            //for (int i = 0; i < userMails.UserEmailEntry.Count; i++)
            //{
            //    Console.WriteLine(userMails.UserEmailEntry[i].subject);
            //}

            Console.Read();
        }
    }
}
