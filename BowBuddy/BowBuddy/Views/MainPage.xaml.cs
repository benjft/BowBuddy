using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowBuddy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BowBuddy.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = Startup.ServiceProvider.GetService<MainViewModel>();
            SubscribeToEvents();
        }

        private void SubscribeToEvents() {
            
        }

        private async void MainPageAppearing(object sender, EventArgs args) {
            if (BindingContext is MainViewModel vm) {
                await vm.Initialise();
            }
        }
    }
}