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
    public class WorkflowController : ControllerBase
    {
        private readonly IWorkflowService Iworkflowservice;

        public WorkflowController(IWorkflowService Iworkflow)
        {
            Iworkflowservice = Iworkflow;
        }


        [HttpGet]
        public IEnumerable<Workflow> GetWorkflow()
        {
            return Iworkflowservice.GetWorkflow();
        }

        [HttpGet]
        [Route("GetWorkflowById")]
        public Workflow GetWorkflowById(int id)
        {
            return Iworkflowservice.GetWorkflowById(id);
        }

        [HttpPost]
        public Workflow AddWorkflow(Workflow workflow)
        {
            return Iworkflowservice.AddWorkflow(workflow);
        }

        [HttpPut("{id}")]
        public Workflow UpdateWorkflow(int id, Workflow workflow)
        {
            workflow.Idworkflow = id;
            return Iworkflowservice.UpdateWorkflow(workflow);
        }


        [HttpDelete("{id}")]
        public Workflow DeleteWorkflow(int id)
        {
            return Iworkflowservice.DeleteWorkflow(id);
        }
    }
}
