using System;
using Xamarin.Forms;
using PerfectLife.Models;
using PerfectLife.MenuPages;
using PerfectLife.Views;

namespace PerfectLife
{
    public class App : Application
    {
        public static string AppName { get { return "Perfect Life"; } }
        public static User User { get; set; }
        static NavigationPage NavPage;
        public static MasterDetailPage MasterDetailPage;


        public static bool IsLoggedIn
        {
            get
            {
                if (User != null)
                    return !string.IsNullOrWhiteSpace(User.Email);
                else
                    return false;
            }
        }

        public Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() =>
                {
                    NavPage.Navigation.PopModalAsync();

                    if (IsLoggedIn)
                    {
                        MasterDetailPage MasterDetailPage = new MasterDetailPage
                        {
                            Master = new MenuPage(),
                            Detail = new NavigationPage(new BmiCalculatorPage())
                        };

                        MainPage = App.MasterDetailPage = MasterDetailPage;
                    }
                });
            }
        }

        public App()
        {
            User = new User();
            NavPage = new NavigationPage(new LoginPage());
            MainPage = NavPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}