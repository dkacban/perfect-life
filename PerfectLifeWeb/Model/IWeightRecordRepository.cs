using System.Collections.Generic;

namespace PerfectLifeWebService.Model
{
    public interface IWeightRecordRepository
    {
        void AddRecord(WeightRecord record);
        IEnumerable<WeightRecord> GetRecords(string userName);
    }
}
