using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FAKEDAO.Helpers
{
    public static class ConnectionHelper
    {
        static string ConnectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=FAKEBOOK_DB;server=NENE\\SQLEXPRESS";
        static public SqlConnection cn = new SqlConnection(ConnectionString);
        
        static public void Open()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch
            {
                throw new Exception("Error de Conexión");
            }
        }
        static public void Close()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch
            {
                throw new Exception("Error de Desconexión");
            }
        }

        static public object ExecuteScalar(SqlCommand cmd)
        {
            try
            {
                Open();
                cmd.Connection = cn;
                object aux = cmd.ExecuteScalar();
                Close();
                return aux;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener Escalar");
            }
        }

        static public DataTable GetData(SqlCommand cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd.Connection = cn;
                Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch
            {
                throw new Exception("Error Dato Cargado");
            }
        }

        static public SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = cn;
                Open();
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch
            {
                Close();
                throw new Exception("Error al Cargar los datos");
            }
        }

        static public void ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = cn;
                Open();
                cmd.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Ejecutar la sentencia de AMB");
            }
        }
    }
}
