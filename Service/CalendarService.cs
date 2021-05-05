using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class CalendarService : ICalendarService
    {
        workflowapiContext dbContext;

        public CalendarService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Calendar> GetCalendar()
        {
            var C = dbContext.Calendar.ToList();
            return C;
        }

        public Calendar GetCalendarById(int id)
        {
            var c = dbContext.Calendar.FirstOrDefault(x => x.Idcalendar == id);


            return c;


        }

        public Calendar AddCalendar(Calendar c)
        {
            dbContext.Calendar.Add(c);
            dbContext.SaveChanges();
            return c;
        }

        public Calendar UpdateCalendar(Calendar c)
        {
            dbContext.Entry(c).State = EntityState.Modified;
            dbContext.SaveChanges();
            return c;
        }

        public Calendar DeleteCalendar(int id)
        {
            var dc = dbContext.Calendar.FirstOrDefault(x => x.Idcalendar == id);
            dbContext.Entry(dc).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return dc;
        }
    }
}

