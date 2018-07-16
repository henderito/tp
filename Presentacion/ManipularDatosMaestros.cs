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
    public partial class ManipularDatosMaestros : Form
        { private string usedItems;
        private List<TipoIncidencia> lTipos;
        private List<GrupoIncidente> lGrupos;
        private List<SubTipoIncidente> lSubTipos;
        private List<Articulo> lArticulos;

        public ManipularDatosMaestros()
        {
            InitializeComponent();
            lTipos = new TipoIncidenciaCon().listar();
            lGrupos = new GrupoCon().listar();
            lSubTipos = new SubTipoCon().listar();
            lArticulos = new ArticuloCon().listar();
        }

        private void resizeDataGrid()
        {
            DataGridViewElementStates dgvState = DataGridViewElementStates.None;
            dgvItems.ScrollBars = ScrollBars.None;
            var totalHeight = dgvItems.Rows.GetRowsHeight(dgvState) + dgvItems.ColumnHeadersHeight;
            totalHeight += dgvItems.Rows.Count * 4;
            var totalWidth = (dgvItems.Columns.GetColumnsWidth(dgvState) + dgvItems.RowHeadersWidth);
            dgvItems.ClientSize = new Size(totalWidth, totalHeight);
        }

        public void clickTipos(object sender, EventArgs ea)
            {
            dgvItems.DataSource = lTipos;
            dgvItems.Columns["IdTipo"].Visible = false;
            dgvItems.Refresh();
            usedItems = "Tipos";
            resizeDataGrid();
        }

        public void clickGrupos(object sender, EventArgs ea)
            {
            dgvItems.DataSource = lGrupos;
            dgvItems.Columns["IdTipo"].Visible = false;
            dgvItems.Columns["Id"].Visible = false;
            dgvItems.Refresh();
            usedItems = "Grupos";
            resizeDataGrid();
        }

        public void clickSubtipo(object sender, EventArgs ea)
            {
            dgvItems.DataSource = lSubTipos;
            dgvItems.Columns["Id"].Visible = false;
            dgvItems.Columns["IdGrupo"].Visible = false;
            dgvItems.Refresh();
            usedItems = "Subtipos";
            resizeDataGrid();
        }

        public void clickArticulo(object sender, EventArgs ea)
            {
            dgvItems.DataSource = lArticulos;
            dgvItems.Columns["IdArticulo"].Visible = false;
            dgvItems.Columns["CantVendida"].Visible = false;
            dgvItems.Refresh();
            usedItems = "Articulos";
            resizeDataGrid();
        }        

        public void guardar(object sender, EventArgs ea)
            {if (usedItems.Equals("Tipos"))
            { foreach (TipoIncidencia x in lTipos)
                { new TipoIncidenciaCon().updateTipoIncidencia(x); } }
            else if (usedItems.Equals("Grupos"))
            {
                GrupoCon con = new GrupoCon();
                foreach (GrupoIncidente x in lGrupos)
                {
                    int aux = con.getIdTipo(((GrupoIncidente)x).Id);
                    new GrupoCon().updateGrupoIncidente(x,aux); }
            }
            else if (usedItems.Equals("Subtipos"))
            {
                SubTipoCon con = new SubTipoCon();
                foreach (SubTipoIncidente x in lSubTipos)
                {
                    int aux = con.getIdGrupo(((SubTipoIncidente)x).Id);
                    new SubTipoCon().updateSubTipoIncidente(x, aux);
                }
            }
            else if (usedItems.Equals("Articulos"))
            {
                foreach (Articulo x in lArticulos)
                { new ArticuloCon().updateArticulo(x); }
            }
        }

        private void actualizarValor(object sender, DataGridViewCellEventArgs e)
            {if (usedItems.Equals("Tipos"))
            { lTipos[e.RowIndex] = ((TipoIncidencia)dgvItems.CurrentRow.DataBoundItem);  }
            else if (usedItems.Equals("Grupos"))
            { lGrupos[e.RowIndex] = ((GrupoIncidente)dgvItems.CurrentRow.DataBoundItem); }
            else if (usedItems.Equals("Subtipos"))
            { lSubTipos[e.RowIndex] = ((SubTipoIncidente)dgvItems.CurrentRow.DataBoundItem); }
            else if (usedItems.Equals("Articulos"))
            { lArticulos[e.RowIndex] = ((Articulo)dgvItems.CurrentRow.DataBoundItem); }
        }

        public void deleteItem(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
                { MessageBox.Show("Debe seleccionar al menos una linea");
                return;
            }
            object o = dgvItems.CurrentRow.DataBoundItem;
            if (o is TipoIncidencia)
            { new TipoIncidenciaCon().deleteTipoIncidencia(((TipoIncidencia)o).IdTipo);
                lTipos.Remove((TipoIncidencia)o);
                dgvItems.DataSource = null;
                dgvItems.DataSource = lTipos;
                dgvItems.Columns["IdTipo"].Visible = false;
            }
            else if (o is GrupoIncidente)
            { new GrupoCon().deleteGrupoIncidente(((GrupoIncidente)o).Id);
                lGrupos.Remove((GrupoIncidente)o);
                dgvItems.DataSource = null;
                dgvItems.DataSource = lGrupos;
                dgvItems.Columns["IdTipo"].Visible = false;
                dgvItems.Columns["Id"].Visible = false;
            }
            else if (o is SubTipoIncidente)
            { new SubTipoCon().deleteSubTipoIncidente(((SubTipoIncidente)o).Id);
                lSubTipos.Remove((SubTipoIncidente)o);
                dgvItems.DataSource = null;
                dgvItems.DataSource = lSubTipos;
                dgvItems.Columns["Id"].Visible = false;
                dgvItems.Columns["IdGrupo"].Visible = false;
            }
            else if (o is Articulo)
            { new ArticuloCon().deleteArticulo(((Articulo)o).IdArticulo);
                //lArticulos.Remove((Articulo)o);
                lArticulos.RemoveAt(dgvItems.CurrentRow.Index);
                dgvItems.DataSource = null;
                dgvItems.DataSource = lArticulos;
                dgvItems.Columns["IdArticulo"].Visible = false;
                dgvItems.Columns["CantVendida"].Visible = false;
            }
            dgvItems.Refresh();
            return;
        }
    }
}
