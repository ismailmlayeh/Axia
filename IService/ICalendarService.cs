using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
   public interface ICalendarService
    {
        public IEnumerable<Calendar> GetCalendar();
        public Calendar GetCalendarById(int id);
        public Calendar AddCalendar(Calendar c);
        public Calendar UpdateCalendar(Calendar c);
        public Calendar DeleteCalendar(int id);
    }
}
