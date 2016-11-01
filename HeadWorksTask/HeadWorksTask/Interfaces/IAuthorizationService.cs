namespace HeadWorksTask.Interfaces
{
    interface IAuthorizationService
    {
        bool CheckLoginPassword(string Login, string Password);
    }
}
