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
    public class BasketController : ControllerBase
    {

        private readonly IBasketService Ibasket;

        public BasketController(IBasketService Ib)
        {
            Ibasket = Ib;
        }


        [HttpGet]
        [Route("GetTaskbasket")]
        public IEnumerable<Taskbasket> GetTaskbasket()
        {
            return Ibasket.GetTaskbasket();
        }

        [HttpGet]
        [Route("GetBasketById")]
        public Taskbasket GetBasketById(int id)
        {
            return Ibasket.GetBasketById(id);
        }



        [HttpPost]
        [Route("AddTaskbasket")]
        public Taskbasket AddTaskbasket(Taskbasket basket)
        {
            return Ibasket.AddTaskbasket(basket);
        }


        [HttpPut]
        [Route("UpdateTaskbasket")]
        public Taskbasket UpdateTaskbasket(Taskbasket basket)
        {
            return Ibasket.UpdateTaskbasket(basket);
        }


        [HttpDelete]
        [Route("DeleteCondition")]
        public Taskbasket DeleteCondition(int id)
        {
            return Ibasket.DeleteTaskbasket(id);
        }
    }
}

