using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PerfectLife
{
    public class App : Application
    {
        void OnCalculateButtonClicked(object sender, EventArgs args)
        {
            var weightWithUnit = weightPicker.Items[weightPicker.SelectedIndex];
            var weight = int.Parse(weightWithUnit.Substring(0, weightWithUnit.Length - 3));

            var heightWithUnit = heightPicker.Items[heightPicker.SelectedIndex];
            var heightInMeters = double.Parse(heightWithUnit.Substring(0, heightWithUnit.Length - 3)) /100;

            double bmi = weight / Math.Pow(heightInMeters, 2);

            resultLabel.Text = bmi.ToString();
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


        public App()
        {
            for(int i = 40; i<=180; i++)
            {
                weightPicker.Items.Add(i + " KG");
                weightPicker.SelectedIndex = 40;
            }

            for (int i = 120; i <= 200; i++)
            {
                heightPicker.Items.Add(i + " CM");
                heightPicker.SelectedIndex = 55;
            }

            calculateButton.Clicked += this.OnCalculateButtonClicked;

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
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
                                    Orientation = StackOrientation.Vertical,
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
                                    Orientation = StackOrientation.Vertical,
                                    Children =
                                    {
                                        new Label()
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
                }
            };
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
}
