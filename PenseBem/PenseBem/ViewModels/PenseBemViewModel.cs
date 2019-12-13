using System;
using Xamarin.Forms;

namespace PenseBem.ViewModels
{
    public class PenseBemViewModel : BaseViewModel
    {
        private string _asterisco = "#4A382E";
        public string Asterisco
        {
            get => _asterisco;
            set => SetProperty(ref _asterisco, value);
        }

        private Command _botaoLigarCommand;
        public Command BotaoLigarCommand =>
            _botaoLigarCommand ?? (_botaoLigarCommand = new Command(() => ExecuteBotaoLigarCommand()));

        private Command _botaoDesligarCommand;
        public Command BotaoDesligarCommand =>
            _botaoDesligarCommand ?? (_botaoDesligarCommand = new Command(() => ExecuteBotaoDesligarCommand()));

        private void ExecuteBotaoDesligarCommand()
        {
            _asterisco = "#4A382E";
            OnPropertyChanged(nameof(Asterisco));
        }

        private void ExecuteBotaoLigarCommand()
        {
            _asterisco = "Red";
            OnPropertyChanged(nameof(Asterisco));
        }
    }
}
