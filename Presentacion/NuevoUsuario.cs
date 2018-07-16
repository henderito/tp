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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
            btnAlta.Visible = true;
            btnCambios.Visible = false;
            cmbEquipo.DataSource = new EquipoCon().listar();
        }

        public NuevoUsuario(Persona p)
        {
            InitializeComponent();
            cargarUsuario(p);
            btnAlta.Visible = false;
            btnCambios.Visible = true;
            cmbEquipo.DataSource = new EquipoCon().listar();
        }

        private void clearFields()
            { txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            chkMasc.Checked = false;
            chkFem.Checked = false;
            dtpFechaNac.Value = DateTime.Today;
            txtCalle.Text = "";
            txtAltura.Text = "";
            txtPiso.Text = "";
            txtDepto.Text = "";
            dtpFechaIngreso.Value = DateTime.Today;
            txtSueldo.Text = "";
            chkAdministrador.Checked = false;}

        private void invalidateEmpleado()
            {dtpFechaIngreso.Enabled = false;
             chkEmpleado.Enabled = false;
             txtSueldo.Enabled = false;
             cmbEquipo.Enabled = false;
             chkAdministrador.Enabled = false;
        }

        private void altaUsuario(object sender, EventArgs ea)
            {if (!chkMasc.Checked && !chkFem.Checked)
                { MessageBox.Show("Debe seleccionar un sexo");
                return;
            }
            int x;
            int.TryParse(txtSueldo.Text, out x);
            if (chkEmpleado.Checked)
            {
                Empleado e = new Empleado()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Sexo = (chkMasc.Checked) ? "M" : "F",
                    FechaNac = dtpFechaNac.Value.Date,
                    Mail = txtMail.Text,
                    Telefono = txtTelefono.Text,
                    Dom = new Domicilio()
                    {
                        Calle = txtCalle.Text,
                        Altura = txtAltura.Text,
                        Piso = txtPiso.Text,
                        Departamento = txtDepto.Text
                    },
                    FechaIngreso = dtpFechaIngreso.Value.Date,
                    Sueldo = x,
                    Equipo = ((Equipo)cmbEquipo.SelectedItem).id
                };
                if (!e.validarEmpleado())
                { return; }
                else
                { try
                    { new EmpleadoCon().insertEmpleado(e);
                        new DomicilioCon().insertDomicilioEmpleado(e.DNI, e.Dom);
                        new MailCon().insertMailEmpleado(e.DNI, e.Mail);
                        new TelefonoCon().insertTelefonoEmpleado(e.DNI, e.Telefono, "");
                        if (chkAdministrador.Checked)
                        { new AdministradorCon().insertAdministrador(e.DNI); }
                        MessageBox.Show("Usuario dado de alta efectivamente!");
                    }
                    catch  { }
                }
                
            }
            else
            {
                Cliente c = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Sexo = (chkMasc.Checked) ? "M" : "F",
                    FechaNac = dtpFechaNac.Value.Date,
                    Mail = txtMail.Text,
                    Telefono = txtTelefono.Text,
                    Dom = new Domicilio()
                    {
                        Calle = txtCalle.Text,
                        Altura = txtAltura.Text,
                        Piso = txtPiso.Text,
                        Departamento = txtDepto.Text
                    }
                };
                if (!c.validarCliente())
                {
                   return; }
                else
                    { try
                    {
                        new ClienteCon().insertCliente(c);
                        new DomicilioCon().insertDomicilioCliente(c.DNI, c.Dom);
                        new MailCon().insertMailClientes(c.DNI, c.Mail);
                        new TelefonoCon().insertTelefonoClientes(c.DNI, c.Telefono, "");
                        MessageBox.Show("Usuario dado de alta efectivamente!");
                    }
                    catch { }
                }
            }
            clearFields();            
            return;
        }

        private void cargarUsuario(Persona p)
            { txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            txtDNI.Text = p.DNI;
            if (p.Sexo.Equals("M"))
                { chkMasc.Checked = true; }
            else
                { chkFem.Checked = true; }
            dtpFechaNac.Value = p.FechaNac;
            txtMail.Text = p.Mail;
            txtTelefono.Text = p.Telefono;
            txtCalle.Text = p.Dom.Calle;
            txtAltura.Text = p.Dom.Altura;
            txtPiso.Text = p.Dom.Piso;
            txtDepto.Text = p.Dom.Departamento;
            if (p is Empleado)
            {
                chkEmpleado.Checked = true;
                dtpFechaIngreso.Value = ((Empleado)p).FechaIngreso;
                txtSueldo.Text = ((Empleado)p).Sueldo.ToString();
                cmbEquipo.SelectedItem = ((Empleado)p).Equipo;
            }
            else { invalidateEmpleado(); }          
            if (p is Administrador)
                { chkAdministrador.Checked = true; }
        }

        private void guardarCambiosUsuario(object sender, EventArgs ea)
            {int x;
            int.TryParse(txtSueldo.Text, out x);
            if (chkEmpleado.Checked)
            {
                Empleado e = new Empleado()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Sexo = (chkMasc.Checked) ? "M" : "F",
                    FechaNac = dtpFechaNac.Value.Date,
                    Mail = txtMail.Text,
                    Telefono = txtTelefono.Text,
                    Dom = new Domicilio()
                    {
                        Calle = txtCalle.Text,
                        Altura = txtAltura.Text,
                        Piso = txtPiso.Text,
                        Departamento = txtDepto.Text
                    },
                    FechaIngreso = dtpFechaIngreso.Value.Date,
                    Sueldo = x,
                    Equipo = ((Equipo)cmbEquipo.SelectedItem).id
                };
                if (!e.validarEmpleado())
                { return; }
                else
                {
                    try
                    {
                        new EmpleadoCon().updateEmpleado(e);
                        new DomicilioCon().updateDomicilioEmpleado(e.Dom, e.DNI);
                        new MailCon().updateMailEmpleado(e.Mail, e.DNI);
                        new TelefonoCon().updateTelefonoEmpleado(e.Telefono, e.DNI, "");
                        MessageBox.Show("Usuario modificado efectivamente!");
                    }
                    catch (Exception ex){ throw ex; }
                }
            }
            else
            {
                Cliente c = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Sexo = (chkMasc.Checked) ? "M" : "F",
                    FechaNac = dtpFechaNac.Value.Date,
                    Mail = txtMail.Text,
                    Telefono = txtTelefono.Text,
                    Dom = new Domicilio()
                    {
                        Calle = txtCalle.Text,
                        Altura = txtAltura.Text,
                        Piso = txtPiso.Text,
                        Departamento = txtDepto.Text
                    }
                };
                if (!c.validarCliente())
                { return; }
                else
                { try
                    {
                        new ClienteCon().updateCliente(c);
                        new DomicilioCon().updateDomicilioCliente(c.Dom, c.DNI);
                        new MailCon().updateMailClientes(c.Mail, c.DNI);
                        new TelefonoCon().updateTelefonoClientes(c.Telefono, c.DNI, "");
                        MessageBox.Show("Usuario modificado efectivamente!");
                    }
                    catch { }
                }
            }
            clearFields();
            this.Close();
        }        
    }
}
