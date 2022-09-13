using APIDemo.Models;
using APIDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public List<Ticket> Get()
        {
            return TicketServices.GetAll();
        }

        [HttpPost]
        [Route("{id}")]
        public Ticket Get(int ID)
        {
            Ticket t = TicketServices.Get(ID);
            return t;
        }
    }
}
