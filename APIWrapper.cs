using System.Text;
using Newtonsoft.Json;
using WebAPI.Models;

namespace WebAPI
{
    public static class APIWrapper
    {
        public const int listID = 1;
        public const string apiKey = "616681b9d563c616681b9d563d";
        public const string ecoMailURI = "https://api2.ecomailapp.cz/";
        public static Uri baseAddress = new Uri(ecoMailURI);
        public enum Method
        {
            POST,
            PUT
        }

        public static async Task<List<SubscriberData>> GetSubscribers()
        {
            List<SubscriberData> subs = new List<SubscriberData>();

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("key", apiKey);

                using (var response = await httpClient.GetAsync("lists/" + listID + "/subscribers"))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    foreach (Datum datum in JsonConvert.DeserializeObject<Root>(responseData).data)
                    {
                        subs.Add(new SubscriberData(datum.subscriber.name, datum.subscriber.surname, datum.subscriber.email));
                    }
                    return subs;
                }
            }
        }
        
        // This method performs either the POST or the PUT request, using data from its body, to either
        // create (POST) or update (PUT).
        public static async Task<string> PerformRequest(Method method, object data)
        {
            HttpResponseMessage response;
            string requestBody = JsonConvert.SerializeObject(data);

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("key", apiKey);

                using (var content = new StringContent(requestBody, Encoding.Default, "application/json"))
                {
                    if (method == Method.POST)
                    {
                        response = await httpClient.PostAsync("lists/" + listID + "/subscribe", content);
                    }
                    else
                    {
                        response = await httpClient.PutAsync("lists/1/update-subscriber", content);
                    }
                    string stringResponse = await response.Content.ReadAsStringAsync();
                    response.Dispose();
                    return stringResponse;
                }
            }
        }

        public static async Task<string> DeleteSubscriber(string email)
        {
            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("key", apiKey);

                using (var response = await httpClient.DeleteAsync("subscribers/" + email + "/delete"))
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }
        
    }
}
