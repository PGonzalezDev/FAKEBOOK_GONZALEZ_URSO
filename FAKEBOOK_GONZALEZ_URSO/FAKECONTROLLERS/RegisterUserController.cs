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
        public User Add(RegisterUser regUser)
        {
            UserDAO dao = new UserDAO();
            return dao.Add(regUser);
        }
    }
}
