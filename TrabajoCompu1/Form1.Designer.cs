namespace TrabajoCompu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarDeudasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarDeudasPorInserciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarDeudasPorShellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.generarDeudasBancariasManualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearciónToolStripMenuItem,
            this.ordenamientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearciónToolStripMenuItem
            // 
            this.crearciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarDeudasBancariasToolStripMenuItem,
            this.generarDeudasBancariasManualmenteToolStripMenuItem});
            this.crearciónToolStripMenuItem.Name = "crearciónToolStripMenuItem";
            this.crearciónToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.crearciónToolStripMenuItem.Text = "Creación";
            // 
            // generarDeudasBancariasToolStripMenuItem
            // 
            this.generarDeudasBancariasToolStripMenuItem.Name = "generarDeudasBancariasToolStripMenuItem";
            this.generarDeudasBancariasToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.generarDeudasBancariasToolStripMenuItem.Text = "Generar Deudas Bancarias Aleatorias";
            this.generarDeudasBancariasToolStripMenuItem.Click += new System.EventHandler(this.generarDeudasBancariasToolStripMenuItem_Click);
            // 
            // ordenamientosToolStripMenuItem
            // 
            this.ordenamientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarDeudasPorInserciónToolStripMenuItem,
            this.ordenarDeudasPorShellSortToolStripMenuItem,
            this.promedioDeudasToolStripMenuItem});
            this.ordenamientosToolStripMenuItem.Name = "ordenamientosToolStripMenuItem";
            this.ordenamientosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ordenamientosToolStripMenuItem.Text = "Ordenamientos";
            // 
            // ordenarDeudasPorInserciónToolStripMenuItem
            // 
            this.ordenarDeudasPorInserciónToolStripMenuItem.Name = "ordenarDeudasPorInserciónToolStripMenuItem";
            this.ordenarDeudasPorInserciónToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ordenarDeudasPorInserciónToolStripMenuItem.Text = "Ordenar Deudas por Inserción";
            this.ordenarDeudasPorInserciónToolStripMenuItem.Click += new System.EventHandler(this.ordenarDeudasPorInserciónToolStripMenuItem_Click);
            // 
            // ordenarDeudasPorShellSortToolStripMenuItem
            // 
            this.ordenarDeudasPorShellSortToolStripMenuItem.Name = "ordenarDeudasPorShellSortToolStripMenuItem";
            this.ordenarDeudasPorShellSortToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ordenarDeudasPorShellSortToolStripMenuItem.Text = "Ordenar Deudas por Shellsort";
            this.ordenarDeudasPorShellSortToolStripMenuItem.Click += new System.EventHandler(this.ordenarDeudasPorShellSortToolStripMenuItem_Click);
            // 
            // promedioDeudasToolStripMenuItem
            // 
            this.promedioDeudasToolStripMenuItem.Name = "promedioDeudasToolStripMenuItem";
            this.promedioDeudasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.promedioDeudasToolStripMenuItem.Text = "Promedio Deudas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(203, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // generarDeudasBancariasManualmenteToolStripMenuItem
            // 
            this.generarDeudasBancariasManualmenteToolStripMenuItem.Name = "generarDeudasBancariasManualmenteToolStripMenuItem";
            this.generarDeudasBancariasManualmenteToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.generarDeudasBancariasManualmenteToolStripMenuItem.Text = "Generar Deudas Bancarias Manualmente";
            this.generarDeudasBancariasManualmenteToolStripMenuItem.Click += new System.EventHandler(this.generarDeudasBancariasManualmenteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 384);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarDeudasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenamientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarDeudasPorInserciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarDeudasPorShellSortToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem promedioDeudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarDeudasBancariasManualmenteToolStripMenuItem;
    }
}

