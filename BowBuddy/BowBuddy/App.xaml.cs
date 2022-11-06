using BowBuddy.Navigation;
using BowBuddy.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace BowBuddy {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new MainPage();
            NavigationDispatcher.Instance.Initialise(MainPage.Navigation);
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}