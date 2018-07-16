namespace Forms
{
    partial class NuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.chkMasc = new System.Windows.Forms.CheckBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFem = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.chkEmpleado = new System.Windows.Forms.CheckBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCambios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkMasc
            // 
            this.chkMasc.AutoSize = true;
            this.chkMasc.BackColor = System.Drawing.Color.Transparent;
            this.chkMasc.Location = new System.Drawing.Point(47, 187);
            this.chkMasc.Name = "chkMasc";
            this.chkMasc.Size = new System.Drawing.Size(74, 17);
            this.chkMasc.TabIndex = 0;
            this.chkMasc.Text = "Masculino";
            this.chkMasc.UseVisualStyleBackColor = false;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(415, 263);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(176, 21);
            this.cmbEquipo.TabIndex = 1;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(159, 227);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaNac.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Location = new System.Drawing.Point(44, 66);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(130, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(130, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apellido:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(130, 141);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(130, 20);
            this.txtDNI.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(44, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI:";
            // 
            // chkFem
            // 
            this.chkFem.AutoSize = true;
            this.chkFem.BackColor = System.Drawing.Color.Transparent;
            this.chkFem.Location = new System.Drawing.Point(164, 187);
            this.chkFem.Name = "chkFem";
            this.chkFem.Size = new System.Drawing.Size(72, 17);
            this.chkFem.TabIndex = 9;
            this.chkFem.Text = "Femenino";
            this.chkFem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(424, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "----- Empleados -----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(96, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "----- Clientes y Empleados -----";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(415, 224);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(130, 20);
            this.txtSueldo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(345, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sueldo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(345, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Equipo:";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.chkAdministrador.Location = new System.Drawing.Point(348, 316);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(89, 17);
            this.chkAdministrador.TabIndex = 17;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = false;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Transparent;
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.Black;
            this.btnAlta.Location = new System.Drawing.Point(497, 428);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(93, 35);
            this.btnAlta.TabIndex = 18;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.UseWaitCursor = true;
            this.btnAlta.Click += new System.EventHandler(this.altaUsuario);
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.chkEmpleado.Location = new System.Drawing.Point(348, 196);
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.Size = new System.Drawing.Size(73, 17);
            this.chkEmpleado.TabIndex = 19;
            this.chkEmpleado.Text = "Empleado";
            this.chkEmpleado.UseVisualStyleBackColor = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(130, 266);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(130, 20);
            this.txtMail.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(44, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 297);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtTelefono.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(44, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Telefono:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(130, 353);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(130, 20);
            this.txtCalle.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(44, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Calle:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(345, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha Ingreso:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(445, 156);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(85, 20);
            this.dtpFechaIngreso.TabIndex = 26;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(130, 379);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(130, 20);
            this.txtAltura.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(44, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Altura:";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(130, 405);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(130, 20);
            this.txtPiso.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(44, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Piso:";
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(130, 431);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(130, 20);
            this.txtDepto.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(44, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Departamento:";
            // 
            // btnCambios
            // 
            this.btnCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnCambios.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambios.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.ForeColor = System.Drawing.Color.Black;
            this.btnCambios.Location = new System.Drawing.Point(343, 428);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(145, 35);
            this.btnCambios.TabIndex = 34;
            this.btnCambios.Text = "GUARDAR CAMBIOS";
            this.btnCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCambios.UseVisualStyleBackColor = false;
            this.btnCambios.UseWaitCursor = true;
            this.btnCambios.Click += new System.EventHandler(this.guardarCambiosUsuario);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkEmpleado);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.chkAdministrador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFem);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.chkMasc);
            this.Name = "NuevoUsuario";
            this.RightToLeftLayout = true;
            this.Text = "NuevoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMasc;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.CheckBox chkEmpleado;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCambios;
    }
}