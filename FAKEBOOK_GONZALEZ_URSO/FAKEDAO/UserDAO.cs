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
            int id = getLastId();
            id += 1;

            sqlcmd.Parameters.AddWithValue("@Id", id);
            sqlcmd.Parameters.AddWithValue("@Nombre", regUser.FirstName);
            sqlcmd.Parameters.AddWithValue("@Apellido", regUser.LastName);
            sqlcmd.Parameters.AddWithValue("@Email", regUser.Mail);
            sqlcmd.Parameters.AddWithValue("@Contraseña", EncodeHelper.Encode(regUser.Password));
            ConnectionHelper.EjecutarSql(sqlcmd);

            User user = GetUserById(id);

            return user;
        }

        private int getLastId()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT COUNT(*) FROM [dbo].[User]";
            int lastUser = (int)ConnectionHelper.EjecutarEscalar(command);

            return lastUser;
        }
        
        public string GetPassword(int id)
        {
            string pass = string.Empty;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT [Id], [Password] FROM [dbo].[User] WHERE [Id] = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader dr = ConnectionHelper.EjecutarReader(cmd);

            while (dr.Read())
            {
                int sourceId = int.Parse(dr["Id"].ToString());
                if (sourceId == id)
                {
                    pass = dr["Password"].ToString();
                    break;
                }
            }

            ConnectionHelper.Desconectar();

            return pass;
        }

        public User GetUserById(int id)
        {
            User user = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT [Id], [Password] FROM [dbo].[User] WHERE [Id] = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader dr = ConnectionHelper.EjecutarReader(cmd);

            while (dr.Read())
            {
                int sourceId = int.Parse(dr["Id"].ToString());
                if (sourceId == id)
                {
                    user = new User((int)dr["Id"], (string)dr["FirstName"], (string)dr["LastName"].ToString(), (string)dr["Email"]);
                    break;
                }
            }

            ConnectionHelper.Desconectar();

            return user;
        }

        public User GetUserByEmail(string email)
        {
            User user = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[User] WHERE [Email] = @Email";
            command.Parameters.AddWithValue("@Email", email);

            SqlDataReader dr = ConnectionHelper.EjecutarReader(command);

            while (dr.Read())
            {
                if (string.Compare(dr["Email"].ToString(), email) == 0)
                {
                    user = new User((int)dr["Id"], (string)dr["FirstName"], (string)dr["LastName"].ToString(), (string)dr["Email"]);
                    break;
                }
            }

            ConnectionHelper.Desconectar();

            return user;
        }
    }
}
