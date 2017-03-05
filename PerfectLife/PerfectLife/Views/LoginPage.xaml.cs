using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PerfectLife.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnLoginClicked(object sender, EventArgs e)
        {
            // Use a custom renderer to display the authentication UI

            //await DisplayAlert("ok2", "ok2", "ok2");

            var page = new AuthenticationPage();

            //await DisplayAlert("ok3", "ok3", "ok3");

            await Navigation.PushModalAsync(page);

        }
    }
}
