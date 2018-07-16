namespace Forms
{
    partial class NuevaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaVenta));
            this.btnSacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbVentas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cmbInteres = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(552, 32);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(35, 23);
            this.btnSacar.TabIndex = 1;
            this.btnSacar.Text = "<";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.delArt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(69, 29);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 3;
            // 
            // cmbVentas
            // 
            this.cmbVentas.FormattingEnabled = true;
            this.cmbVentas.Location = new System.Drawing.Point(69, 78);
            this.cmbVentas.Name = "cmbVentas";
            this.cmbVentas.Size = new System.Drawing.Size(121, 21);
            this.cmbVentas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vendedor:";
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(302, 54);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(212, 21);
            this.cmbArticulos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(379, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "----Articulos----";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(552, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.addArt);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevaVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaVenta.Location = new System.Drawing.Point(762, 180);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(130, 23);
            this.btnNuevaVenta.TabIndex = 9;
            this.btnNuevaVenta.Text = "NUEVA VENTA";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.nuevaVenta);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.Location = new System.Drawing.Point(361, 131);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(67, 13);
            this.lblCosto.TabIndex = 11;
            this.lblCosto.Text = "Costo Total: ";
            // 
            // cmbInteres
            // 
            this.cmbInteres.FormattingEnabled = true;
            this.cmbInteres.Location = new System.Drawing.Point(156, 128);
            this.cmbInteres.Name = "cmbInteres";
            this.cmbInteres.Size = new System.Drawing.Size(161, 21);
            this.cmbInteres.TabIndex = 13;
            this.cmbInteres.SelectedIndexChanged += new System.EventHandler(this.updateCosto);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Interes sobre la venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de Venta:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(156, 185);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaVenta.TabIndex = 16;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(473, 93);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(40, 20);
            this.txtCant.TabIndex = 17;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.Transparent;
            this.lblCant.Location = new System.Drawing.Point(415, 96);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(52, 13);
            this.lblCant.TabIndex = 18;
            this.lblCant.Text = "Cantidad:";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(617, 33);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(339, 116);
            this.dgvArticulos.TabIndex = 19;
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnEliminarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarVenta.Location = new System.Drawing.Point(364, 180);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(130, 23);
            this.btnEliminarVenta.TabIndex = 20;
            this.btnEliminarVenta.Text = "ELIMINAR VENTA";
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.borrarVenta);
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 230);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbInteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbArticulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacar);
            this.Name = "NuevaVenta";
            this.Text = "NuevaVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cmbInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnEliminarVenta;
    }
}