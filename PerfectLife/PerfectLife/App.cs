using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Xamarin.Forms;
using PerfectLife.MenuPages;

namespace PerfectLife
{
    public class App : Application
    {
        public static MasterDetailPage MasterDetailPage;

        public App()
        {   

            MasterDetailPage = new MasterDetailPage
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new BmiCalculatorPage())
            };

            MainPage = MasterDetailPage;
        }
    }
}