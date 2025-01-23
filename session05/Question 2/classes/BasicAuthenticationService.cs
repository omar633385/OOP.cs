using session05.Question_2.Interfaces;

namespace session05
{
    internal class BasicAuthenticationService : IAuthenticationService
    {


        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public BasicAuthenticationService(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public BasicAuthenticationService(string userName, string password, string roleName)
        {
            UserName = userName;
            Password = password;
            RoleName = roleName;
        }
        public BasicAuthenticationService()
        {
            
        }
        public bool AuthenticateUser(string username, string password)
        {
            if ((string.IsNullOrEmpty(username)) || (string.IsNullOrEmpty(password)))
            {
                return false;
            }
            if (username == UserName && password == Password)
                return true;
            return false;

        }

        public bool AuthorizeUser(string username, string role)
        {
            if ((string.IsNullOrEmpty(username)) || (string.IsNullOrEmpty(role)))
            {
                return false;
            }
            if (username == UserName && role == RoleName)
                return true;
            return false;
        }
    }
}