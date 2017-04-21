using System;

namespace PerfectLifeWebService.Model
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
}