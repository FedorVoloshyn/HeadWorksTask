using HeadWorksTask.Interfaces;

namespace HeadWorksTask.ViewModels
{
    class LoginPageViewModel : BaseViewModel
    {
        private IAuthorizationService _authorization;
        private string login;
        private string password;

        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public LoginPageViewModel()
        {
            this._authorization = new Authorization();
        }

        public bool Authorize()
        {
            return _authorization.CheckLoginPassword(login, password);
        }
    }
}
