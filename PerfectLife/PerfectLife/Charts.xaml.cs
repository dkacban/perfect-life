using Xamarin.Forms;

namespace PerfectLife
{
    public partial class Charts : ContentPage
    {
        public Charts()
        {
            InitializeComponent();
            BindingContext = new StatsViewModel();
        }
    }
}