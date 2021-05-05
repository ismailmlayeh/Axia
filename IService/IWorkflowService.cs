using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
    public interface IWorkflowService
    {
        public IEnumerable<Workflow> GetWorkflow();
        public Workflow GetWorkflowById(int id);
        public Workflow AddWorkflow(Workflow workflow);
        public Workflow UpdateWorkflow(Workflow workflow);
        public Workflow DeleteWorkflow(int id);

    }
}