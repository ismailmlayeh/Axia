using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
   public interface IConditionValueService
    {
        public IEnumerable<Conditionvalue> GetConditionvalues();
        public Conditionvalue GetConditionvalueById(int id);
        public Conditionvalue AddConditionValue(Conditionvalue conval);
        public Conditionvalue UpdateConditionValue(Conditionvalue conval);
        public Conditionvalue DeleteConditionValue(int id);
    }
}
