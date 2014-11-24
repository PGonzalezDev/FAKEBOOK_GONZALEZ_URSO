using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAKECONTROLLERS;

namespace FAKEBOOK_GONZALEZ_URSO
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(LoginTxt.Text)
                && !string.IsNullOrEmpty(PassTxt.Text))
            {
                LoginController controller = new LoginController();
                bool isLogged = controller.ValidateLogin(LoginTxt.Text, PassTxt.Text);

                if (isLogged)
                {
                    Response.Redirect("index.aspx");
                }
                else
                {
                    PassTxt.Text = string.Empty;
                }
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }

    }
}