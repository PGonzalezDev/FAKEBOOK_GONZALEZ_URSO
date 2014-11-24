using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FAKEMODELS;
using System.Data.SqlClient;
using FAKEDAO.Helpers;

namespace FAKEDAO
{
    public class PublicationDAO
    {
        public void Post(ref Publication pub)
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
            sqlcmd.Parameters.AddWithValue("@UserId", pub.User.Id);
            sqlcmd.Parameters.AddWithValue("@Txt", pub.Text);
            sqlcmd.Parameters.AddWithValue("@Img", pub.Image);
            sqlcmd.Parameters.AddWithValue("@DateTime", pub.Date_Time);
            
            try
            {
                ConnectionHelper.ExecuteNonQuery(sqlcmd);
                pub.Id = id;
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
    }
}
