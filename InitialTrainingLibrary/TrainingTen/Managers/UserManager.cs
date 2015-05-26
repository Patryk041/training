using TrainingTen.Logic.Login;
using TrainingTen.Wrappers;

namespace TrainingTen.Managers
{
    public class UserManager
    {
        LoginLogic logic = new LoginLogic();

        SessionWrapper session = new SessionWrapper(); 

        public bool LogInUser(string user, string password)
        {
            var result = logic.Login(user, password);

            if (!result) return false;
            session.SetElement(SessionWrapper.LoginName,user);
            return true;
        }

        public string GetLoggedUserName()
        {
            if (IsLogged()) return session.GetElement(SessionWrapper.LoginName) as string;
            return string.Empty;
        }

        public bool IsLogged()
        {
            return session.KeyExist(SessionWrapper.LoginName);
        }
    }
}