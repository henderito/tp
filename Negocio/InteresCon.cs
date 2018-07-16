using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class InteresCon
        {private DataAccess da = new DataAccess();

        public List<Interes> listar()
        {
            da.setearConsulta(DBGral.InteresesAllString());

            List<Interes> lista = new List<Interes>();
            try
            {
                da.leerConsulta();
                while (da.Lector.Read())
                {
                    lista.Add(new Interes()
                    {
                        Id = da.Lector.GetInt32(0),                        
                        Porcentaje = da.Lector.GetInt32(1),
                        Nombre = da.Lector.GetString(2)
                    });
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
            return lista;
        }

        public void insertInteres(Interes i)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.InteresesInsertString());
            da.agregarParametro("@nombre", i.Nombre);
            da.agregarParametro("@porcentaje", i.Porcentaje.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public Interes getInteresById(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.InteresesByIdString());
            da.agregarParametro("@idi", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Interes i = new Interes()
                {
                    Id = da.Lector.GetInt32(0),
                    Porcentaje = da.Lector.GetInt32(1),
                    Nombre = da.Lector.GetString(2)
                };
                return i;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { da.cerrarConexion(); }
        }

        public void updateInteres(Interes i)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.InteresesUpdateString());
            da.agregarParametro("@nombre", i.Nombre);
            da.agregarParametro("@porcentaje", i.Porcentaje.ToString());
            da.agregarParametro("@idi", i.Id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            { da.cerrarConexion(); }
        }

        public void deleteInteres(int id)
        {
            da.limpiarParametros();
            da.setearConsulta(DBGral.InteresesDeleteString());
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
