namespace Forms
{
    partial class NuevoIncidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoIncidente));
            this.btnAlta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPrioridad = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbVenta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.chkCerrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Transparent;
            this.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.Black;
            this.btnAlta.Location = new System.Drawing.Point(638, 307);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 44);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.altaIncidente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(79, 35);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(249, 21);
            this.cmbCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(334, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "El incidente se creara con el Estado de \"Abierto\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(334, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Si desea cambiar la prioridad, solicite a su Administrador que realize esta accio" +
    "n";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(79, 81);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(249, 21);
            this.cmbEmpleado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Empleado:";
            // 
            // chkPrioridad
            // 
            this.chkPrioridad.AutoSize = true;
            this.chkPrioridad.BackColor = System.Drawing.Color.Transparent;
            this.chkPrioridad.Location = new System.Drawing.Point(625, 153);
            this.chkPrioridad.Name = "chkPrioridad";
            this.chkPrioridad.Size = new System.Drawing.Size(88, 17);
            this.chkPrioridad.TabIndex = 7;
            this.chkPrioridad.Text = "Prioridad Alta";
            this.chkPrioridad.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(145, 114);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "----Incidencia----";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(79, 149);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(277, 21);
            this.cmbTipo.TabIndex = 10;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.updateCBGrupo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo:";
            // 
            // cmbSubTipo
            // 
            this.cmbSubTipo.FormattingEnabled = true;
            this.cmbSubTipo.Location = new System.Drawing.Point(79, 214);
            this.cmbSubTipo.Name = "cmbSubTipo";
            this.cmbSubTipo.Size = new System.Drawing.Size(277, 21);
            this.cmbSubTipo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Subtipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 252);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 283);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(341, 20);
            this.txtDescripcion.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(203, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Máximo de caractéres: 50";
            // 
            // cmbVenta
            // 
            this.cmbVenta.FormattingEnabled = true;
            this.cmbVenta.Location = new System.Drawing.Point(423, 224);
            this.cmbVenta.Name = "cmbVenta";
            this.cmbVenta.Size = new System.Drawing.Size(277, 21);
            this.cmbVenta.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(519, 198);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Venta Relacionada:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(79, 180);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(277, 21);
            this.cmbGrupo.TabIndex = 20;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.updateCBSubtipo);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(12, 185);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Grupo:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(496, 307);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 44);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "MODIFICACION";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.modificarIncidente);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(177, 331);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(137, 20);
            this.dtpFecha.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(76, 337);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Fecha:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(410, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(473, 151);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(89, 20);
            this.txtEstado.TabIndex = 25;
            // 
            // chkCerrar
            // 
            this.chkCerrar.AutoSize = true;
            this.chkCerrar.BackColor = System.Drawing.Color.Transparent;
            this.chkCerrar.Location = new System.Drawing.Point(519, 265);
            this.chkCerrar.Name = "chkCerrar";
            this.chkCerrar.Size = new System.Drawing.Size(85, 17);
            this.chkCerrar.TabIndex = 26;
            this.chkCerrar.Text = "Solucionado";
            this.chkCerrar.UseVisualStyleBackColor = false;
            // 
            // NuevoIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 377);
            this.Controls.Add(this.chkCerrar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSubTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkPrioridad);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlta);
            this.Name = "NuevoIncidente";
            this.Text = "NuevoIncidente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPrioridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSubTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.CheckBox chkCerrar;
    }
}