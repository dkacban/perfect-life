using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using perfectlife.Services;

namespace PerfectLife
{
    public class DataPoint
    {
        public string Date { get; set; }
        public double Weight { get; set; }
    }

    public class StatsViewModel
    {
        IEnumerable<DataPoint> _records;

        public StatsViewModel()
        {

        }

        public ObservableCollection<DataPoint> BmiData
        {
            get
            {
                var client = new PerfectLifeWebServiceClient();
                var result = client.GetRecords(App.User.Email).Result;
                _records = result.Select(r => new DataPoint { Date = r.DateTime.Date.ToString("dd-MM-yyyy"), Weight = r.Weight });
                return new ObservableCollection<DataPoint>(_records);
            }
        }
    }
}
