using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAKECONTROLLERS;
using FAKEMODELS;

namespace FAKEBOOK_GONZALEZ_URSO
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstName.Text)
                && !string.IsNullOrEmpty(LastName.Text)
                && !string.IsNullOrEmpty(Email.Text)
                && !string.IsNullOrEmpty(ConfirmMail.Text)
                && !string.IsNullOrEmpty(Password.Text)
                && !string.IsNullOrEmpty(ConfirmPassword.Text))
            {
                RegisterUser regUser = new RegisterUser(FirstName.Text, LastName.Text, Email.Text, ConfirmMail.Text, Password.Text, ConfirmPassword.Text);

                if (regUser.IsValid())
                {
                    RegisterUserController controller = new RegisterUserController();
                    User user = controller.Add(regUser);

                    if (user != null)
                    {
                        //devolver mensaje usuario registrado correctamente
                    }
                }
                
                //si no es valido deberian mostrarse las validaciones del lado del cliente con los validators
            }           
        }
    }
}