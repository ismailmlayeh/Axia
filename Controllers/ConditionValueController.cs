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
    public class ConditionValueController : ControllerBase
    {
        private readonly IConditionValueService Iconval;

        public ConditionValueController(IConditionValueService Iconditionvalue)
        {
            Iconval = Iconditionvalue;
        }

        [HttpGet]
        public IEnumerable<Conditionvalue> GetConditionValue()
        {
          return  Iconval.GetConditionvalues();
        }

        [HttpGet]
        [Route("GetConditionvalueById")]
        public Conditionvalue GetConditionvalueById(int id)
        {
            return Iconval.GetConditionvalueById(id);
        }

        [HttpPost]
        public Conditionvalue AddConditionValue(Conditionvalue conval)
        {
            return Iconval.AddConditionValue(conval);
        }

        [HttpPut("{id}")]
        public Conditionvalue UpdateConditionValue(int id, Conditionvalue conval)
        {
            conval.Idconditionvalue = id;
            return Iconval.UpdateConditionValue(conval);
        }

        [HttpDelete("{id}")]
        public Conditionvalue DeleteConditionValue(int id)
        {
            return Iconval.DeleteConditionValue(id);
        }
    }
}
