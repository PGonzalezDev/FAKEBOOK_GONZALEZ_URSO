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
        
        static public void Conectar()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch
            {
                throw new Exception("Error Conexión");
            }
        }
        static public void Desconectar()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch
            {
                throw new Exception("Error Desconexión");
            }
        }

        static public object EjecutarEscalar(SqlCommand cmd)
        {
            Conectar();
            cmd.Connection = cn;
            object aux = cmd.ExecuteScalar();
            Desconectar();
            return aux;
        }

        static public DataTable CargarDatos(SqlCommand cmd)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd.Connection = cn;
                Conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch
            {
                throw new Exception("Error Dato Cargado");
            }
        }

        static public SqlDataReader EjecutarReader(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = cn;
                Conectar();
                SqlDataReader reader = null;
                
                try
                {
                    reader = cmd.ExecuteReader();
                }
                catch
                {
                    throw new Exception("Error al Cargar los datos");
                }

                return reader;
            }
            catch
            {
                throw new Exception("Error Dato Cargado");
            }
        }

        static public void EjecutarSql(SqlCommand cmd)
        {
            cmd.Connection = cn;
            Conectar();
            cmd.ExecuteNonQuery();
            Desconectar();
        }
    }
}
