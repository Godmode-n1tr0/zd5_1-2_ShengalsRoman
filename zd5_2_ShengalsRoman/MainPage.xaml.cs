using System;
using Xamarin.Forms;

namespace zd5_2_ShengalsRoman
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameEntry.Text))
            {
                errorLabel.Text = "Пожалуйста, введите фамилию";
                errorLabel.IsVisible = true;
                return;
            }

            errorLabel.IsVisible = false;
            await Navigation.PushAsync(new SecondPage(usernameEntry.Text));
        }
    }
}
