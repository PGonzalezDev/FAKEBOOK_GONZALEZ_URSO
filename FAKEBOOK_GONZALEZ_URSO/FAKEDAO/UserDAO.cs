using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FAKEDAO.Helpers;
using FAKEMODELS;

namespace FAKEDAO
{
    public class UserDAO
    {
        public User Add(RegisterUser regUser)
        {
            string cmd = "INSERT INTO [dbo].[User]([Id],[FirstName],[LastName],[Email],[Password]) values (@Id, @Nombre,@Apellido,@Email,@Contraseña)";
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
            sqlcmd.Parameters.AddWithValue("@Nombre", regUser.FirstName);
            sqlcmd.Parameters.AddWithValue("@Apellido", regUser.LastName);
            sqlcmd.Parameters.AddWithValue("@Email", regUser.Mail);
            sqlcmd.Parameters.AddWithValue("@Contraseña", EncodeHelper.Encode(regUser.Password));
            User user = null;

            try
            {
                ConnectionHelper.ExecuteNonQuery(sqlcmd);
                user = GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        private int getNewId()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT COUNT(*) FROM [dbo].[User]";
            int lastUser = (int)ConnectionHelper.ExecuteScalar(command);

            return lastUser + 1;
        }
        
        public string GetPassword(int id)
        {
            string pass = string.Empty;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT [Id], [Password] FROM [dbo].[User] WHERE [Id] = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader dr = ConnectionHelper.ExecuteReader(cmd);

            while (dr.Read())
            {
                int sourceId = int.Parse(dr["Id"].ToString());
                if (sourceId == id)
                {
                    pass = dr["Password"].ToString();
                    break;
                }
            }

            ConnectionHelper.Close();

            return pass;
        }

        public User GetById(int id)
        {
            User user = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT [Id], [Password] FROM [dbo].[User] WHERE [Id] = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                SqlDataReader dr = ConnectionHelper.ExecuteReader(cmd);

                while (dr.Read())
                {
                    int sourceId = int.Parse(dr["Id"].ToString());
                    if (sourceId == id)
                    {
                        user = new User((int)dr["Id"], (string)dr["FirstName"], (string)dr["LastName"].ToString(), (string)dr["Email"]);
                        break;
                    }
                }

                ConnectionHelper.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        public User GetByEmail(string email)
        {
            User user = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT [Id], [FirstName], [LastName], [Email] FROM [dbo].[User] WHERE [Email] = @Email";
            command.Parameters.AddWithValue("@Email", email);

            try
            {
                SqlDataReader dr = ConnectionHelper.ExecuteReader(command);

                while (dr.Read())
                {
                    if (string.Compare(dr["Email"].ToString(), email) == 0)
                    {
                        user = new User((int)dr["Id"], (string)dr["FirstName"], (string)dr["LastName"].ToString(), (string)dr["Email"]);
                        break;
                    }
                }

                ConnectionHelper.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        public bool IsEmailInUse(string email)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT 1 FROM [dbo].[User] WHERE [Email] = @Email";
            cmd.Parameters.AddWithValue("@Email", email);
            
            try
            {
                object value = ConnectionHelper.ExecuteScalar(cmd);
                bool exist = (value != null) ? ((int)value == 1) : false;

                return exist;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
