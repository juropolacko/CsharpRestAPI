using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    public class SubscribersController : ControllerBase
    {
        // Returns compactly the data (name, surname and email) about every subscriber from the list with ID 1.
        [Route("api/subscribers")]
        [HttpGet]
        public async Task<List<SubscriberData>> GetAsync()
        {
            return await APIWrapper.GetSubscribers();
        }

        // Adds new subscriber to the list.
        [Route("api/subscribe")]
        [HttpPost]
        public async Task<string> Post(SubscriberDataRoot data)
        {
            return await APIWrapper.PerformRequest(APIWrapper.Method.POST, data);
        }

        // Updates the information about given subscribe identified by his email.
        [Route("api/update-subscriber")]
        [HttpPut]
        public async Task<string> Put(SubscriberDataUpdateRoot data)
        {
            return await APIWrapper.PerformRequest(APIWrapper.Method.PUT, data);
        }

        // Deletes the subscriber from the list.
        [HttpDelete]
        [Route("api/delete-subscriber/{email:maxlength(100)}")]
        public async Task<string> Delete(string email)
        {
            return await APIWrapper.DeleteSubscriber(email);
        }
    }
}