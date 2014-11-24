using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAKECONTROLLERS;
using FAKEMODELS;
using System.Web.Security;

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
                bool isLogged = false;
                User user = controller.ValidateLogin(LoginTxt.Text, PassTxt.Text, ref isLogged);

                if (isLogged)
                {
                    FormsAuthentication.SetAuthCookie(LoginTxt.Text, false);
                    Session["User"] = user;
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