using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MailCon
    {
        private DataAccess da = new DataAccess();

        public List<String> listarMailEmpleados()
        {
            da.setearConsulta(DBGral.MailsEmAllString());
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

        public void insertMailEmpleado(String DNIe, String m)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.MailsEmInsertString());
            da.agregarParametro("@dni", DNIe);
            da.agregarParametro("@mail", m);
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
            da.setearConsulta(DBGral.MailsEmByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                return da.Lector.GetString(1);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateMailEmpleado(String m, String DNIe)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.MailsEmUpdateString());
            da.agregarParametro("@mail", m);
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
            da.setearConsulta(DBGral.MailsEmDeleteString());
            da.agregarParametro("@dni", DNIe);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public List<String> listarMailClientes()
        {
            da.setearConsulta(DBGral.MailsClAllString());
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

        public void insertMailClientes(String DNIe, String m)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.MailsClInsertString());
            da.agregarParametro("@dni", DNIe);
            da.agregarParametro("@mail", m);
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
            da.setearConsulta(DBGral.MailsClByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                return da.Lector.GetString(1);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateMailClientes(String m, String DNIe)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.MailsClUpdateString());
            da.agregarParametro("@mail", m);
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
            da.setearConsulta(DBGral.MailsClDeleteString());
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
