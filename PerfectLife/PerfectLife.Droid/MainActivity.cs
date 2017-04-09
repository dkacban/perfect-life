using Android.App;
using Android.Content.PM;
using Android.OS;

namespace PerfectLife.Droid
{
    [Activity(Label = "Perfect Life", Icon = "@drawable/icon", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            new Syncfusion.SfChart.XForms.Droid.SfChartRenderer();

            LoadApplication(new App())
        }
    }
}

