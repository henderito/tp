using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloCon
        {private DataAccess da = new DataAccess();

        public List<Articulo> listar()
            {da.setearConsulta(DBGral.ArticulosAllString());
             
             List<Articulo> lista = new List<Articulo>();
             try
                {da.leerConsulta();
                 while (da.Lector.Read())
                    {lista.Add(new Articulo() {
                         IdArticulo = da.Lector.GetInt32(0),
                         Nombre = da.Lector.GetString(1),
                         Precio = da.Lector.GetInt32(2),
                         Stock = da.Lector.GetInt32(3)});}}
             catch (Exception ex)
                {throw ex;}
             finally
                { da.cerrarConexion(); }
            return lista;}

        public void insertArticulo(Articulo a)
            {da.limpiarParametros();
            da.setearConsulta(DBGral.ArticulosInsertString());
            da.agregarParametro("@precio", a.Precio.ToString());
            da.agregarParametro("@nombre",a.Nombre.ToString());
            da.agregarParametro("@stock", a.Stock.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
                {throw e; }
            finally
            { da.cerrarConexion(); }}

        public Articulo getArticuloById(int id)
            {da.limpiarParametros();
            da.setearConsulta(DBGral.ArticulosByIdString());
            da.agregarParametro("@id", id.ToString());
            try
            {
                da.leerConsulta();
                da.Lector.Read();
                Articulo a = new Articulo() {
                        IdArticulo = da.Lector.GetInt32(0),
                        Nombre = da.Lector.GetString(1),
                        Precio = da.Lector.GetInt32(2),
                        Stock = da.Lector.GetInt32(3)
                    };
                return a;
            }
            catch (Exception ex)
                { throw ex; }
            finally
                { da.cerrarConexion(); }}

        public void updateArticulo(Articulo a)
            {da.limpiarParametros();
            da.setearConsulta(DBGral.ArticulosUpdateString());
            da.agregarParametro("@nombre",a.Nombre.ToString());
            da.agregarParametro("@precio", a.Precio.ToString());
            da.agregarParametro("@stock", a.Stock.ToString());
            da.agregarParametro("@ida", a.IdArticulo.ToString());
            try
                { da.executeNonQuery(); }
            catch (Exception e)
                { throw e; }
            finally
                { da.cerrarConexion(); }
        }

        public void deleteArticulo(int id)
            {da.limpiarParametros();
            da.setearConsulta(DBGral.ArticulosDeleteString());
            da.agregarParametro("@ida",id.ToString());
            try
            { da.executeNonQuery(); }
            catch (Exception e)
            { throw e; }
            finally
            {da.cerrarConexion(); }
        }
    }
}
