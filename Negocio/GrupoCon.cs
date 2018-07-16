using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class GrupoCon
    {
        private DataAccess da = new DataAccess();

        public List<GrupoIncidente> listar()
        {
            da.setearConsulta(DBGral.GrupoIncidenteAllString());

            List<GrupoIncidente> lista = new List<GrupoIncidente>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new GrupoIncidente()
                    {
                        Id = da.Lector.GetInt32(0),
                        Descripcion = da.Lector.GetString(1),
                        IdTipo = da.Lector.GetInt32(2)
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertGrupoIncidente(GrupoIncidente g, int idT)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.GrupoIncidenteInsertString());
            da.agregarParametro("@descripcion", g.Descripcion);
            da.agregarParametro("@idt", idT.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public GrupoIncidente getGrupoIncidenteById(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.GrupoIncidenteByIdString());
            da.agregarParametro("@idg", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                GrupoIncidente g = new GrupoIncidente()
                {
                    Id = da.Lector.GetInt32(0),
                    Descripcion = da.Lector.GetString(1),
                    IdTipo = da.Lector.GetInt32(2)
                };
                return g;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public List<GrupoIncidente> getGrupoIncidenteByIdTipo(int id)
        {
            List<GrupoIncidente> lista = new List<GrupoIncidente>();
            da.limpiarParametros();
            da.setearConsulta(DBGral.GrupoIncidenteByIdTipoString());
            da.agregarParametro("@idt", id.ToString());
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    GrupoIncidente g = new GrupoIncidente()
                    {
                        Id = da.Lector.GetInt32(0),
                        Descripcion = da.Lector.GetString(1),
                        IdTipo = da.Lector.GetInt32(2)
                    };
                    lista.Add(g);
                }
                return lista;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateGrupoIncidente(GrupoIncidente g, int idT)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.GrupoIncidenteUpdateString());
            da.agregarParametro("@descripcion", g.Descripcion);
            da.agregarParametro("@idt", idT.ToString());
            da.agregarParametro("@idg", g.Id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteGrupoIncidente(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.GrupoIncidenteDeleteString());
            da.agregarParametro("@idg", id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public int getIdTipo(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.TipoIncidenciaIdByGrupoString());
            da.agregarParametro("@idg", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();                
                return da.Lector.GetInt32(0);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
