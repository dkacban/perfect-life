using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace PerfectLife
{
    using System.Net.Http;

    public class BmiCalculatorPage : ContentPage
    {
        private ActivityIndicator activityIndicator;

        async void OnCalculateButtonClicked(object sender, EventArgs args)
        {
            var weightWithUnit = weightPicker.Items[weightPicker.SelectedIndex];
            var weight = int.Parse(weightWithUnit.Substring(0, weightWithUnit.Length - 3));

            var heightWithUnit = heightPicker.Items[heightPicker.SelectedIndex];
            var heightInCentimeters = double.Parse(heightWithUnit.Substring(0, heightWithUnit.Length - 3));


            calculateButton.IsEnabled = false;
            activityIndicator.IsRunning = true;
            weightPicker.IsEnabled = false;
            heightPicker.IsEnabled = false;

            var apiUrl = $"http://bmicalcwebservice20170123012446.azurewebsites.net/api/bmi/{heightInCentimeters}/{weight}";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(apiUrl))
            using (HttpContent content = response.Content)
            {
                string result = await content.ReadAsStringAsync();
                resultLabel.Text = $"Twój wskaźnik BMI wynosi {result}";
            }

            activityIndicator.IsRunning = false;
            calculateButton.IsEnabled = true;
            weightPicker.IsEnabled = true;
            heightPicker.IsEnabled = true;
        }

        Picker weightPicker = new Picker();
        Picker heightPicker = new Picker();

        Button calculateButton = new Button
        {
            Text = "Oblicz"
        };

        Label resultLabel = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
            Text = "---"
        };


        public BmiCalculatorPage()
        {
            for (int i = 40; i <= 180; i++)
            {
                weightPicker.Items.Add(i + " KG");
                weightPicker.SelectedIndex = 40;
            }

            for (int i = 120; i <= 200; i++)
            {
                heightPicker.Items.Add(i + " CM");
                heightPicker.SelectedIndex = 55;
            }

            calculateButton.Clicked += OnCalculateButtonClicked;

            activityIndicator = new ActivityIndicator
            {
                IsRunning = false,
                Color = Color.Red,

            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    activityIndicator,

                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Sprawdź swój BMI"
                    },

                    new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Children = {

                            new StackLayout
                            {
                                VerticalOptions = LayoutOptions.Center,
                                Spacing = 15,
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Waga"
                                    },
                                    weightPicker
                                }
                            },
                            new StackLayout
                            {
                                VerticalOptions = LayoutOptions.Center,
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Wzrost"
                                    },
                                    heightPicker
                                }
                            },
                            calculateButton,
                            resultLabel
                        }
                    }
                }
            };
        }
    }
}
