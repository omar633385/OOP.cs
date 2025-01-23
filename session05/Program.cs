using session05.Question_1.classes;
using session05.Question_2.Interfaces;

namespace session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1


            //Rectangle rect = new Rectangle(10,10);
            //rect.DisplayShapeInfo();

            //Circle c = new Circle(10);
            //c.DisplayShapeInfo();
            #endregion

            #region Q2
            string UserName = "Omar";
            string Password = "P@ssW0rd";
            string role = "Student";
            IAuthenticationService authService = new BasicAuthenticationService(UserName,Password,role);
            if(authService.AuthenticateUser(UserName, Password))
            {
                Console.WriteLine("User is Authenticated Successfully");
                if (authService.AuthorizeUser(UserName, "Graduated"))
                    Console.WriteLine("You Have this Role");
                else
                    Console.WriteLine("UnAuthorized");
            }
            else
                Console.WriteLine("You Entered wrong credentials");
         
            #endregion
        }
    }
}
