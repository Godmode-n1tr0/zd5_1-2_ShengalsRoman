
using Xamarin.Forms;

namespace zd5_1_ShengalsRoman
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new WelcomePage());
        }
    }
}
