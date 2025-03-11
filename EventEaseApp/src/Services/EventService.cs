using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<Event> events;

        public EventService()
        {
            events = new List<Event>
            {
                new Event { Id = 1, Name = "Concert", Date = "2023-12-01", Location = "Stadium" },
                new Event { Id = 2, Name = "Art Exhibition", Date = "2023-12-10", Location = "Gallery" }
            };
        }

        public Task<List<Event>> GetEventsAsync()
        {
            return Task.FromResult(events);
        }

        public Task<Event> GetEventByIdAsync(int id)
        {
            var eventItem = events.Find(e => e.Id == id);
            return Task.FromResult(eventItem);
        }
    }

    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
    }
}