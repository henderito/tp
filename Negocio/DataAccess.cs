using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Negocio
{
    public class DataAccess
        {private SqlConnection conexion;
         private SqlCommand comando;
         private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public DataAccess()
            {conexion = new SqlConnection(DBGral.DataBaseConectString());
             comando = new SqlCommand();
             comando.Connection = conexion;}

        public void setearConsulta(string c)
            {comando.CommandType = System.Data.CommandType.Text;
             comando.CommandText = c;}

        public void leerConsulta()
            {try
                {conexion.Open();
                 lector = comando.ExecuteReader();}
             catch (Exception ex)
                {throw ex;}}

        public void cerrarConexion() {conexion.Close();}

        public void executeNonQuery()
            {try
                {conexion.Open();
                 comando.ExecuteNonQuery();}
            catch (Exception ex) {throw ex;}
        }

        public void agregarDateTimeParam(string nombre, DateTime t)
            { SqlParameter p = comando.Parameters.Add(nombre, System.Data.SqlDbType.DateTime);
            p.Value = t;
        }

        public int executeScalar()
            { try
            {
                conexion.Open();
                int id = (int)comando.ExecuteScalar();
                return id;
            }
            catch (Exception e)
            { throw e; } }

        public void limpiarParametros() {comando.Parameters.Clear();}

        public void agregarParametro(string nombre, string valor) {comando.Parameters.AddWithValue(nombre, valor);}

        public void agregarNullInt(string nombre) { comando.Parameters.AddWithValue(nombre, SqlInt32.Null); }

        public void setearSP(string sp)
            {comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;}

    }
}
