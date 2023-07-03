using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Linq;

namespace CalendarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace with your own client ID and client secret
            string clientId = "971768108935-04vga7hgbvhidfovduigokltj8luh9j4.apps.googleusercontent.com";
            string clientSecret = "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";

            // Authenticate and authorize the Google Calendar API
            UserCredential credential;
            using (FileStream stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { CalendarService.Scope.Calendar },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create a new Calendar API service
            CalendarService service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "CalendarApp"
            });

            // Get a list of calendars
            CalendarList calendarList = service.CalendarList.List().Execute();
            Console.WriteLine("Calendars:");
            //IEnumerable<CalendarListEntry> calendars = calendarList.Items.Where(e => e.Description.Contains("besar"));
            // IEnumerable<CalendarListEntry> calendars = from calendar in calendarList.Items
            //                                             where calendar.Description.Length > 1
            //                                             select calendar ;

            foreach (CalendarListEntry calendar in calendarList.Items)
            {
                string? description = calendar.Description;
                if(description != null)
                {

                    if (description.Contains("besar"))
                    {
                        Console.WriteLine("- " + calendar.Summary);
                    }
                }
                    
                    // Console.WriteLine("- " + description);
                    // Console.WriteLine("- " + calendar.Summary);
            }

            Console.WriteLine("Enter the name of the calendar you want to add an event to:");
            string calendarName = Console.ReadLine();

            // Find the calendar with the specified name
            CalendarListEntry  calendarToModify = null;
            foreach (CalendarListEntry calendar in calendarList.Items)
            {
                if (calendar.Summary == calendarName)
                {
                    calendarToModify = calendar;
                    break;
                }
            }

            if (calendarToModify == null)
            {
                Console.WriteLine("Calendar not found.");
                return;
            }

            Console.WriteLine("Enter the summary of the event:");
            string eventSummary = Console.ReadLine();

            Console.WriteLine(
                "Enter the start date and time of the event in the format yyyy-mm-dd hh:mm (24 hour time):");
            string startDateTimeString = Console.ReadLine();
            DateTime startDateTime = DateTime.Parse(startDateTimeString);

            Console.WriteLine(
                "Enter the end date and time of the event in the format yyyy-mm-dd hh:mm (24 hour time):");
            string endDateTimeString = Console.ReadLine();
            DateTime endDateTime = DateTime.Parse(endDateTimeString);

            Console.WriteLine("Enter a description for the event:");
            string eventDescription = Console.ReadLine();

            Console.WriteLine("Enter the location for the event:");
            string eventLocation = Console.ReadLine();

            Console.WriteLine("Enter the email address of the attendee:");
            string emailAddress = Console.ReadLine();
            Event newEvent = new Event
            {
                Summary = eventSummary,
                Start = new EventDateTime
                {
                    DateTime = startDateTime,
                    TimeZone = "GMT+7"
                },
                End = new EventDateTime
                {
                    DateTime = endDateTime,
                    TimeZone = "GMT+7"
                },
                Attendees = new List<EventAttendee>()
                {
                    new EventAttendee()
                    {
                        Email = emailAddress,
                    }
                },
                Description = eventDescription,
                Location = eventLocation
            };

            // Add the event to the calendar
            service.Events.Insert(newEvent, calendarToModify.Id).Execute();
            Console.WriteLine("Event added to calendar successfully!");
        }
    }
}