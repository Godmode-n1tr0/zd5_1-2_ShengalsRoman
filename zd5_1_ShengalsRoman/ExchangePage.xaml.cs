
using System;
using Xamarin.Forms;

namespace zd5_1_ShengalsRoman
{
    public partial class ExchangePage : ContentPage
    {
        public ExchangePage()
        {
            Title = "Курсы валют";
            var dateLabel = new Label
            {
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = DateTime.Now.ToString("dd/MM/yyyy")
            };

            Content = new StackLayout
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Центробанк РФ:", FontAttributes = FontAttributes.None },
                    new Label { Text = "Текущая дата:", FontAttributes = FontAttributes.Bold },
                    dateLabel,
                    new Label { Text = "USD    80.000", FontAttributes = FontAttributes.Bold },
                    new Label { Text = "EUR    86.000", FontAttributes = FontAttributes.Bold }
                }
            };
        }
    }
}
