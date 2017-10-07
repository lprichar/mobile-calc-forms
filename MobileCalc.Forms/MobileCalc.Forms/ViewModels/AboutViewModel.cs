using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileCalc.Forms.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string _display;

        public string Display
        {
            get { return _display; }
            set
            {
                _display = value;
                OnPropertyChanged();
            }
        }

        public AboutViewModel()
        {
            Title = "Standard";

            Display = "0";
            OnNumberClickCommand = new Command<string>(OnNumberClick);
        }

        public ICommand OnNumberClickCommand { get; }

        private void OnNumberClick(string num)
        {
            Display = Display + num;
        }
    }
}
