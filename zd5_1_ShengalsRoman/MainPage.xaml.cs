
using Xamarin.Forms;

namespace zd5_1_ShengalsRoman
{
    public partial class MainPage : TabbedPage
    {
        public MainPage(string surname)
        {
            InitializeComponent();

            var creditPage = new CreditPage();
            var exchangePage = new ExchangePage();

            Children.Add(creditPage);
            Children.Add(exchangePage);

            Title = $"Добро пожаловать, {surname}!";
        }
    }
}
