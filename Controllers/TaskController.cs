using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;

namespace webapiworkflow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService Itaskservice;

        public TaskController(ITaskService Itask)
        {
            Itaskservice = Itask;
        }

        [HttpGet]
        public IEnumerable<Models.Task> GetDomains()
        {
            return Itaskservice.GetTasks();
        }

        [HttpGet]
        [Route("GetTaskById")]
        public Models.Task GetTaskById(int id)
        {
            return Itaskservice.GetTaskById(id);
        }

        [HttpPost]

        public Models.Task AddTask(Models.Task task)
        {
            return Itaskservice.AddTask(task);
        }


        [HttpPut("{id}")]
            

            public Models.Task UpdateTask(int id, Models.Task task)
            {
            task.Idtask = id;
            return Itaskservice.UpdateTask(task);
            }


            [HttpDelete("{id}")]
            
            public Models.Task DeleteTask(int id)
            {
                return Itaskservice.DeleteTask(id);
            }
        }
    }

