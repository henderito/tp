namespace Forms
{
    partial class FormControlGeneral
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlGeneral));
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.lblBien = new System.Windows.Forms.Label();
            this.menuReporte = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaEspecificoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(12, 165);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(155, 41);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.ventas);
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.BackColor = System.Drawing.Color.Transparent;
            this.btnIncidencias.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnIncidencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnIncidencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidencias.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidencias.ForeColor = System.Drawing.Color.Black;
            this.btnIncidencias.Location = new System.Drawing.Point(12, 101);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(155, 43);
            this.btnIncidencias.TabIndex = 1;
            this.btnIncidencias.Text = "INCIDENCIAS";
            this.btnIncidencias.UseVisualStyleBackColor = false;
            this.btnIncidencias.Click += new System.EventHandler(this.incid);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 45);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(155, 35);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.users);
            // 
            // btnDM
            // 
            this.btnDM.BackColor = System.Drawing.Color.Transparent;
            this.btnDM.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnDM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDM.ForeColor = System.Drawing.Color.Black;
            this.btnDM.Location = new System.Drawing.Point(12, 229);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(155, 40);
            this.btnDM.TabIndex = 3;
            this.btnDM.Text = "DATOS MAESTROS";
            this.btnDM.UseVisualStyleBackColor = false;
            this.btnDM.Click += new System.EventHandler(this.datosM);
            // 
            // lblBien
            // 
            this.lblBien.AutoSize = true;
            this.lblBien.BackColor = System.Drawing.Color.Transparent;
            this.lblBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBien.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBien.ForeColor = System.Drawing.Color.Black;
            this.lblBien.Location = new System.Drawing.Point(266, 140);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(76, 19);
            this.lblBien.TabIndex = 4;
            this.lblBien.Text = "Bienvenido!!";
            // 
            // menuReporte
            // 
            this.menuReporte.Name = "menuReporte";
            this.menuReporte.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.incidenciasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventaTotal);
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diaEspecificoToolStripMenuItem,
            this.hoyToolStripMenuItem,
            this.totalToolStripMenuItem});
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.incidenciasToolStripMenuItem.Text = "Incidencias";
            // 
            // diaEspecificoToolStripMenuItem
            // 
            this.diaEspecificoToolStripMenuItem.Name = "diaEspecificoToolStripMenuItem";
            this.diaEspecificoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.diaEspecificoToolStripMenuItem.Text = "Dia Especifico";
            this.diaEspecificoToolStripMenuItem.Click += new System.EventHandler(this.incidenciaEspecifico);
            // 
            // hoyToolStripMenuItem
            // 
            this.hoyToolStripMenuItem.Name = "hoyToolStripMenuItem";
            this.hoyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.hoyToolStripMenuItem.Text = "Hoy";
            this.hoyToolStripMenuItem.Click += new System.EventHandler(this.incidenciaResumenDia);
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.incidenciaTotal);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.usuariosToolStripMenuItem.Text = "Perfiles";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuario);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuario);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.actualizarUsuario);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // FormControlGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblBien);
            this.Controls.Add(this.btnDM);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnIncidencias);
            this.Controls.Add(this.btnVentas);
            this.Name = "FormControlGeneral";
            this.Text = "Panel General";
            this.Load += new System.EventHandler(this.FormControlGeneral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.ContextMenuStrip menuReporte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaEspecificoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}

