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
    public partial class NuevoIncidente : Form
    {
        private int idI;

        public NuevoIncidente()
        {
            InitializeComponent();
            btnAlta.Visible = true;
            btnModificar.Visible = false;
            cargarCombos();
            txtEstado.Enabled = false;
            chkCerrar.Visible = false;
        }

        public NuevoIncidente(Incidencia i)
            { InitializeComponent();
            cargarCombos();
            btnAlta.Visible = false;
            btnModificar.Visible = true;
            cmbCliente.SelectedItem = i.Cli;
            cmbEmpleado.SelectedItem = i.Ven;
            txtDescripcion.Text = i.Descripcion;
            cmbTipo.SelectedItem = i.Tipo;
            cmbGrupo.SelectedItem = i.Grupo;
            cmbSubTipo.SelectedItem = i.SubTipo;
            cmbVenta.SelectedItem = i.ventaRelacionada;            
            if (i.PrioridadAlta) { chkPrioridad.Checked = true; }
            txtEstado.Text = i.Estado;
            if (i.Estado.Equals("Cerrado"))
                { cmbCliente.Enabled = false;
                cmbEmpleado.Enabled = false;
                cmbTipo.Enabled = false;
                cmbGrupo.Enabled = false;
                cmbSubTipo.Enabled = false;
                cmbVenta.Enabled = false;
                txtDescripcion.Enabled = false;
                btnModificar.Enabled = false;
                chkPrioridad.Enabled = false;
                dtpFecha.Enabled = false;
            }
            txtEstado.Enabled = false;
            idI = i.IdIncidencia;
        }

        private void cargarCombos()
            { cmbCliente.DataSource = new ClienteCon().listar();
            cmbEmpleado.DataSource = new EmpleadoCon().listar();
            cmbTipo.DataSource = new TipoIncidenciaCon().listar();
            cmbTipo.SelectedIndex = 0;
            cmbGrupo.DataSource = new GrupoCon().getGrupoIncidenteByIdTipo(((TipoIncidencia)cmbTipo.SelectedItem).IdTipo);
            cmbSubTipo.DataSource = new SubTipoCon().getSubTipoIncidenteByIdGrupo(((GrupoIncidente)cmbGrupo.SelectedItem).Id);
            cmbVenta.DataSource = new VentaCon().listar();            
        }

        private void updateCBGrupo(object sender, EventArgs e)
            { cmbGrupo.DataSource = new GrupoCon().getGrupoIncidenteByIdTipo(((TipoIncidencia)cmbTipo.SelectedItem).IdTipo); }

        private void updateCBSubtipo(object sender, EventArgs e)
            { cmbSubTipo.DataSource = new SubTipoCon().getSubTipoIncidenteByIdGrupo(((GrupoIncidente)cmbGrupo.SelectedItem).Id); }

        private void modificarIncidente(object sender, EventArgs e)
        {
            Incidencia i = new Incidencia()
            {
                IdIncidencia = idI,
                Cli = (Cliente)cmbCliente.SelectedItem,
                Ven = (Empleado)cmbEmpleado.SelectedItem,
                Descripcion = txtDescripcion.Text,
                Estado = (chkCerrar.Checked) ? "Cerrado" : "En Análisis", 
                PrioridadAlta = chkPrioridad.Checked,
                Tipo = (TipoIncidencia)cmbTipo.SelectedItem,            
                Grupo = (GrupoIncidente)cmbGrupo.SelectedItem,
                SubTipo = (SubTipoIncidente)cmbSubTipo.SelectedItem,
                ventaRelacionada = (Venta)cmbVenta.SelectedItem,
                Fecha = dtpFecha.Value
            };
            if (!i.validarIncidencia())
                { MessageBox.Show("Los datos cargados son incorrectos!!");
                return;
            }
            new IncidenciaCon().updateIncidencia(i);
            MessageBox.Show("Incidencia actualizada correctamente");
            txtDescripcion.Text = "";
            this.Close();
        }

        private void altaIncidente(object sender, EventArgs e)
        {
            Incidencia i = new Incidencia()
            {
                Cli = (Cliente)cmbCliente.SelectedItem,
                Ven = (Empleado)cmbEmpleado.SelectedItem,
                Descripcion = txtDescripcion.Text,
                Estado = "Abierto",
                PrioridadAlta = chkPrioridad.Checked,
                Tipo = (TipoIncidencia)cmbTipo.SelectedItem,
                Grupo = (GrupoIncidente)cmbGrupo.SelectedItem,
                SubTipo = (SubTipoIncidente)cmbSubTipo.SelectedItem,
                ventaRelacionada = (Venta)cmbVenta.SelectedItem,
                Fecha = dtpFecha.Value
            };
            if (!i.validarIncidencia())
            {
                MessageBox.Show("Los datos cargados son incorrectos!!");
                return;
            }
            new IncidenciaCon().insertIncidencia(i);
            MessageBox.Show("Incidencia dada de alta correctamente");
            txtDescripcion.Text = "";
        }
    }
}
