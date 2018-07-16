using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VentaCon
    {
        private DataAccess da = new DataAccess();

        public List<Venta> listar()
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.VentasAllString());

            List<Venta> lista = new List<Venta>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new Venta()
                    {
                        IdVenta = da.Lector.GetInt32(0),
                        Ven = new EmpleadoCon().getEmpleadoById(da.Lector.GetString(1)),
                        Cli = new ClienteCon().getClienteById(da.Lector.GetString(2)),
                        Int = new InteresCon().getInteresById(da.Lector.GetInt32(3)),
                        Fecha = da.Lector.GetDateTime(4),
                        //ArticulosVendidos = getArticulosVenta(da.Lector.GetInt32(0))
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public List<Venta> ventasPorDia(DateTime d)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.VentasByDia());
            da.agregarDateTimeParam("@fecha",d);

            List<Venta> lista = new List<Venta>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new Venta()
                    {
                        IdVenta = da.Lector.GetInt32(0),
                        Ven = new EmpleadoCon().getEmpleadoById(da.Lector.GetString(1)),
                        Cli = new ClienteCon().getClienteById(da.Lector.GetString(2)),
                        Int = new InteresCon().getInteresById(da.Lector.GetInt32(3)),
                        Fecha = da.Lector.GetDateTime(4),
                        //ArticulosVendidos = getArticulosVenta(da.Lector.GetInt32(0))
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertVenta(Venta v)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.VentasInsertString());
            da.agregarParametro("@dnie", v.Ven.DNI);
            da.agregarParametro("@dnic", v.Cli.DNI);
            da.agregarParametro("@idinteres", v.Int.Id.ToString());
            da.agregarParametro("@fecha", v.Fecha.ToString());
            try
                {da.executeNonQuery();
                da.cerrarConexion();
                int idV = getLastIdVenta();
                da.cerrarConexion();
                for (int i = 0; i < v.ArticulosVendidos.Count(); i++)
                    { insertArticuloVenta(v.ArticulosVendidos[i],idV); }
            }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        private int getLastIdVenta()
            { da.limpiarParametros();
            da.setearConsulta(DBGral.LastIdVenta());
            da.leerConsulta();
            da.Lector.Read();
            return da.Lector.GetInt32(0);
        }

        private void insertArticuloVenta(Articulo a, int idVenta)
            { da.limpiarParametros();
            da.setearConsulta(DBGral.ArticulosVentasInsertString());
            da.agregarParametro("@idv",idVenta.ToString());
            da.agregarParametro("@ida",a.IdArticulo.ToString());
            da.agregarParametro("@qart",a.CantVendida.ToString());
            da.executeNonQuery();
            da.cerrarConexion();
        }

        private List<Articulo> getArticulosVenta(int id)
            { da.limpiarParametros();
            da.setearConsulta(DBGral.ArticulosVentasByIdVenString());
            da.agregarParametro("@idv", id.ToString());
            try
            {
                da.leerConsulta();
                List<Articulo> a = new List<Articulo>();
                while (da.Lector.Read())
                { a.Add(new ArticuloCon().getArticuloById(da.Lector.GetInt32(1))); }
                return a;
            }
            catch (Exception e)
            { throw e; }
            finally { da.cerrarConexion(); }           
        }

        public Venta getVentaById(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.VentasByIdString());
            da.agregarParametro("@idv", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Venta v = new Venta()
                {
                    IdVenta = da.Lector.GetInt32(0),
                    Ven = new EmpleadoCon().getEmpleadoById(da.Lector.GetString(1)),
                    Cli = new ClienteCon().getClienteById(da.Lector.GetString(2)),
                    Int = new InteresCon().getInteresById(da.Lector.GetInt32(3)),
                    Fecha = da.Lector.GetDateTime(4)
                };
                return v;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateVenta(Venta v)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.ArticulosUpdateString());
            da.agregarParametro("@dnie", v.Ven.DNI);
            da.agregarParametro("@dnic", v.Cli.DNI);
            da.agregarParametro("@idinteres", v.Int.Id.ToString());
            da.agregarParametro("@fecha", v.Fecha.ToString());
            da.agregarParametro("@idv", v.IdVenta.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteVenta(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.VentasDeleteString());
            da.agregarParametro("@idv", id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
