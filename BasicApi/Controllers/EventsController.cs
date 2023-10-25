using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private static List<Event> events = new List<Event> { new Event {Start = DateTime.Now,Title="jjjjjj" }, { new Event { Start = DateTime.Now } } };

        
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable <Event> Get()
        {
            return events;
        }

        
        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            newEvent.Id++;
            events.Add(newEvent);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string title)
        {
            var eve = events.Find(e => e.Id == id);
            eve.Title= title;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = events.Find(e => e.Id == id);
            events.Remove(eve);
        }
    }
}
