using System;
using System.Collections.Generic;
using PerfectLife;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;

namespace perfectlife.Services
{
    public class PerfectLifeWebServiceClient
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

        public void AddRecord(WeightRecord record)
        {

        }

        public async Task<List<WeightRecord>> GetRecords(string userName)
        {
            var result = new List<WeightRecord>();

            var apiUrl = $"http://{Constants.WebServiceServer}/api/weight?userName={userName}";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(apiUrl))
            using (HttpContent content = response.Content)
            {
                string webRequestResult = await content.ReadAsStringAsync();
            }


            return result;
        }
    }
}
