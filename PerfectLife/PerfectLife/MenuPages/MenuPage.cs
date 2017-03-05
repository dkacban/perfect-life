using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerfectLife.Views;
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
                    new MenuLink("Kalkulator BMI", new BmiCalculatorPage()),
                    new MenuLink("Statystyki", new Charts())
                }
            };
            Title = "Master";
            BackgroundColor = Color.Gray;
            Icon = "menu.png";
        }
    }
}
