using System;
using Xamarin.Forms;

namespace BowBuddy.Navigation {
    public sealed class NavigationDispatcher {
        public static NavigationDispatcher Instance { get; } = new NavigationDispatcher();

        private INavigation _navigation;
        
        private NavigationDispatcher() { }

        public INavigation Navigation => _navigation ?? throw new Exception("NavigationDispatcher Not Initialized");
        
        public void Initialise(INavigation navigation) {
            if (_navigation != null) {
                throw new Exception("NavigationDispatcher already initialized");
            }
            _navigation = navigation;
        }
    }
}