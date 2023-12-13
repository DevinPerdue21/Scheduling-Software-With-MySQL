using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devin_Perdue_Software2.Model
{
    internal class CompanyHours
    {
        private static TimeSpan start = new TimeSpan(8, 0, 0);
        private static TimeSpan end = new TimeSpan(17, 0, 0);

        //This is my first lambda expression. This also cut down on several lines of code and made this easier to read!    
        public Func<TimeSpan, bool> OutsideCompanyHours = (newAppointment) => (newAppointment < start || newAppointment > end);

        //This is the second lamda expression. I utilized this here becuase it kept this on one single line of code instead of several lines!
        public Func<DateTime, DateTime, bool> Overlap = (existingAppointment, newAppointment) => (newAppointment > existingAppointment - TimeSpan.FromMinutes(30) && newAppointment < existingAppointment + TimeSpan.FromMinutes(30));

        //This is the third lamda expression. I utilized this here becuase it cut down on several lines of code as well and made it easier to read!
        public Func<DateTime, DateTime, bool> UpcomingAppointemnt = (existingAppointment, currentTime) => existingAppointment > currentTime && existingAppointment <= currentTime.AddMinutes(15);



    }
}
