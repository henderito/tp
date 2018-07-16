using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TelefonoCon
    {
        private DataAccess da = new DataAccess();

        public List<String> listarTelEmpleados()
        {
            da.setearConsulta(DBGral.TelefonosEmAllString());
            List<String> lista = new List<String>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(da.Lector.GetString(0));
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertTelefonoEmpleado(String DNIe, String t, String d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosEmInsertString());
            da.agregarParametro("@dni", DNIe);
            da.agregarParametro("@telefono", t);
            da.agregarParametro("@descripcion", d);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public String getTelefonoEmpleadoById(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosEmByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                return da.Lector.GetInt32(1).ToString();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateTelefonoEmpleado(String t, String DNIe, String d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosEmUpdateString());
            da.agregarParametro("@telefono", t);
            da.agregarParametro("@descripcion", d);
            da.agregarParametro("@dni", DNIe);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteTelefonoEmpleado(String DNIe)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosEmDeleteString());
            da.agregarParametro("@dni", DNIe);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public List<String> listarTelClientes()
        {
            da.setearConsulta(DBGral.TelefonosClAllString());
            List<String> lista = new List<String>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(da.Lector.GetString(0));
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertTelefonoClientes(String DNIe, String t, String d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosClInsertString());
            da.agregarParametro("@dni", DNIe);
            da.agregarParametro("@telefono", t);
            da.agregarParametro("@descripcion", d);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public String getTelefonoClientesById(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosClByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                return da.Lector.GetInt32(1).ToString();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateTelefonoClientes(String t, String DNIe, String d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosClUpdateString());
            da.agregarParametro("@telefono", t);
            da.agregarParametro("@descripcion", d);
            da.agregarParametro("@dni", DNIe);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteTelefonoClientes(String DNIe)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TelefonosClDeleteString());
            da.agregarParametro("@dni", DNIe);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
