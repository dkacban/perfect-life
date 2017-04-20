using System.Collections.Generic;
using System.Linq;

namespace PerfectLifeWebService.Model
{
    public class WeightRecordInMemoryRepository : IWeightRecordRepository
    {
        private static List<WeightRecord> _weightRecords = new List<WeightRecord>();

        public void AddRecord(WeightRecord record)
        {
            _weightRecords.Add(record);
        }

        public IEnumerable<WeightRecord> GetRecords(string userName)
        {
            return _weightRecords.Where(r=>r.UserName == userName);
        }
    }
}
