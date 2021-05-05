using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
    public interface IConditionService
    {
        public IEnumerable<Condition> GetCondition();
        public Condition GetConditionById(int id);
        public Condition AddCondition(Condition con);
        public Condition UpdateCondition(Condition con);
        public Condition DeleteCondition(int id);

    }
}
