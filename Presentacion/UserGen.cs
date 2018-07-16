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
    public partial class UserGen : Form
    {
        private Users u;
        private bool cambio;
        public UserGen()
        {
            InitializeComponent();
            cmbEmpleado.DataSource = new EmpleadoCon().listar();
            cambio = false;
        }

        public UserGen(Users u)
            { InitializeComponent();
            txtUser.Text = u.Nombre;
            txtPw.Text = u.Pw;
            cmbEmpleado.DataSource = new EmpleadoCon().listar();
            Empleado e = new EmpleadoCon().getEmpleadoById(u.DNI);
            cmbEmpleado.SelectedItem = e;
            cambio = true;
        }

        private void cargarAcceso()
            { cmbAcceso.DataSource = new List<string>() { "EMPLEADO", "EXTENDIDO", "ADMINISTRADOR" }; }

        public void guardar(object sender, EventArgs e)
            { if (txtPw.Text.Trim() == "" || txtUser.Text.Trim() == "")
                { MessageBox.Show("Completelos campos");
                return;
            }
            if (txtUser.Text.ToString() == u.Nombre && txtPw.Text.ToString() == u.Pw)
                { MessageBox.Show("No realizo cambios");
                return;
            }
            int a;
            if (cmbAcceso.SelectedItem.Equals("EMPLEADO"))
            { a = 1; }
            else
                { if (cmbAcceso.SelectedItem.Equals("ADMINISTRADOR")) { a = 3; }
                else { a = 2; } }
            if (cambio)
            {
                string n = u.Nombre;
                Users x = new Users()
                {
                    Nombre = txtUser.Text.ToString(),
                    Pw = txtPw.Text.ToString(),
                    DNI = ((Empleado)cmbEmpleado.SelectedItem).DNI,
                    Acceso = a
                };
                new UsersCon().updateUsuario(x, n);
            }
            else
            {
                Users x = new Users()
                {
                    Nombre = txtUser.Text.ToString(),
                    Pw = txtPw.Text.ToString(),
                    DNI = ((Empleado)cmbEmpleado.SelectedItem).DNI,
                    Acceso = a
                };
                new UsersCon().insertUsuario(x);
            }
        }
    }
}
