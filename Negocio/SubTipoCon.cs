using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class SubTipoCon
        {private DataAccess da = new DataAccess();

        public List<SubTipoIncidente> listar()
            {da.setearConsulta(DBGral.SubTipoIncidenteAllString());

            List<SubTipoIncidente> lista = new List<SubTipoIncidente>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new SubTipoIncidente()
                    {
                        Id = da.Lector.GetInt32(0),
                        Descripcion = da.Lector.GetString(1),
                        IdGrupo = da.Lector.GetInt32(2)
                    });
                }
                return lista;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }            
        }

        public void insertSubTipoIncidente(SubTipoIncidente st, int idG)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.SubTipoIncidenteInsertString());
            da.agregarParametro("@descripcion", st.Descripcion);
            da.agregarParametro("@idg", idG.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public SubTipoIncidente getSubTipoIncidenteById(int id)
            {
            da.limpiarParametros();
            da.setearConsulta(DBGral.SubTipoIncidenteByIdString());
            da.agregarParametro("@idst", id.ToString());
                try
                    {da.leerConsulta();
                     da.Lector.Read();
                        SubTipoIncidente st = new SubTipoIncidente()
                        {
                            Id = da.Lector.GetInt32(0),
                            Descripcion = da.Lector.GetString(1),
                            IdGrupo = da.Lector.GetInt32(2)
                        };
                     return st;}
            catch (Exception ex)
                { throw ex; }
            finally
                { da.cerrarConexion(); }}

        public List<SubTipoIncidente> getSubTipoIncidenteByIdGrupo(int id)
            {
            da.limpiarParametros();
            da.setearConsulta(DBGral.SubTipoIncidenteByIdGrupoString());
            da.agregarParametro("@idg", id.ToString());
            List<SubTipoIncidente> lista = new List<SubTipoIncidente>();
            try
                {da.leerConsulta();
                while (da.Lector.Read())
                {
                    SubTipoIncidente st = new SubTipoIncidente()
                    {
                        Id = da.Lector.GetInt32(0),
                        Descripcion = da.Lector.GetString(1),
                        IdGrupo = da.Lector.GetInt32(2)
                    };
                    lista.Add(st);
                }
                return lista;}
                catch (Exception ex)
                { throw ex; }
                finally
                { da.cerrarConexion(); } }

        public void updateSubTipoIncidente(SubTipoIncidente st, int idG)
            {
            da.limpiarParametros();
            da.setearConsulta(DBGral.SubTipoIncidenteUpdateString());
            da.agregarParametro("@descripcion", st.Descripcion);
            da.agregarParametro("@idg", idG.ToString());
            da.agregarParametro("@idst", st.Id.ToString());
        try
        { da.executeNonQuery(); }
        catch (Exception e)
        { throw e; }
        finally
        { da.cerrarConexion(); }
    }

    public void deleteSubTipoIncidente(int id)
    {
        da.limpiarParametros();
        da.setearConsulta(DBGral.SubTipoIncidenteDeleteString());
        da.agregarParametro("@idst", id.ToString());
        try
        { da.executeNonQuery(); }
        catch (Exception e)
        { throw e; }
        finally
        { da.cerrarConexion(); }
    }

        public int getIdGrupo(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.GrupoIncidenciaIdBySubTipoString());
            da.agregarParametro("@idst", id.ToString());
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
