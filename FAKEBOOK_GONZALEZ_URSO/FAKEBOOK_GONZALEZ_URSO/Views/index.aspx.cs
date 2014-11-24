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
    public partial class index : System.Web.UI.Page
    {
        PublicationController controller = new PublicationController();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Post_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PublicationTxt.Text.Trim()))
            {
                User user = (User)Session["User"];
                Publication pub = new Publication(user, PublicationTxt.Text, DateTime.Now);
                try
                {
                    controller.Post(ref pub);
                    //En realidad este mensaje no iria, se mostraria directamente la publicacion
                    ErrorLabel.ForeColor = System.Drawing.Color.Green;
                    ErrorLabel.Text = "La publicación se realizo correctamente";
                }
                catch (Exception ex)
                {
                    ErrorLabel.ForeColor = System.Drawing.Color.Red;
                    ErrorLabel.Text = ex.Message;
                }
                
            }
            
        }
    }
}