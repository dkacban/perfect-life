using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectLifeWebService.Model
{
    public interface IWeightRecordRepository
    {
        void AddRecord(WeightRecord record);
        void GetRecords(string userName);
    }
}
