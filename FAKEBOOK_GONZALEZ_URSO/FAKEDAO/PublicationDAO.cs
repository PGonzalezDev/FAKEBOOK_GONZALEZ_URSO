using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FAKEDAO.Helpers;
using FAKEMODELS;
using FAKEMODELS.Wrappers;

namespace FAKEDAO
{
    public class PublicationDAO
    {
        public void Post(ref Publication post)
        {
            string cmd = "INSERT INTO [dbo].[Publication]([Id],[UserId],[Txt],[Img],[Date_Time]) VALUES(@Id,@UserId,@Txt,@Img,@DateTime)";
            SqlCommand sqlcmd = new SqlCommand(cmd);
            int id = 0;
            
            try
            {
                id = getNewId();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            sqlcmd.Parameters.AddWithValue("@Id", id);
            sqlcmd.Parameters.AddWithValue("@UserId", post.User.Id);
            sqlcmd.Parameters.AddWithValue("@Txt", post.Text);
            sqlcmd.Parameters.AddWithValue("@Img", post.Image);
            sqlcmd.Parameters.AddWithValue("@DateTime", post.Date_Time);
            
            try
            {
                ConnectionHelper.ExecuteNonQuery(sqlcmd);
                post.Id = id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int getNewId()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT COUNT(*) FROM [dbo].[Publication]";
            
            try
            {
                int lastPublication = (int)ConnectionHelper.ExecuteScalar(command);
                return lastPublication + 1;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<PublicationWrapper> GetAllByUser(User user)
        {
            List<PublicationWrapper> posts = new List<PublicationWrapper>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT [Id], [UserId], [Txt], [Img], [Date_Time] FROM [dbo].[Publication] WHERE [UserId] = @UserId";
            cmd.Parameters.AddWithValue("@UserId", user.Id);

            try
            {
                SqlDataReader dr = ConnectionHelper.ExecuteReader(cmd);

                while (dr.Read())
                {
                    Publication post = new Publication(user, (string)dr["Txt"], (DateTime)dr["Date_Time"], (int)dr["Id"], (string)dr["Img"]);
                    posts.Add(new PublicationWrapper(post));
                }

                ConnectionHelper.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return posts;
        }
    }
}
