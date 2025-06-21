
using System;
using System.Diagnostics;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace zd5_1_ShengalsRoman
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {

            InitializeComponent();
            var resources = typeof(App).Assembly.GetManifestResourceNames();
            // Выводим список ресурсов в Output
            var resourceNames = typeof(App).GetTypeInfo().Assembly.GetManifestResourceNames();
            foreach (var res in resourceNames)
            {
                Debug.WriteLine("RES: " + res);
            }
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            string surname = surnameEntry.Text?.Trim();

            if (string.IsNullOrEmpty(surname))
            {
                await DisplayAlert("Ошибка", "Введите фамилию", "OK");
                return;
            }

            await Navigation.PushAsync(new MainPage(surname));
        }
    }
}
