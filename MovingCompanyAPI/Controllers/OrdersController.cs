using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovingCompanyAPI.Models;

namespace MovingCompanyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpPost, Route("AddOrder")]
        public async Task<IActionResult> AddOrder([FromBody] PlaceOrder newData)
        {
            try
            {
                using (var context = new MovingCompanyContext())
                {
                    Person newPerson = context.Person.SingleOrDefault(person => person.Mail == newData.Mail);
                    Person tempPerson = newPerson ?? new Person { Mail = newData.Mail, Name = newData.Name, PhoneNumber = newData.PhoneNumber };
                    if (newPerson == null)
                    {
                        context.Person.Add(tempPerson);
                        context.SaveChanges();
                    }

                    Orders newOrder = new Orders { From = newData.From, Date = newData.Date, Note = newData.Note, PersonId = tempPerson.Id, To = newData.To, WorkType = newData.WorkType };
                    context.Orders.Add(newOrder);
                    context.SaveChanges();
                }
            }
            catch (InvalidCastException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }


        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            using (var context = new MovingCompanyContext())
            {
                return context.Orders.ToList();
            }
        }
    }
}
