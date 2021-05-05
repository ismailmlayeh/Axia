using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class TaskService : ITaskService
    {
        workflowapiContext dbContext;

        public TaskService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Models.Task> GetTasks()
        {
            var T = dbContext.Task.ToList();
            return T;
        }

        public Models.Task GetTaskById(int id)
        {
            var c = dbContext.Task.FirstOrDefault(x => x.Idtask == id);


            return c;


        }

        public Models.Task AddTask(Models.Task task)
        {

            var checktitle = from d in dbContext.Task
                             where d.TaskTitle == task.TaskTitle

                             select d;



            if (checktitle.FirstOrDefault() == null && (task != null))
                
            {
                dbContext.Task.Add(task);
                dbContext.SaveChanges();
                return task;
            }
            return null;
        }

        public Models.Task UpdateTask(Models.Task task)
        {
            dbContext.Entry(task).State = EntityState.Modified;
            dbContext.SaveChanges();
            return task;
        }

        public Models.Task DeleteTask(int id)
        {
            var dtask = dbContext.Task.FirstOrDefault(x => x.Idtask == id);
            dbContext.Entry(dtask).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return dtask;
        }

    }
}
