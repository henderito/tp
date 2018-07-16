namespace Forms
{
    partial class GenerarDatosMaestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarDatosMaestros));
            this.txtTipoIncidenciaNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoSubtipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioArt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTipoGrupo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbGrupoSubtipo = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTipoIncidenciaNombre
            // 
            this.txtTipoIncidenciaNombre.Location = new System.Drawing.Point(175, 51);
            this.txtTipoIncidenciaNombre.Name = "txtTipoIncidenciaNombre";
            this.txtTipoIncidenciaNombre.Size = new System.Drawing.Size(241, 20);
            this.txtTipoIncidenciaNombre.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(440, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "AGREGAR TIPO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.agregarTipo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Tipo de Incidencia:";
            // 
            // cmbTipoSubtipo
            // 
            this.cmbTipoSubtipo.FormattingEnabled = true;
            this.cmbTipoSubtipo.Location = new System.Drawing.Point(177, 270);
            this.cmbTipoSubtipo.Name = "cmbTipoSubtipo";
            this.cmbTipoSubtipo.Size = new System.Drawing.Size(243, 21);
            this.cmbTipoSubtipo.TabIndex = 4;
            this.cmbTipoSubtipo.SelectedIndexChanged += new System.EventHandler(this.tipoIncidChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo Subtipo de Incidencia:";
            // 
            // txtSubTipo
            // 
            this.txtSubTipo.Location = new System.Drawing.Point(177, 324);
            this.txtSubTipo.Name = "txtSubTipo";
            this.txtSubTipo.Size = new System.Drawing.Size(245, 20);
            this.txtSubTipo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(47, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Incidencia:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(440, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "AGREGAR SUBTIPO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.agregarSubTipo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(172, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "----Nuevo Articulo----";
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(96, 428);
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(241, 20);
            this.txtNombreArt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(21, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(438, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "AGREGAR ARTICULO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.agregarArticulo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(21, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio:";
            // 
            // txtPrecioArt
            // 
            this.txtPrecioArt.Location = new System.Drawing.Point(96, 464);
            this.txtPrecioArt.Name = "txtPrecioArt";
            this.txtPrecioArt.Size = new System.Drawing.Size(108, 20);
            this.txtPrecioArt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(142, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "----Nuevo Subtipo de Incidente ----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(142, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "----Nuevo Tipo de Incidente ----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(142, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "----Nuevo Grupo de Incidente ----";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(440, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "AGREGAR GRUPO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.agregarGrupo);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(47, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipo de Incidencia:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(177, 174);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(243, 20);
            this.txtGrupo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(25, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nuevo Grupo de Incidencia:";
            // 
            // cmbTipoGrupo
            // 
            this.cmbTipoGrupo.FormattingEnabled = true;
            this.cmbTipoGrupo.Location = new System.Drawing.Point(177, 147);
            this.cmbTipoGrupo.Name = "cmbTipoGrupo";
            this.cmbTipoGrupo.Size = new System.Drawing.Size(243, 21);
            this.cmbTipoGrupo.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(47, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Grupo de Incidencia:";
            // 
            // cmbGrupoSubtipo
            // 
            this.cmbGrupoSubtipo.FormattingEnabled = true;
            this.cmbGrupoSubtipo.Location = new System.Drawing.Point(177, 297);
            this.cmbGrupoSubtipo.Name = "cmbGrupoSubtipo";
            this.cmbGrupoSubtipo.Size = new System.Drawing.Size(243, 21);
            this.cmbGrupoSubtipo.TabIndex = 27;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(96, 495);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(108, 20);
            this.txtStock.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(21, 498);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Stock:";
            // 
            // GenerarDatosMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 534);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbGrupoSubtipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTipoGrupo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioArt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNombreArt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoSubtipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTipoIncidenciaNombre);
            this.Name = "GenerarDatosMaestros";
            this.Text = "Generar Datos Maestros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipoIncidenciaNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoSubtipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTipoGrupo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbGrupoSubtipo;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label16;
    }
}