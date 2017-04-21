using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<WeightRecord> GetRecords(string userName)
        {
            var result = new List<WeightRecord>();

            return result;
        }
    }
}
