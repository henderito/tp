using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TipoIncidenciaCon
        {private DataAccess da = new DataAccess();

        public List<TipoIncidencia> listar()
        {
            da.setearConsulta(DBGral.TipoIncidenteAllString());

            List<TipoIncidencia> lista = new List<TipoIncidencia>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new TipoIncidencia()
                    {
                        IdTipo = da.Lector.GetInt32(0),
                        Descripcion = da.Lector.GetString(1)                      
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertTipoIncidencia(TipoIncidencia ti)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TipoIncidenteInsertString());
            da.agregarParametro("@descripcion", ti.Descripcion);
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public TipoIncidencia getTipoIncidenciaById(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TipoIncidenteByIdString());
            da.agregarParametro("@idt", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                TipoIncidencia ti = new TipoIncidencia()
                {
                    IdTipo = da.Lector.GetInt32(0),
                    Descripcion = da.Lector.GetString(1)
                };
                return ti;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateTipoIncidencia(TipoIncidencia ti)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TipoIncidenteUpdateString());
            da.agregarParametro("@descripcion", ti.Descripcion);
            da.agregarParametro("@idt", ti.IdTipo.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteTipoIncidencia(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TipoIncidenteDeleteString());
            da.agregarParametro("@idt", id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

    }
}
