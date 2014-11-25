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

                    try
                    {
                        if (!controller.IsMailInUse(regUser.Mail))
                        {
                            User user = controller.Add(regUser);

                            if (user != null)
                            {
                                FirstName.Text = string.Empty;
                                LastName.Text = string.Empty;
                                Email.Text = string.Empty;
                                ConfirmMail.Text = string.Empty;
                                Password.Text = string.Empty;
                                ConfirmPassword.Text = string.Empty;
                                MsjLabel.ForeColor = System.Drawing.Color.Green;
                                MsjLabel.Text = "Usuario Registrado correctamente";
                            }
                        }
                        else
                        {
                            MsjLabel.ForeColor = System.Drawing.Color.Red;
                            MsjLabel.Text = "El mail ya esta en uso";
                        }
                    }
                    catch (Exception ex)
                    {
                        MsjLabel.ForeColor = System.Drawing.Color.Red;
                        MsjLabel.Text = ex.Message;
                    }
                }
                
                //si no es valido deberian mostrarse las validaciones del lado del cliente con los validators
            }           
        }
    }
}