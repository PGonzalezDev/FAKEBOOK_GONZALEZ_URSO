using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using FAKEDAO;
using FAKEDAO.Helpers;
using FAKEMODELS;

namespace FAKECONTROLLERS
{
    public class LoginController
    {
        UserDAO Dao = new UserDAO();

        public bool ValidateLogin(string userMail, string pass)
        {
            bool isValid = false;

            User user = getUser(userMail);

            if (user != null)
            {
                isValid = validatePassword(user, pass);
            }

            return isValid;
        }

        private User getUser(string userMail)
        {
            User user = Dao.GetUserByEmail(userMail);

            return user;
        }

        private bool validatePassword(User user, string pass)
        {
            bool isValid = false;
            string sourcePass = getPasswordByUser(user.Id);

            string passEncoded = EncodeHelper.Encode(pass);

            isValid = (string.Compare(sourcePass, passEncoded) == 0);

            return isValid;
        }

        private string getPasswordByUser(int userId)
        {
            string passFromDataBase = string.Empty;
            
            passFromDataBase = Dao.GetPassword(userId);

            return passFromDataBase;
        }
        /*
        private string encodePassword(string pass)
        {
            return EncodeHelper.Encode(pass);
        }*/
    }
}
