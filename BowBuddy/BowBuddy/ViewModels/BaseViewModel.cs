using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BowBuddy.ViewModels {
    public abstract class BaseViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual Task Initialise() {
            return Task.CompletedTask;
        }
    }
}