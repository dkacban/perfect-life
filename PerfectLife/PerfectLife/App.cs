using System;
using System.Linq;
using Xamarin.Forms;
using PerfectLife.Models;
using PerfectLife.MenuPages;

namespace PerfectLife
{
    public class App : Application
    {
        public static string AppName { get { return "Perfect Life"; } }

        public static User User { get; set; }

        static NavigationPage NavPage;

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

        public static Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() => {
                    NavPage.Navigation.PopModalAsync();

                    if (IsLoggedIn)
                    {
                        NavPage.Navigation.InsertPageBefore(new BmiCalculatorPage(), NavPage.Navigation.NavigationStack.First());
                        NavPage.Navigation.PopToRootAsync();
                    }
                });
            }
        }

        public App()
        {
            User = new User();

            Page MasterDetailPage = new MasterDetailPage
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new BmiCalculatorPage())
            };

            MainPage = MasterDetailPage;
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