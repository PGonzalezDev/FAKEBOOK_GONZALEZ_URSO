using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using FAKEMODELS;
using FAKEDAO;

namespace FAKECONTROLLERS
{
    public class RegisterUserController
    {
        UserDAO userDAO = new UserDAO();

        public User Add(RegisterUser regUser)
        {
            try
            {
                return userDAO.Add(regUser);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public bool IsMailInUse(string mail)
        {
            try
            {
                return userDAO.IsEmailInUse(mail);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
