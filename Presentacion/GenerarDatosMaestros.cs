using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Forms
{
    public partial class GenerarDatosMaestros : Form
    {
        private List<TipoIncidencia> lTipos = new List<TipoIncidencia>();
        private List<GrupoIncidente> lGrupos = new List<GrupoIncidente>();

        public GenerarDatosMaestros()
        {
            InitializeComponent();
            refreshTipos();
        }

        private void refreshTipos()
            {lTipos = new TipoIncidenciaCon().listar();
            cmbTipoSubtipo.DataSource = lTipos;
            cmbTipoSubtipo.Refresh();
            cmbTipoGrupo.DataSource = lTipos;
            cmbTipoGrupo.Refresh();
        }

        public void agregarTipo(object sender, EventArgs ea)
            {string nombre = txtTipoIncidenciaNombre.Text.ToString();
            int x;
            if (int.TryParse(nombre, out x))
                { MessageBox.Show("No puede ingresar un numero en el campo de nombre");
                return;
            }
            TipoIncidencia ti = new TipoIncidencia() { Descripcion=nombre };
            if (!ti.validarTipoIncidencia())
                { return;}
            try { new TipoIncidenciaCon().insertTipoIncidencia(ti);
                MessageBox.Show("Tipo dado de alta correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error con la base de datos, intente nuevamente -- Es posible que haya completado mal los campos");
                return;
            }
            finally
            {
                lTipos.Add(ti);
                refreshTipos();                
                txtTipoIncidenciaNombre.Text = "";
            }
        }

        private void refreshGrupos()
            { lGrupos = new GrupoCon().listar();
            cmbGrupoSubtipo.DataSource = lGrupos;
        }

        public void agregarGrupo(object sender, EventArgs ea)
            {if (cmbTipoGrupo.SelectedItem is null)
            {
                MessageBox.Show("Ingrese un Tipo valido!");
                return;
            }
            string nombre = txtGrupo.Text.ToString();
            int x;
            if (int.TryParse(nombre, out x))
            {
                MessageBox.Show("No puede ingresar un numero en el campo de nombre");
                return;
            }
            GrupoIncidente gI = new GrupoIncidente() { Descripcion = nombre };
            if(!gI.validarGrupo())
                {return;}
            try { new GrupoCon().insertGrupoIncidente(gI, ((TipoIncidencia)cmbTipoGrupo.SelectedItem).IdTipo);
                MessageBox.Show("Grupo dado de alta correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error con la base de datos, intente nuevamente -- Es posible que haya completado mal los campos");
                return;
            }
            finally
            {
                txtGrupo.Text = "";                
                refreshGrupos();
            }
        }

        public void agregarSubTipo(object sender, EventArgs ea)
            {if(cmbGrupoSubtipo.SelectedItem is null)
            {
                MessageBox.Show("Ingrese un Grupo valido!");
                return;
            }
            int idGrupo = ((GrupoIncidente)cmbGrupoSubtipo.SelectedItem).Id;
            string nombre = txtSubTipo.Text.ToString();
            int x;
            if (int.TryParse(nombre, out x))
            {
                MessageBox.Show("No puede ingresar un numero en el campo de nombre");
                return;
            }
            SubTipoIncidente sT = new SubTipoIncidente() { Descripcion = nombre };
            if (!sT.validarSubTipo())
                {return;}
            try { new SubTipoCon().insertSubTipoIncidente(sT, idGrupo);
                MessageBox.Show("Subtipo dado de alta correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error con la base de datos, intente nuevamente -- Es posible que haya completado mal los campos");
                return;
            }
            finally
            {
                
                txtSubTipo.Text = "";
            }
        }

        public void agregarArticulo(object sender, EventArgs ea)
        { string nombre = txtNombreArt.Text;
            int x;
            if (int.TryParse(nombre, out x))
            {
                MessageBox.Show("No puede ingresar un numero en el campo de nombre");
                return;
            }
            string precio = txtPrecioArt.Text;
            string stock = txtStock.Text;
            if (!Articulo.validarPrecio(precio) || !Articulo.validarStock(stock))
                {return;}
            int p;
            int.TryParse(precio, out p);            
            int s;
            int.TryParse(stock, out s);
            try { new ArticuloCon().insertArticulo(new Articulo() { Nombre = nombre, Precio = p, Stock = s }); }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error con la base de datos, intente nuevamente -- Es posible que haya completado mal los campos");
                return;
            }
            finally
            {
                txtNombreArt.Text = "";
                txtPrecioArt.Text = "";
                txtStock.Text = "";
                MessageBox.Show("Articulo dado de alta correctamente");
            }
        }

        private void tipoIncidChange(object sender, EventArgs e)
            {try
                { cmbGrupoSubtipo.DataSource = new GrupoCon().getGrupoIncidenteByIdTipo(((TipoIncidencia)cmbTipoSubtipo.SelectedItem).IdTipo); }
            catch (Exception ex) { } }
    }
}
