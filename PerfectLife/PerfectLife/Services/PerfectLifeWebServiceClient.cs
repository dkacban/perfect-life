using System;
using System.Collections.Generic;
using PerfectLife;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace perfectlife.Services
{
    public class WeightRecord
    {
        public WeightRecord(string userName, int weight)
        {
            UserName = userName;
            Weight = weight;
            DateTime = DateTime.UtcNow;
        }

        public string UserName { get; private set; }
        public int Weight { get; private set; }
        public DateTime DateTime { get; private set; }
    }

    public class PerfectLifeWebServiceClient
    {
        public async Task<HttpStatusCode> AddRecord(WeightRecord record)
        {
            var apiUrl = $"http://{Constants.WebServiceServer}/api/weight?userName={record.UserName}&weight={record.Weight}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(apiUrl, null);
                return response.StatusCode;
            }
        }

        public async Task<List<WeightRecord>> GetRecords(string userName)
        {
            List<WeightRecord> result;

            var apiUrl = $"http://{Constants.WebServiceServer}/api/weight?userName={userName}";
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = Task.Run(() => client.GetAsync(apiUrl)).Result;

                using (HttpContent content = response.Content)
                {
                    string webRequestResult = await content.ReadAsStringAsync();
                    JArray jsonObject = JArray.Parse(webRequestResult);
                    var deserialized = JsonConvert.DeserializeObject<List<WeightRecord>>(jsonObject.ToString());
                    result = deserialized;
                }
            }

            return result;
        }
    }
}
