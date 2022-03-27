
namespace WindowsFormsApp1
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.manProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.manCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.manProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.manClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.regVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.regCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.repVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.repCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.repInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.repProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.repUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.repClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.manProductos,
            this.manCategorias,
            this.manProveedores,
            this.manClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // manProductos
            // 
            this.manProductos.Name = "manProductos";
            this.manProductos.Size = new System.Drawing.Size(180, 22);
            this.manProductos.Text = "Productos";
            // 
            // manCategorias
            // 
            this.manCategorias.Name = "manCategorias";
            this.manCategorias.Size = new System.Drawing.Size(180, 22);
            this.manCategorias.Text = "Categorías";
            // 
            // manProveedores
            // 
            this.manProveedores.Name = "manProveedores";
            this.manProveedores.Size = new System.Drawing.Size(180, 22);
            this.manProveedores.Text = "Proveedores";
            // 
            // manClientes
            // 
            this.manClientes.Name = "manClientes";
            this.manClientes.Size = new System.Drawing.Size(180, 22);
            this.manClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regVentas,
            this.regCompras});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repVentas,
            this.repCompras,
            this.repInventario,
            this.repProveedores,
            this.repUsuarios,
            this.repClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.salirToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(158, 22);
            this.mnuSalir.Text = "Salir del sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // regVentas
            // 
            this.regVentas.Name = "regVentas";
            this.regVentas.Size = new System.Drawing.Size(180, 22);
            this.regVentas.Text = "Registrar Venta";
            // 
            // regCompras
            // 
            this.regCompras.Name = "regCompras";
            this.regCompras.Size = new System.Drawing.Size(180, 22);
            this.regCompras.Text = "Registrar Compra";
            // 
            // repVentas
            // 
            this.repVentas.Name = "repVentas";
            this.repVentas.Size = new System.Drawing.Size(200, 22);
            this.repVentas.Text = "Reporte de Ventas";
            // 
            // repCompras
            // 
            this.repCompras.Name = "repCompras";
            this.repCompras.Size = new System.Drawing.Size(200, 22);
            this.repCompras.Text = "Reporte de Compras";
            // 
            // repInventario
            // 
            this.repInventario.Name = "repInventario";
            this.repInventario.Size = new System.Drawing.Size(200, 22);
            this.repInventario.Text = "Inventario de Productos";
            // 
            // repProveedores
            // 
            this.repProveedores.Name = "repProveedores";
            this.repProveedores.Size = new System.Drawing.Size(200, 22);
            this.repProveedores.Text = "Reporte de Proveedores";
            // 
            // repUsuarios
            // 
            this.repUsuarios.Name = "repUsuarios";
            this.repUsuarios.Size = new System.Drawing.Size(200, 22);
            this.repUsuarios.Text = "Reporte de Usuarios";
            // 
            // repClientes
            // 
            this.repClientes.Name = "repClientes";
            this.repClientes.Size = new System.Drawing.Size(200, 22);
            this.repClientes.Text = "Reporte de Clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem manProductos;
        private System.Windows.Forms.ToolStripMenuItem manCategorias;
        private System.Windows.Forms.ToolStripMenuItem manProveedores;
        private System.Windows.Forms.ToolStripMenuItem manClientes;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regVentas;
        private System.Windows.Forms.ToolStripMenuItem regCompras;
        private System.Windows.Forms.ToolStripMenuItem repVentas;
        private System.Windows.Forms.ToolStripMenuItem repCompras;
        private System.Windows.Forms.ToolStripMenuItem repInventario;
        private System.Windows.Forms.ToolStripMenuItem repProveedores;
        private System.Windows.Forms.ToolStripMenuItem repUsuarios;
        private System.Windows.Forms.ToolStripMenuItem repClientes;
    }
}