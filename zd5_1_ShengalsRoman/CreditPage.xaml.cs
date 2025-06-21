
using System;
using Xamarin.Forms;

namespace zd5_1_ShengalsRoman
{
    public partial class CreditPage : ContentPage
    {
        Entry amountEntry, termEntry;
        Picker paymentPicker;
        Slider percentSlider;
        Label percentLabel, monthlyPaymentLabel, totalLabel, overpayLabel;

        public CreditPage()
        {
            Title = "Кредитный калькулятор";
            amountEntry = new Entry { Placeholder = "Введите сумму кредита", Keyboard = Keyboard.Numeric };
            termEntry = new Entry { Placeholder = "Введите срок (мес)", Keyboard = Keyboard.Numeric };
            paymentPicker = new Picker { Title = "Вид платежа" };
            paymentPicker.Items.Add("Аннуитетный");
            paymentPicker.Items.Add("Дифференцированный");

            percentSlider = new Slider { Minimum = 0, Maximum = 30, Value = 5 };
            percentLabel = new Label { Text = "5%", HorizontalTextAlignment = TextAlignment.Center };
            percentSlider.ValueChanged += (s, e) => {
                percentLabel.Text = string.Format("{0:F0}%", e.NewValue);
            };

            monthlyPaymentLabel = new Label { Text = "Ежемесячный платёж: ...." };
            totalLabel = new Label { Text = "Общая сумма: ...." };
            overpayLabel = new Label { Text = "Переплата: ...." };

            Button calcButton = new Button { Text = "Рассчитать" };
            calcButton.Clicked += OnCalculateClicked;

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Padding = 20,
                    Children =
                    {
                        new Label { Text = "Сумма кредита:" }, amountEntry,
                        new Label { Text = "Срок (месяцев):" }, termEntry,
                        new Label { Text = "Вид платежа:" }, paymentPicker,
                        new Label { Text = "Процентная ставка:" }, percentSlider, percentLabel,
                        calcButton,
                        monthlyPaymentLabel, totalLabel, overpayLabel
                    }
                }
            };
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (double.TryParse(amountEntry.Text, out double amount) &&
                int.TryParse(termEntry.Text, out int months) &&
                paymentPicker.SelectedIndex != -1)
            {
                double rate = percentSlider.Value / 100;
                string paymentType = paymentPicker.Items[paymentPicker.SelectedIndex];

                if (paymentType == "Аннуитетный")
                {
                    double monthlyRate = rate / 12;
                    double payment = (amount * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -months));
                    double total = payment * months;
                    double overpay = total - amount;

                    monthlyPaymentLabel.Text = $"Ежемесячный платёж: {payment:F2} ₽";
                    totalLabel.Text = $"Общая сумма: {total:F2} ₽";
                    overpayLabel.Text = $"Переплата: {overpay:F2} ₽";
                }
                else
                {
                    monthlyPaymentLabel.Text = "Ежемесячный платёж: — (только для аннуитетного)";
                    totalLabel.Text = "—";
                    overpayLabel.Text = "—";
                }
            }
        }
    }
}
