using ConferenceTracker.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConferenceTracker.Data;
using Newtonsoft.Json;
using ConferenceTracker.Configurations;
using ConferenceTracker.Infrastructure;

namespace ConferenceTracker.Services
{
    public class EventsService : BaseService, IEventsService
    {
        public EventsService(IApiConfiguration configuration)
            : base(configuration)
        {
        }

        public async Task<GeneralResponse<IEnumerable<Event>>> GetAllEvents()
        {
            string endpoint = "api/events";

            GeneralResponse<IEnumerable<Event>> result = new GeneralResponse<IEnumerable<Event>>();

            var uri = new Uri(configuration.ApiBaseUri + endpoint);

            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                result.IsSuccess = true;

                var content = await response.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<List<Event>>(content);
                result.Value = deserialized;
            }

            return result;
        }
    }
}
