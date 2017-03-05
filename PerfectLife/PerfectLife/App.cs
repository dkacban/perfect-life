using System;
using System.Linq;
using Xamarin.Forms;
using PerfectLife.Models;
using PerfectLife.Views;

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

                        //        MasterDetailPage = new MasterDetailPage
                        //        {
                        //            Master = new MenuPage(),
                        //            Detail = new NavigationPage(new BmiCalculatorPage())
                        //        };

                        //        MainPage = MasterDetailPage;

                        NavPage.Navigation.InsertPageBefore(new BmiCalculatorPage(), NavPage.Navigation.NavigationStack.First());
                        NavPage.Navigation.PopToRootAsync();
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
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
    //public class App : Application
    //{
    //    public static MasterDetailPage MasterDetailPage;

    //    public App()
    //    {   

    //        MasterDetailPage = new MasterDetailPage
    //        {
    //            Master = new MenuPage(),
    //            Detail = new NavigationPage(new BmiCalculatorPage())
    //        };

    //        MainPage = MasterDetailPage;
    //    }
    //}
}