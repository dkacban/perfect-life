using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PerfectLife.MenuPages
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                Children =
                {
                    new MenuLink("Bmi Calculator", new BmiCalculatorPage())
                }
            };
            Title = "Master";
            BackgroundColor = Color.Gray;
            Icon = "menu.png";
        }
    }
}
