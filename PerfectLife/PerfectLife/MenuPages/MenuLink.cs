using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PerfectLife.MenuPages
{
    public class MenuLink : Button
    {
        public MenuLink(string text, ContentPage page)
        {
            Text = text;
            Command = new Command(o => {
                //App.MasterDetailPage.Detail = new NavigationPage(page);
                //App.MasterDetailPage.IsPresented = false;
            });
        }
    }
}
