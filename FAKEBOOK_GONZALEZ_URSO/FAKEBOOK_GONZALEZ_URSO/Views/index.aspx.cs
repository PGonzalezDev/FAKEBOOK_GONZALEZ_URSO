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

            GridView1.DataSource = posts;
            GridView1.DataBind();
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PublicationTxt.Text.Trim()))
            {

                Publication post = new Publication(user, PublicationTxt.Text, DateTime.Now);
                try
                {
                    controller.Add(ref post);
                    //lo dejo por las dudas pero se muestra directamente la publicacion
                    //ErrorLabel.ForeColor = System.Drawing.Color.Green;
                    //ErrorLabel.Text = "La publicación se realizo correctamente.";
                    
                    PublicationTxt.Text = string.Empty;
                    List<PublicationWrapper> posts = (List<PublicationWrapper>)GridView1.DataSource;
                    posts.Add(new PublicationWrapper(post));
                    GridView1.DataBind();
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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int postId = (int)GridView1.DataKeys[e.RowIndex].Value;
            try
            {
                controller.Remove(postId);
            }
            catch
            {
                ErrorLabel.ForeColor = System.Drawing.Color.Red;
                ErrorLabel.Text = "Error al borrar la publicación.";
            }

            List<PublicationWrapper> posts = (List<PublicationWrapper>)GridView1.DataSource;
            posts.RemoveAt(e.RowIndex);
            GridView1.DataBind();
        }
    }
}