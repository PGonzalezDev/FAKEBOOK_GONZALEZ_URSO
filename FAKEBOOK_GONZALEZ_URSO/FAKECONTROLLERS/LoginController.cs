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
        UserDAO userDAO = new UserDAO();

        public User ValidateLogin(string userMail, string pass, ref bool isValid)
        {
            try
            {
                isValid = false;
                User user = getUser(userMail);

                if (user != null)
                {
                    isValid = validatePassword(user, pass);
                }

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private User getUser(string userMail)
        {
            try
            {
                return userDAO.GetByEmail(userMail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool validatePassword(User user, string pass)
        {
            try
            {
                string sourcePass = getPasswordByUser(user.Id);
                return (string.Compare(sourcePass, EncodeHelper.Encode(pass)) == 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string getPasswordByUser(int userId)
        {
            try
            {
                return userDAO.GetPassword(userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
