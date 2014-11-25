using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAKECONTROLLERS;
using FAKEMODELS;
using FAKEMODELS.Wrappers;

namespace FAKEBOOK_GONZALEZ_URSO
{
    public partial class index : System.Web.UI.Page
    {
        PublicationController controller = new PublicationController();
        User user = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (User)Session["User"];

            List<PublicationWrapper> posts = controller.GetAllByUser(user);
            
            if (posts.Any())
            {
                GridView1.DataSource = posts;
                GridView1.DataBind();
            }
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PublicationTxt.Text.Trim()))
            {
                
                Publication post = new Publication(user.Id, PublicationTxt.Text, DateTime.Now);
                try
                {
                    controller.Post(ref post);
                    //En realidad este mensaje no iria, se mostraria directamente la publicacion
                    ErrorLabel.ForeColor = System.Drawing.Color.Green;
                    ErrorLabel.Text = "La publicación se realizo correctamente.";

                    //Publications.InnerHtml += "";
                }
                catch (Exception ex)
                {
                    ErrorLabel.ForeColor = System.Drawing.Color.Red;
                    ErrorLabel.Text = ex.Message;
                }
            }
            else
            {
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Text = "Debe completar el campo para poder Publicar.";
            }
        }
    }
}