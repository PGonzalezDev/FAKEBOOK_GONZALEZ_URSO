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
        static public SqlConnection Conn = new SqlConnection(ConnectionString);
        
        static public void Open()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
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
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch
            {
                throw new Exception("Error de Desconexión");
            }
        }

        static public object ExecuteScalar(SqlCommand cmd, SqlTransaction trans = null)
        {
            try
            {
                cmd.Connection = Conn;
                cmd.Transaction = trans;
                Open();
                object aux = cmd.ExecuteScalar();
                Close();
                return aux;
            }
            catch
            {
                throw new Exception("Error al obtener Escalar");
            }
        }

        static public DataTable GetData(SqlCommand cmd, SqlTransaction trans = null)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd.Connection = Conn;
                cmd.Transaction = trans;
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

        static public SqlDataReader ExecuteReader(SqlCommand cmd, SqlTransaction trans = null)
        {
            try
            {
                cmd.Connection = Conn;
                cmd.Transaction = trans;
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

        static public void ExecuteNonQuery(SqlCommand cmd, SqlTransaction trans = null)
        {
            try
            {
                cmd.Connection = Conn;
                cmd.Transaction = trans;
                Open();
                cmd.ExecuteNonQuery();
                Close();
            }
            catch
            {
                throw new Exception("Error al Ejecutar la sentencia de AMB");
            }
        }
    }
}
