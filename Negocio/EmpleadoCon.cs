using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class EmpleadoCon
        {private DataAccess da = new DataAccess();

        public List<Empleado> listar()
            {da.setearConsulta(DBGral.EmpleadosAllString());

            List<Empleado> lista = new List<Empleado>();
            try
                {da.leerConsulta();
                while (da.Lector.Read())
                    { lista.Add(new Empleado()
                      { DNI = da.Lector.GetString(0),
                        Nombre = da.Lector.GetString(1),
                        Apellido = da.Lector.GetString(2),
                        FechaNac = da.Lector.GetDateTime(3),
                        Telefono = new TelefonoCon().getTelefonoEmpleadoById(da.Lector.GetString(0)),
                        Mail = new MailCon().getTelefonoEmpleadoById(da.Lector.GetString(0)),
                        Dom = new DomicilioCon().getDomicilioEmpleadoById(da.Lector.GetString(0)),
                        FechaIngreso = da.Lector.GetDateTime(10),
                        Sueldo = da.Lector.GetInt32(11),
                        Sexo = da.Lector.GetString(12)                       
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertEmpleado(Empleado e)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EmpleadosInsertString());
            da.agregarParametro("@dni", e.DNI);
            da.agregarParametro("@nombre", e.Nombre);
            da.agregarParametro("@apellido", e.Apellido);
            da.agregarDateTimeParam("@fechanac", e.FechaNac);
            da.agregarParametro("@sexo", e.Sexo);
            da.agregarParametro("@sueldo", e.Sueldo.ToString());
            da.agregarParametro("@equipo", e.Equipo.ToString());
            da.agregarDateTimeParam("@fechaingreso", e.FechaIngreso);
            try
            { da.executeNonQuery(); }
            catch (Exception ex)
            { MessageBox.Show("Ya existe un empleado con ese DNI registrado"); }
            finally
            { da.cerrarConexion(); }
        }

        public Empleado getEmpleadoById(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EmpleadosByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Empleado e = new Empleado()
                {
                    DNI = da.Lector.GetString(0),
                    Nombre = da.Lector.GetString(1),
                    Apellido = da.Lector.GetString(2),
                    FechaNac = da.Lector.GetDateTime(3),
                    Telefono = new TelefonoCon().getTelefonoEmpleadoById(da.Lector.GetString(0)),
                    Mail = new MailCon().getTelefonoEmpleadoById(da.Lector.GetString(0)),
                    Dom = new DomicilioCon().getDomicilioEmpleadoById(da.Lector.GetString(0)),
                    FechaIngreso = da.Lector.GetDateTime(4),
                    Sueldo = da.Lector.GetInt32(6),
                    Sexo = da.Lector.GetString(5)
                };
                return e;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateEmpleado(Empleado e)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EmpleadosUpdateString());
            da.agregarParametro("@nombre", e.Nombre);
            da.agregarParametro("@apellido", e.Apellido);
            da.agregarDateTimeParam("@fechanac", e.FechaNac);
            da.agregarDateTimeParam("@fechaing", e.FechaIngreso);
            da.agregarParametro("@sexo", e.Sexo);
            da.agregarParametro("@sueldo", e.Sueldo.ToString());
            da.agregarParametro("@equipo", e.Equipo.ToString());
            da.agregarParametro("@dni", e.DNI);
            da.agregarDateTimeParam("@fechaingreso", e.FechaIngreso);
            try
            { da.executeNonQuery(); }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteEmpleado(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EmpleadosDeleteString());
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
