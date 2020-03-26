using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica12
{
   
    class Program
    {
        struct MeetingInfo
        {
            public string Descript;
            public int Year;
            public int Month;
            public int Day;
            public int Hour;
            public int Minute;
            public int Seconds;
        };

        static MeetingInfo InputMeetingInfo()
        {
            MeetingInfo meeting = new MeetingInfo() ;

            Console.WriteLine("Input description");
            meeting.Descript = Console.ReadLine();
            Console.WriteLine("Input Year");
            meeting.Year = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Input Month");
                meeting.Month = int.Parse(Console.ReadLine());
            }   while (meeting.Month > 12 || meeting.Month < 1);
            do
            {
                Console.WriteLine("Input Day");
                meeting.Day = int.Parse(Console.ReadLine());
            }   while (meeting.Day > 31);
            do
            {
                Console.WriteLine("Input Hour");
                meeting.Hour = int.Parse(Console.ReadLine());
            }   while (meeting.Hour > 24);
            do
            {
                Console.WriteLine("Input Minute");
                meeting.Minute = int.Parse(Console.ReadLine());
            } while (meeting.Minute > 59);
            do
            {
                Console.WriteLine("Input Seconds");
                meeting.Seconds = int.Parse(Console.ReadLine());
            } while (meeting.Seconds > 59);
            return meeting;
        }

        static void Main(string[] args)
        {
            MeetingInfo meeting = InputMeetingInfo();
            DateTime CurrentTime = DateTime.Now;
            DateTime MeetingTime = new DateTime(meeting.Year, meeting.Month, meeting.Day, meeting.Hour, meeting.Minute, meeting.Seconds);
            Console.WriteLine("{0}", CurrentTime > MeetingTime ? "YOU ARE LATE" : "YOU AREN'T LATE");
            return;
        }
    }
}
