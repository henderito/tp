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
    public partial class NuevaVenta : Form
    {
        public List<Articulo> x;
        private Venta aux;
        public NuevaVenta()
        {
            InitializeComponent();
            cargarGrillas();
          //  btnModificarVenta.Visible = false;
            btnNuevaVenta.Visible = true;
            btnEliminarVenta.Visible = false;
            x = new List<Articulo>();
            refreshGrid();
            lblCosto.Text = "Costo Total: $ 0";
        }

        public NuevaVenta(Venta v)
            { InitializeComponent();
            cargarGrillas();
         //   btnModificarVenta.Visible = true;
            btnNuevaVenta.Visible = false;
            btnEliminarVenta.Visible = true;
            cmbClientes.SelectedItem = v.Cli;
            cmbVentas.SelectedItem = v.Ven;
            cmbInteres.SelectedItem = v.Int;
            x = v.ArticulosVendidos;
           // refreshGrid();
           // updateCosto();
            dgvArticulos.Enabled = false;
            cmbArticulos.Enabled = false;
            txtCant.Enabled = false;
            btnSacar.Enabled = false;
            btnAgregar.Enabled = false;
            aux = v;
        }

        private void cargarGrillas()
            {cmbClientes.DataSource = new ClienteCon().listar();
            cmbArticulos.DataSource = new ArticuloCon().listar();
            cmbVentas.DataSource = new EmpleadoCon().listar();
            cmbInteres.DataSource = new InteresCon().listar();
        }

        private void updateCosto()
            {double costoTotal = 0.00;
            double porcentaje;
            for (int i = 0; i < x.Count(); i++)
                { costoTotal += (x[i].Precio * x[i].CantVendida); }
            porcentaje = (((Interes)cmbInteres.SelectedItem).Porcentaje / 100.00) * costoTotal;
            lblCosto.Text = "Costo Total: $ " + (costoTotal + porcentaje).ToString();
        }

        public void updateCosto(object sender, EventArgs e)
            {if (x is null)
                { return; }
            updateCosto(); }

        private void refreshGrid()
            { dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = x;
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["Stock"].Visible = false;
            
        }

        private void limpiarPantalla()
            { txtCant.Text = "";
            dgvArticulos.DataSource = null;
            dgvArticulos.Refresh();
            lblCosto.Text = "Costo Total: $ 0";
            cargarGrillas();
        }

        private void addArt(object sender, EventArgs e)
            {Articulo a = (Articulo)cmbArticulos.SelectedItem;
            int i;
            if (!int.TryParse(txtCant.Text, out i))
                { MessageBox.Show("La cantidad debe ser un numero entero");
                  return; }
            if (a.Stock < i)
                { MessageBox.Show("No hay suficiente stock de ese producto");
                return; }
            for (int z = 0; z < x.Count(); z++)
                { if (a.Nombre.Equals(x[z].Nombre))
                    { x[z].CantVendida += i;
                    refreshGrid();
                    updateCosto();
                    return;
                } }
            a.CantVendida = i;
            x.Add(a);
            refreshGrid();
            updateCosto();
        }

        private void delArt(object sender, EventArgs e)
            {if (dgvArticulos.CurrentRow is null)
                { MessageBox.Show("Seleccione un articulo");
                return;
            }
            Articulo a = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            x.Remove(a);
            refreshGrid();
            updateCosto();
        }

        private void modificarVenta(object sender, EventArgs e)
        {
           /* if (x.Count() == 0)
                { MessageBox.Show("No hay articulos seleccionados para la Venta");
                return;} */
            Venta v = new Venta()
            {
                Cli = (Cliente)cmbClientes.SelectedItem,
                Ven = (Empleado)cmbVentas.SelectedItem,
                Fecha = dtpFechaVenta.Value,
                Int = (Interes)cmbInteres.SelectedItem,
                ArticulosVendidos = x
            };
            if (!v.validarVenta())
                { MessageBox.Show("Los datos de la venta son incorrectos!!");
                return;}

            new VentaCon().updateVenta(v);

            MessageBox.Show("Venta actualizada con exito");
            limpiarPantalla();
        }

        private void nuevaVenta(object sender, EventArgs e)
        {
            if (x.Count() == 0)
            {
                MessageBox.Show("No hay articulos seleccionados para la Venta");
                return;
            }         
            
            Venta v = new Venta()
            {
                Cli = (Cliente)cmbClientes.SelectedItem,
                Ven = (Empleado)cmbVentas.SelectedItem,
                Fecha = dtpFechaVenta.Value,
                Int = (Interes)cmbInteres.SelectedItem,
                ArticulosVendidos = x
            };

            if (!v.validarVenta())
            {
                MessageBox.Show("Los datos de la venta son incorrectos!!");
                return;
            }

            new VentaCon().insertVenta(v);
            for (int i = 0; i < x.Count(); i++)
                { x[i].Stock -= x[i].CantVendida;
                new ArticuloCon().updateArticulo(x[i]); }

            MessageBox.Show("Venta ingresada con exito");
            limpiarPantalla();
            x = new List<Articulo>();

        }

        private void borrarVenta(object sender, EventArgs e)
        {
          /*  Venta v = new Venta()
            {
                Cli = (Cliente)cmbClientes.SelectedItem,
                Ven = (Empleado)cmbVentas.SelectedItem,
                Fecha = dtpFechaVenta.Value,
                Int = (Interes)cmbInteres.SelectedItem,
                ArticulosVendidos = x
            };
            if (!v.validarVenta())
            {
                MessageBox.Show("Los datos de la venta son incorrectos!!");
                return;
            }  */

            new VentaCon().deleteVenta(aux.IdVenta);
            MessageBox.Show("Venta eliminada con exito");
            limpiarPantalla();
            this.Close();
        }
    }
}
