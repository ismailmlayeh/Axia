using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class BasketService : IBasketService
    {
        workflowapiContext dbContext;

        public BasketService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Taskbasket> GetTaskbasket()
        {
            var T = dbContext.Taskbasket.ToList();
            return T;
        }

        public Taskbasket GetBasketById(int id)
        {
            var t = dbContext.Taskbasket.FirstOrDefault(x => x.Idtaskbasket == id);


            return t;


        }

        public Taskbasket AddTaskbasket(Taskbasket basket)
        {
            dbContext.Taskbasket.Add(basket);
            dbContext.SaveChanges();
            return basket;
        }

        public Taskbasket UpdateTaskbasket(Taskbasket basket)
        {
            dbContext.Entry(basket).State = EntityState.Modified;
            dbContext.SaveChanges();
            return basket;
        }

        public Taskbasket DeleteTaskbasket(int id)
        {
            var dbas = dbContext.Taskbasket.FirstOrDefault(x => x.Idtaskbasket == id);
            dbContext.Entry(dbas).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return dbas;
        }
    }
}

