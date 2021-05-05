using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {

        private readonly ICalendarService Icalendar;

        public CalendarController(ICalendarService IC)
        {
            Icalendar = IC;
        }


        [HttpGet]
        [Route("GetCalendar")]
        public IEnumerable<Calendar> GetCalendar()
        {
            return Icalendar.GetCalendar();
        }

        [HttpGet]
        [Route("GetCalendarById")]
        public Calendar GetCalendarById(int id)
        {
            return Icalendar.GetCalendarById(id);
        }



        [HttpPost]
        [Route("AddCalendar")]
        public Calendar AddCalendar(Calendar cal)
        {
            return Icalendar.AddCalendar(cal);
        }


        [HttpPut]
        [Route("UpdateCalendar")]
        public Calendar UpdateCalendar(Calendar cal)
        {
            return Icalendar.UpdateCalendar(cal);
        }


        [HttpDelete]
        [Route("DeleteCalendar")]
        public Calendar DeleteCalendar(int id)
        {
            return Icalendar.DeleteCalendar(id);
        }
    }
}

