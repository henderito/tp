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
    public partial class PreABM : Form
    {
        public PreABM(string x)
        {
            InitializeComponent();
            if (x.Equals("Clientes"))
                { dgvItems.DataSource = new ClienteCon().listar(); }
            else if (x.Equals("Empleados"))
                { dgvItems.DataSource = new EmpleadoCon().listar(); }
            else if (x.Equals("Ventas"))
                { dgvItems.DataSource = new VentaCon().listar(); }
            else if (x.Equals("Incidentes"))
                { dgvItems.DataSource = new IncidenciaCon().listar();
                dgvItems.Columns["IdIncidencia"].Visible = false;
                dgvItems.Columns["ventaRelacionada"].Visible = false;
                dgvItems.Columns["Descripcion"].Visible = false;
                dgvItems.Columns["PrioridadAlta"].Visible = false;
            }
            dgvItems.Refresh();
            dgvItems.AutoResizeColumns();
            dgvItems.AutoResizeRows();
            resizeDataGrid();
        }

        private void resizeDataGrid()
            { DataGridViewElementStates dgvState = DataGridViewElementStates.None;
            dgvItems.ScrollBars = ScrollBars.None;
            var totalHeight = dgvItems.Rows.GetRowsHeight(dgvState) + dgvItems.ColumnHeadersHeight;
            totalHeight += dgvItems.Rows.Count * 4;
            var totalWidth = dgvItems.Columns.GetColumnsWidth(dgvState) + dgvItems.RowHeadersWidth;
            dgvItems.ClientSize = new Size(totalWidth, totalHeight);
            this.Size = new Size(totalWidth + 25, totalHeight * 3);
        }

        private void goToABM(object sender, EventArgs ea)
            {object aux = dgvItems.CurrentRow.DataBoundItem;
            if (aux is Cliente || aux is Empleado)
                { NuevoUsuario nU = new NuevoUsuario((Persona)aux);
                nU.Text = "Modificación de Usuario";
                nU.ShowDialog();
                this.Close();
            }
            else if (aux is Venta)
                { NuevaVenta nV = new NuevaVenta((Venta)aux);
                nV.Text = "Modificación de Venta";
                nV.ShowDialog();
                this.Close();
            }
            else if (aux is Incidencia)
                { NuevoIncidente nI = new NuevoIncidente((Incidencia)aux);
                nI.Text = "Modificación de Incidente";
                nI.ShowDialog();
                this.Close();
            }
        }
    }
}
