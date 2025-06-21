using System;
using Xamarin.Forms;

namespace zd5_2_ShengalsRoman
{
    public partial class ThirdPage : ContentPage
    {
        private string _username;

        public ThirdPage(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void OnShowInfoClicked(object sender, EventArgs e)
        {
            string selected = infoPicker.SelectedItem?.ToString() ?? "не выбрано";
            double max = valueSlider.Maximum;

            resultLabel.Text = $"Выбранный пункт: {selected}\nМаксимум слайдера: {max}";
        }
    }
}
