using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class IncidenciaCon
    {
        private DataAccess da = new DataAccess();

        public List<Incidencia> listar()
        {
            da.setearConsulta(DBGral.IncidentesAllString());

            List<Incidencia> lista = new List<Incidencia>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    Incidencia i = new Incidencia();
                    i.IdIncidencia = da.Lector.GetInt32(0);
                    int es = da.Lector.GetInt32(1);
                    if (es == 1)
                    { i.Estado = "Abierto"; }
                    else if (es == 2)
                    { i.Estado = "En Análisis"; }
                    else { i.Estado = "Cerrado"; }
                    i.Cli = new ClienteCon().getClienteById(da.Lector.GetString(2));
                    i.Ven = new EmpleadoCon().getEmpleadoById(da.Lector.GetString(3));
                    i.PrioridadAlta = da.Lector.GetBoolean(4);
                    i.Tipo = new TipoIncidenciaCon().getTipoIncidenciaById(da.Lector.GetInt32(5));
                    i.Grupo = new GrupoCon().getGrupoIncidenteById(da.Lector.GetInt32(6));
                    i.SubTipo = new SubTipoCon().getSubTipoIncidenteById(da.Lector.GetInt32(7));
                    i.ventaRelacionada = (da.Lector.IsDBNull(8)) ? new Venta() : new VentaCon().getVentaById(da.Lector.GetInt32(8));
                    i.Fecha = da.Lector.GetDateTime(9);
                    i.Descripcion = da.Lector.GetString(10);                    
                    lista.Add(i);
                }
                return lista;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }            
        }

        public List<Incidencia> incidenciaPorDia(DateTime d)
        {

            List<Incidencia> lista = new IncidenciaCon().listar();
            List<Incidencia> aux = new List<Incidencia>();
            for (int i = 0; i < lista.Count(); i++)
                {if (lista[i].Fecha.Date.Equals(d.Date))
                    { aux.Add(lista[i]); } }
            return aux;
        }

        public void insertIncidencia(Incidencia i)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.IncidentesInsertString());
            da.agregarParametro("@estado", "1");
            da.agregarParametro("@dnic", i.Cli.DNI.ToString());
            da.agregarParametro("@dnie", i.Ven.DNI.ToString());
            da.agregarParametro("@palta", i.PrioridadAlta.ToString());
            da.agregarParametro("@idt", i.Tipo.IdTipo.ToString());
            da.agregarParametro("@idg", i.Grupo.Id.ToString());
            da.agregarParametro("@ids", i.SubTipo.Id.ToString());
            if (i.ventaRelacionada is null)
                { da.agregarNullInt("@idv"); }
            else
                { da.agregarParametro("@idv", i.ventaRelacionada.IdVenta.ToString()); }
            da.agregarDateTimeParam("@fecha", i.Fecha);
            da.agregarParametro("@desc", i.Descripcion);
            try
            { da.executeNonQuery(); }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public Incidencia getIncidenciaById(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.IncidentesByIdString());
            da.agregarParametro("@idi", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                int es = da.Lector.GetInt32(1);
                string x;
                if (es == 1)
                { x = "Abierto"; }
                else if (es == 2)
                { x = "En Análisis"; }
                else { x = "Cerrado"; }
                Incidencia i = new Incidencia()
                {
                    IdIncidencia = da.Lector.GetInt32(0),
                    Estado = x,
                    Cli = new ClienteCon().getClienteById(da.Lector.GetString(2)),
                    Ven = new EmpleadoCon().getEmpleadoById(da.Lector.GetString(3)),
                    PrioridadAlta = da.Lector.GetBoolean(4),
                    Tipo = new TipoIncidenciaCon().getTipoIncidenciaById(da.Lector.GetInt32(5)),
                    Grupo = new GrupoCon().getGrupoIncidenteById(da.Lector.GetInt32(6)),
                    SubTipo = new SubTipoCon().getSubTipoIncidenteById(da.Lector.GetInt32(7)),
                    ventaRelacionada = (da.Lector.IsDBNull(8)) ? new Venta() : new VentaCon().getVentaById(da.Lector.GetInt32(8)),
                    Fecha = da.Lector.GetDateTime(9),
                    Descripcion = da.Lector.GetString(10)
            };
                return i;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateIncidencia(Incidencia i)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.IncidentesUpdateString());
            int e;
            if (i.Estado.Equals("En Análisis")) e = 2;
            else { e = 3; }
            da.agregarParametro("@estado", e.ToString());
            da.agregarParametro("@dnic", i.Cli.DNI.ToString());
            da.agregarParametro("@dnie", i.Ven.DNI.ToString());
            da.agregarParametro("@palta", i.PrioridadAlta.ToString());
            da.agregarParametro("@idt", i.Tipo.IdTipo.ToString());
            if (i.ventaRelacionada is null)
            { da.agregarNullInt("@idv"); }
            else
            { da.agregarParametro("@idv", i.ventaRelacionada.IdVenta.ToString()); }
            da.agregarParametro("@idg", i.Grupo.Id.ToString());
            da.agregarParametro("@ids", i.SubTipo.Id.ToString());            
            da.agregarParametro("@idi", i.IdIncidencia.ToString());
            da.agregarDateTimeParam("@fecha", i.Fecha);
            da.agregarParametro("@desc", i.Descripcion);
            try
            { da.executeNonQuery(); }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteIncidencia(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.IncidentesDeleteString());
            da.agregarParametro("@idi", id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
