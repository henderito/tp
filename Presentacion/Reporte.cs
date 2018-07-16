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

namespace Forms
{
    public partial class Reporte : Form
    {
        private List<Incidencia> i = null;
        private List<Venta> v = null;

        public Reporte(List<Venta> l)
        {
            InitializeComponent();
            dgvReporte.DataSource = l;
            dgvReporte.Columns["IdVenta"].Visible = false;
            resizeDataGrid();
            v = l;
        }

        public Reporte(List<Incidencia> l)
        {
            InitializeComponent();
            dgvReporte.DataSource = l;
            dgvReporte.Columns["IdIncidencia"].Visible = false;
            dgvReporte.Columns["PrioridadAlta"].Visible = false;
            resizeDataGrid();
            i = l;
        }

        private void resizeDataGrid()
        {
            DataGridViewElementStates dgvState = DataGridViewElementStates.None;
            dgvReporte.ScrollBars = ScrollBars.None;
            var totalHeight = dgvReporte.Rows.GetRowsHeight(dgvState) + dgvReporte.ColumnHeadersHeight;
            totalHeight += dgvReporte.Rows.Count * 4;
            var totalWidth = dgvReporte.Columns.GetColumnsWidth(dgvState) + dgvReporte.RowHeadersWidth;
            dgvReporte.ClientSize = new Size(totalWidth, totalHeight);
        }

        private void print(object sender, EventArgs e)
        {
            if (v is null)
            { new ReportGen().reporte(i); }
            else
            { new ReportGen().reporte(v); }
        }
    }
}
