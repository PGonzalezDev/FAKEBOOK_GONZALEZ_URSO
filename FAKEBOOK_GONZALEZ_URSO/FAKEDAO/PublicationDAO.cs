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
        public void Add(ref Publication post)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO [dbo].[Publication]([UserId],[Txt],[Img],[Date_Time]) VALUES(@UserId,@Txt,@Img,@DateTime);";
            int id = 0;

            cmd.Parameters.AddWithValue("@UserId", post.User.Id);
            cmd.Parameters.AddWithValue("@Txt", post.Text);
            cmd.Parameters.AddWithValue("@Img", post.Image);
            cmd.Parameters.AddWithValue("@DateTime", post.Date_Time);

            cmd.CommandText += "SELECT SCOPE_IDENTITY();";

            try
            {
                id = Convert.ToInt32((decimal)ConnectionHelper.ExecuteScalar(cmd));
                
                post.Id = id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConnectionHelper.Close();
            }
        }

        public void Remove(int postId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM [dbo].[Publication] WHERE [Id] = @Id";
            cmd.Parameters.AddWithValue("@Id", postId);

            try
            {
                ConnectionHelper.ExecuteNonQuery(cmd);
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
