using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLife
{
    public class DataPoint
    {
        public string Date { get; set; }
        public double Bmi { get; set; }
    }

    public class StatsViewModel
    {
        public ObservableCollection<DataPoint> BmiData => new ObservableCollection<DataPoint>
        {
            new DataPoint {Date = "29/11/2017", Bmi = 27.01},
            new DataPoint {Date = "30/10/2017", Bmi = 25.70},
            new DataPoint {Date = "31/09/2017", Bmi = 22.45}
        };
    }
}
