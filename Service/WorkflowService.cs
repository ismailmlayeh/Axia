using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class WorkflowService : IWorkflowService
    {
        workflowapiContext dbcontext;

        public WorkflowService (workflowapiContext _db)
        {
            dbcontext = _db;
        }

        public IEnumerable<Workflow>GetWorkflow()
        {
            var w = dbcontext.Workflow.ToList();
            return w;
        }

        public Workflow GetWorkflowById(int id)
        {
            var c = dbcontext.Workflow.FirstOrDefault(x => x.Idworkflow == id);


            return c;


        }

        public Workflow AddWorkflow(Workflow workflow)
        {

            var checktitle = from d in dbcontext.Workflow
                             where d.WorkflowTitle == workflow.WorkflowTitle

                             select d;



            if (checktitle.FirstOrDefault() == null && (workflow != null))
            {
                dbcontext.Workflow.Add(workflow);
                dbcontext.SaveChanges();
                return workflow;
            }
            return null;
        }

        public Workflow UpdateWorkflow(Workflow workflow)
        {
            dbcontext.Entry(workflow).State = EntityState.Modified;
            dbcontext.SaveChanges();
            return workflow;
        }

        public Workflow DeleteWorkflow(int id)
        {
            var dworkflow = dbcontext.Workflow.FirstOrDefault(x => x.Idworkflow == id);
            dbcontext.Entry(dworkflow).State = EntityState.Deleted;
            dbcontext.SaveChanges();
            return dworkflow;
        }
    }
}
