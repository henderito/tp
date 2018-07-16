using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using Negocio;
using System.Windows.Forms;

namespace Negocio
{
    public class ClienteCon
        {private DataAccess da = new DataAccess();

        public List<Cliente> listar()
            {da.setearConsulta(DBGral.ClientesAllString());
            List<Cliente> lista = new List<Cliente>();
            try
                {da.leerConsulta();
                while (da.Lector.Read())
                    { lista.Add(new Cliente()
                    { Nombre = da.Lector.GetString(0),
                        Apellido = da.Lector.GetString(1),
                        FechaNac = da.Lector.GetDateTime(2),
                        DNI = da.Lector.GetString(3),
                        Telefono = da.Lector.GetInt32(4).ToString(),
                        Mail = da.Lector.GetString(5),
                        Dom = new Domicilio()
                        { Calle = da.Lector.GetString(6),
                            Altura = da.Lector.GetInt32(7).ToString(),
                            Piso = da.Lector.IsDBNull(8) ? "0" : da.Lector.GetInt32(8).ToString(),
                            Departamento = da.Lector.IsDBNull(9) ? null : da.Lector.GetString(9) },
                         Sexo = da.Lector.GetString(10)
                    });}
                return lista;}
            catch (Exception ex)
                { throw ex; }
            finally
                {da.cerrarConexion();}}

        public void insertCliente(Cliente c)
            {da.limpiarParametros();
            da.setearConsulta(DBGral.ClientesInsertString());
            da.agregarParametro("@dni", c.DNI);
            da.agregarParametro("@nombre", c.Nombre);
            da.agregarParametro("@apellido", c.Apellido);
            da.agregarParametro("@sexo", c.Sexo);
            da.agregarDateTimeParam("@fechanac", c.FechaNac);
            try
                { da.executeNonQuery(); }
            catch (Exception e)
                { MessageBox.Show("Ya existe un usuario registrado con ese DNI");
                //throw e; 
            }
            finally
                { da.cerrarConexion(); }
        }

        public Cliente getClienteById(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.ClientesByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Cliente c = new Cliente()
                {
                    Nombre = da.Lector.GetString(1),
                    Apellido = da.Lector.GetString(2),
                    FechaNac = da.Lector.GetDateTime(4),
                    DNI = da.Lector.GetString(0),
                    Telefono = new TelefonoCon().getTelefonoClientesById(DNI),
                    Mail = new MailCon().getTelefonoClientesById(DNI),
                    Dom = new DomicilioCon().getDomicilioClienteById(DNI),
                    Sexo = da.Lector.GetString(3)
                };
                return c;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateCliente(Cliente c)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.ClientesUpdateString());
            da.agregarParametro("@nombre", c.Nombre);
            da.agregarParametro("@apellido", c.Apellido);
            da.agregarParametro("@sexo", c.Sexo);
            da.agregarDateTimeParam("@fechanac", c.FechaNac);
            da.agregarParametro("@dni",c.DNI);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteCliente(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.ClientesDeleteString());
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
