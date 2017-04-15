using System.Collections.Generic;
using System.Linq;

namespace PerfectLifeWebService.Model
{
    public class WeightRecordInMemoryRepository : IWeightRecordRepository
    {
        private IEnumerable<WeightRecord> _weightRecords = new List<WeightRecord>();

        public void AddRecord(WeightRecord record)
        {
            _weightRecords.Append(record);
        }

        public IEnumerable<WeightRecord> GetRecords(string userName)
        {
            return _weightRecords;
        }
    }
}
