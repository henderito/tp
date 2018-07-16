using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


//Agregar algun tipo de reporte (imprimir en PDF o algun tipo de exportacion)
//

namespace Negocio
{
    public class DomicilioCon
        {private DataAccess da = new DataAccess();

        public List<Domicilio> listarDomEmpleados()
            {da.setearConsulta(DBGral.DomiciliosEmAllString());
            List<Domicilio> lista = new List<Domicilio>();
            try
                {da.leerConsulta();
                while (da.Lector.Read())
                    {lista.Add(new Domicilio()
                        {
                        Calle = da.Lector.GetString(1),
                        Altura = da.Lector.GetInt32(2).ToString(),
                        Piso = (da.Lector.IsDBNull(3)) ? "0" : da.Lector.GetInt32(3).ToString(),
                        Departamento = (da.Lector.IsDBNull(4)) ? "-" : da.Lector.GetString(4)
                    });}
            }
            catch (Exception ex)
                { throw ex; }
            finally
                { da.cerrarConexion(); }
            return lista;
        }

        public void insertDomicilioEmpleado(String DNIe, Domicilio d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosEmInsertString());
            da.agregarParametro("@dni", DNIe);
            da.agregarParametro("@calle", d.Calle);
            da.agregarParametro("@altura", d.Altura);
            da.agregarParametro("@piso", d.Piso);
            da.agregarParametro("@depto", d.Departamento);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public Domicilio getDomicilioEmpleadoById(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosEmByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Domicilio a = new Domicilio()
                {
                    Calle = da.Lector.GetString(1),
                    Altura = da.Lector.GetInt32(2).ToString(),
                    Piso = (da.Lector.IsDBNull(3)) ? "0" : da.Lector.GetInt32(3).ToString(),
                    Departamento = (da.Lector.IsDBNull(4)) ? "-" : da.Lector.GetString(4)
                };
                return a;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateDomicilioEmpleado(Domicilio d, String DNIe)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosEmUpdateString());
            da.agregarParametro("@calle", d.Calle);
            da.agregarParametro("@altura", d.Altura);
            da.agregarParametro("@piso", d.Piso);
            da.agregarParametro("@departamento", d.Departamento);
            da.agregarParametro("@dni", DNIe);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteDomicilioEmpleado(String DNIe)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosEmDeleteString());
            da.agregarParametro("@dni", DNIe);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public List<Domicilio> listarDomClientes()
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosClAllString());
            List<Domicilio> lista = new List<Domicilio>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new Domicilio()
                    {
                        Calle = da.Lector.GetString(1),
                        Altura = da.Lector.GetInt32(2).ToString(),
                        Piso = (da.Lector.IsDBNull(3)) ? "0" : da.Lector.GetInt32(3).ToString(),
                        Departamento = (da.Lector.IsDBNull(4)) ? "-" : da.Lector.GetString(4)
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertDomicilioCliente(String DNIc, Domicilio d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosClInsertString());
            da.agregarParametro("@dni", DNIc);
            da.agregarParametro("@calle", d.Calle);
            da.agregarParametro("@altura", d.Altura);
            da.agregarParametro("@piso", d.Piso);
            da.agregarParametro("@depto", d.Departamento);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public Domicilio getDomicilioClienteById(String DNI)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosClByIdString());
            da.agregarParametro("@dni", DNI);
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Domicilio a = new Domicilio()
                {
                    Calle = da.Lector.GetString(1),
                    Altura = da.Lector.GetInt32(2).ToString(),
                    Piso = (da.Lector.IsDBNull(3)) ? "0" : da.Lector.GetInt32(3).ToString(),
                    Departamento = (da.Lector.IsDBNull(4)) ? "0" : da.Lector.GetString(4)
                };
                return a;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateDomicilioCliente(Domicilio d, String DNIc)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosClUpdateString());
            da.agregarParametro("@calle", d.Calle);
            da.agregarParametro("@altura", d.Altura);
            da.agregarParametro("@piso", d.Piso);
            da.agregarParametro("@depto", d.Departamento);
            da.agregarParametro("@dni", DNIc);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteDomicilioCliente(String DNIc)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.DomiciliosClDeleteString());
            da.agregarParametro("@dni", DNIc);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
