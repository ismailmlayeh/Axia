using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
   public interface IBasketService
    {
        public IEnumerable<Taskbasket> GetTaskbasket();
        public Taskbasket GetBasketById(int id);
        public Taskbasket AddTaskbasket(Taskbasket con);
        public Taskbasket UpdateTaskbasket(Taskbasket con);
        public Taskbasket DeleteTaskbasket(int id);
    }
}
