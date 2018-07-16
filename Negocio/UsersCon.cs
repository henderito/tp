using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsersCon
    {
        private DataAccess da = new DataAccess();

        public List<Users> listar()
        {
            da.setearConsulta(DBGral.UsuariosAllString());
            List<Users> lista = new List<Users>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new Users()
                    {
                        DNI = da.Lector.GetString(0),
                        Nombre = da.Lector.GetString(1),
                        Pw = da.Lector.GetString(2),
                        Acceso = da.Lector.GetInt32(3)
                    });
                }
                return lista;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public Users userByNombre(string n)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.UsuariosByUserString());
            da.agregarParametro("@nombre", n);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Users u = new Users()
                    {
                        DNI = da.Lector.GetString(0),
                        Nombre = da.Lector.GetString(1),
                        Pw = da.Lector.GetString(2),
                        Acceso = da.Lector.GetInt32(3)
                    };                
                return u;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public Users userByDNI(string d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.UsuariosByDNIString());
            da.agregarParametro("@dni", d);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Users u = new Users()
                {
                    DNI = da.Lector.GetString(0),
                    Nombre = da.Lector.GetString(1),
                    Pw = da.Lector.GetString(2),
                    Acceso = da.Lector.GetInt32(3)
                };
                return u;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public bool userExists(string n)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.CheckUsuariosString());
            da.agregarParametro("@nombre", n);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                return da.Lector.IsDBNull(0);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void insertUsuario(Users u)
            { da.limpiarParametros();
            da.setearConsulta(DBGral.UsuariosInsertString());
            da.agregarParametro("@dni", u.DNI);
            da.agregarParametro("@nombre", u.Nombre);
            da.agregarParametro("@pass", u.Pw);
            da.agregarParametro("@tipo", u.Acceso.ToString());
            try
            { da.executeNonQuery(); }

            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateUsuario(Users u,string nViejo)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.UsuariosUpdateString());
            da.agregarParametro("@dni", u.DNI);
            da.agregarParametro("@n1", u.Nombre);
            da.agregarParametro("@pass", u.Pw);
            da.agregarParametro("@tipo", u.Acceso.ToString());
            da.agregarParametro("@n2", nViejo);
            try
            { da.executeNonQuery(); }        
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
