using HeadWorksTask.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(IAuthorizationService))]
namespace HeadWorksTask.ViewModels
{
    class Authorization : IAuthorizationService
    {
        public bool CheckLoginPassword(string Login, string Password)
        {
            if (Login.Length > 3 && Password.Length > 3)
                return true;
            else
                return false;
        }
    }
}
