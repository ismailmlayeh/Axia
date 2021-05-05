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
    public class ConditionController : ControllerBase
    {
        private readonly IConditionService Icon;

        public ConditionController(IConditionService ICondition)
        {
            Icon = ICondition;
        }


        [HttpGet]
        [Route("GetCondition")]
        public IEnumerable<Condition>GetCondition()
        {
           return Icon.GetCondition();
        }

        [HttpGet]
        [Route("GetConditionById")]
        public Condition GetConditionById(int id)
        {
            return Icon.GetConditionById(id);
        }


        [HttpPost]
        [Route("AddCondition")]
        public Condition AddCondition(Condition condition)
        {
            return Icon.AddCondition(condition);
        }


        [HttpPut]
        [Route("UpdateCondition")]
        public Condition UpdateCondition(Condition condition)
        {
            return Icon.UpdateCondition(condition);
        }


        [HttpDelete]
        [Route("DeleteCondition")]
        public Condition DeleteCondition(int id)
        {
            return Icon.DeleteCondition(id);
        }
    }
}
