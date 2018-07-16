using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace Negocio
{
    public class AdministradorCon
        {private DataAccess da = new DataAccess();

         public List<Administrador> listar()
            {da.setearConsulta(DBGral.AdministradorAllString());           
             List<Administrador> lista = new List<Administrador>();
             try
                {da.leerConsulta();
                while (da.Lector.Read())
                { lista.Add(new Administrador()
                    {Nombre = da.Lector.GetString(0),
                     Apellido = da.Lector.GetString(1),
                     FechaNac = da.Lector.GetDateTime(2),
                     DNI = da.Lector.GetString(3),
                     Telefono = da.Lector.GetString(4),
                     Mail = da.Lector.GetString(5),
                     Dom = new Domicilio()
                        {Calle = da.Lector.GetString(6),
                         Altura = da.Lector.GetString(7),
                         Piso = da.Lector.IsDBNull(8) ? "0" : da.Lector.GetString(8),
                         Departamento = da.Lector.IsDBNull(9) ? null : da.Lector.GetString(9) },
                     FechaIngreso = da.Lector.GetDateTime(10),
                     Sueldo = da.Lector.GetInt32(11)
                });
                }
                 return lista;}
            catch (Exception ex)
                {throw ex;}
            finally
                { da.cerrarConexion(); }}

        public void insertAdministrador(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.AdministradorInsertString());
            da.agregarParametro("@dni",DNI);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public Administrador getAdministradorById(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.AdministradorByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Administrador a = new Administrador()
                {
                    Nombre = da.Lector.GetString(0),
                    Apellido = da.Lector.GetString(1),
                    FechaNac = da.Lector.GetDateTime(2),
                    DNI = da.Lector.GetString(3),
                    Telefono = da.Lector.GetString(4),
                    Mail = da.Lector.GetString(5),
                    Dom = new Domicilio()
                    {
                        Calle = da.Lector.GetString(6),
                        Altura = da.Lector.GetString(7),
                        Piso = da.Lector.IsDBNull(8) ? "0" : da.Lector.GetString(8),
                        Departamento = da.Lector.IsDBNull(9) ? null : da.Lector.GetString(9)
                    },
                    FechaIngreso = da.Lector.GetDateTime(10),
                    Sueldo = da.Lector.GetInt32(11)
                };
                return a;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteAdministrador(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.AdministradorDeleteString());
            da.agregarParametro("@dni", DNI);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
