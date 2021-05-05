using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiworkflow.IService
{
   public  interface ITaskService
    {
        public IEnumerable<Models.Task> GetTasks();
        public Models.Task GetTaskById(int id);
        public Models.Task AddTask(Models.Task workflow);
        public Models.Task UpdateTask(Models.Task workflow);
        public Models.Task DeleteTask(int id);
    }
}
