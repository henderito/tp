using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EquipoCon
        {private DataAccess da = new DataAccess();

        public List<Equipo> listar()
        {
            da.setearConsulta(DBGral.EquiposAllString());

            List<Equipo> lista = new List<Equipo>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new Equipo()
                    {
                        id = da.Lector.GetInt32(0),
                        Nombre = da.Lector.GetString(1),                       
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertEquipo(Equipo e)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EquiposInsertString());
            da.agregarParametro("@nombre", e.Nombre);
            try
            { da.executeNonQuery(); }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public Equipo getEquipoById(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EquiposByIdString());
            da.agregarParametro("@idg", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Equipo e = new Equipo()
                {
                    id = da.Lector.GetInt32(0),
                    Nombre = da.Lector.GetString(1),                    
                };
                return e;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateEquipo(Equipo e)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EquiposUpdateString());
            da.agregarParametro("@nombre", e.Nombre);
            da.agregarParametro("@ide", e.id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteEquipo(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.EquiposDeleteString());
            da.agregarParametro("@ide", id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }
    }
}
