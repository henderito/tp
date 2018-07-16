using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Windows.Forms;
using Dominio;


//fernando_calabuig@crgl-thirdparty.com

namespace Forms
{
    public partial class FormControlGeneral : Form
    {
        private static Users uLog;
        private static DateTime reportDay;

        public FormControlGeneral() { InitializeComponent(); }
        
        public static void setReportDay(DateTime d) { reportDay = d; }
        public static DateTime getReportDay() { return reportDay; }    
        public static void setUser(Users u) { uLog = u; }
        public static Users getUser() { return uLog;}

        private bool modOrNuevo()
            { if (MessageBox.Show("Desea modificar datos existentes?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { return true; }
            return false;
        }

        private void nuevoUsuario()
            {NuevoUsuario aU = new NuevoUsuario();
             this.Hide();
             aU.ShowDialog();
             this.Show();
        }

        private void nuevoIncidente()
            { NuevoIncidente nI = new NuevoIncidente();
            this.Hide();
              nI.ShowDialog();
            this.Show();
        }

        private void nuevaVenta()
            { NuevaVenta nV = new NuevaVenta();
            this.Hide();
            nV.ShowDialog();
            this.Show();
        }

        private void generarDatosMaestros()
            { GenerarDatosMaestros gDM = new GenerarDatosMaestros();
            this.Hide();
              gDM.ShowDialog();
            this.Show();
        }

        private void modificarDatosMaestros()
            { ManipularDatosMaestros mDm = new ManipularDatosMaestros();
            this.Hide();
            mDm.ShowDialog();
            this.Show();
        }

        private void ventasGeneral()
            { PreABM p = new PreABM("Ventas");
            p.Text = "Ventas";
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void incidenciasGeneral()
            {
            PreABM p = new PreABM("Incidentes");
            p.Text = "Incidentes";
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void clientesGeneral()
            {
            PreABM p = new PreABM("Clientes");
            p.Text = "Clientes";
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void empleadosGeneral()
            {
            PreABM p = new PreABM("Empleados");
            p.Text = "Empleados";
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void users(object sender, EventArgs e)
            {if (!modOrNuevo())
                { nuevoUsuario(); }
            else
                {if (MessageBox.Show("Desea modificar los datos de un cliente?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    { clientesGeneral(); }
                else
                    { empleadosGeneral(); }
                     } }

        private void incid(object sender, EventArgs e)
            {if (!modOrNuevo())
                { nuevoIncidente(); }
            else
                { incidenciasGeneral(); }
        }

        private void ventas(object sender, EventArgs e)
            {if (!modOrNuevo())
                { nuevaVenta(); }
            else
                { ventasGeneral(); }
        }

        private void datosM(object sender, EventArgs e)
            {if (uLog.Acceso == 1)
                { MessageBox.Show("Su perfil no tiene los permisos necesarios para acceder a esta funcion");
                return;
            }
            if (!modOrNuevo())
                { generarDatosMaestros(); }
            else
                { modificarDatosMaestros(); }
        }

        private void FormControlGeneral_Load(object sender, EventArgs e)
        {
            new Login().ShowDialog();
            lblBien.Text = "Bienvenido " + uLog.Nombre;
        }

        private void resumenVentaDia(object sender, EventArgs e)
        {
            //List<Venta> v = new VentaCon().ventasPorDia(DateTime.Today.Date);
            List<Venta> v = new VentaCon().listar();
            for (int i = 0; i < v.Count(); i++)
                {if (!((v[i].Fecha.Equals(DateTime.Today.Date)) ))
                    { v.Remove(v[i]); } }
            this.Hide();
            new Reporte(v).ShowDialog();
            this.Show();
        }

        private void ventaDiaEspecifico(object sender, EventArgs e)
        {
            new DateSelector().ShowDialog();

            List<Venta> v = new VentaCon().ventasPorDia(reportDay);
            if (v is null)
                { MessageBox.Show("Selecciono un dia sin ventas para mostrar, intente de nuevo");
                return;
            }
            this.Hide();
            new Reporte(v).ShowDialog();
            this.Show();
        }

        private void ventaTotal(object sender, EventArgs e)
        {
            List<Venta> v = new VentaCon().listar();
            this.Hide();
            new Reporte(v).ShowDialog();
            this.Show();
        }

        private void incidenciaResumenDia(object sender, EventArgs e)
        {
            List<Incidencia> i = new IncidenciaCon().incidenciaPorDia(DateTime.Today);
            if (i is null)
            {
                MessageBox.Show("Selecciono un dia sin incidencias para mostrar, intente de nuevo");
                return;
            }
            this.Hide();
            new Reporte(i).ShowDialog();
            this.Show();
        }

        private void incidenciaEspecifico(object sender, EventArgs e)
        {
            new DateSelector().ShowDialog();

            List<Incidencia> i = new IncidenciaCon().incidenciaPorDia(reportDay);
            if (i is null)
            {
                MessageBox.Show("Selecciono un dia sin incidencias para mostrar, intente de nuevo");
                return;
            }
            this.Hide();
            new Reporte(i).ShowDialog();
            this.Show();
        }

        private void incidenciaTotal(object sender, EventArgs e)
        {
            List<Incidencia> i = new IncidenciaCon().listar();
            this.Hide();
            new Reporte(i).ShowDialog();
            this.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControlGeneral_Load(sender, e);
        }

        private void nuevoUsuario(object sender, EventArgs e)
        {

        }

        private void eliminarUsuario(object sender, EventArgs e)
        {

        }

        private void actualizarUsuario(object sender, EventArgs e)
        {

        }
    }
}
