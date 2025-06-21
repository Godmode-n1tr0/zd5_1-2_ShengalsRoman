using System;
using System.Xml;
using Xamarin.Forms;

namespace zd5_2_ShengalsRoman
{
    public partial class SecondPage : ContentPage
    {
        private string _username;

        public SecondPage(string username)
        {
            InitializeComponent();
            _username = username;
            nameLabel.Text = $"Здравствуйте, {_username}!";
        }

        private async void OnNextClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage(_username));
        }
    }
}
