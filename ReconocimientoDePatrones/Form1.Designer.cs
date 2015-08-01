namespace ReconocimientoDePatrones
{
    partial class frmPrrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónAutomaticaDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.clasificarToolStripMenuItem,
            this.gráficaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem});
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.generarToolStripMenuItem.Text = "Archivo";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem1
            // 
            this.generarToolStripMenuItem1.Name = "generarToolStripMenuItem1";
            this.generarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.generarToolStripMenuItem1.Text = "Generar";
            this.generarToolStripMenuItem1.Click += new System.EventHandler(this.generarToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // clasificarToolStripMenuItem
            // 
            this.clasificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generaciónAutomaticaDeClasesToolStripMenuItem,
            this.definirClasesToolStripMenuItem});
            this.clasificarToolStripMenuItem.Enabled = false;
            this.clasificarToolStripMenuItem.Name = "clasificarToolStripMenuItem";
            this.clasificarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.clasificarToolStripMenuItem.Text = "Clasificar";
            this.clasificarToolStripMenuItem.Click += new System.EventHandler(this.clasificarToolStripMenuItem_Click);
            // 
            // generaciónAutomaticaDeClasesToolStripMenuItem
            // 
            this.generaciónAutomaticaDeClasesToolStripMenuItem.Name = "generaciónAutomaticaDeClasesToolStripMenuItem";
            this.generaciónAutomaticaDeClasesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.generaciónAutomaticaDeClasesToolStripMenuItem.Text = "Generación Automatica de clases";
            this.generaciónAutomaticaDeClasesToolStripMenuItem.Click += new System.EventHandler(this.generaciónAutomaticaDeClasesToolStripMenuItem_Click);
            // 
            // definirClasesToolStripMenuItem
            // 
            this.definirClasesToolStripMenuItem.Name = "definirClasesToolStripMenuItem";
            this.definirClasesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.definirClasesToolStripMenuItem.Text = "Definir Clases";
            this.definirClasesToolStripMenuItem.Click += new System.EventHandler(this.definirClasesToolStripMenuItem_Click);
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.Enabled = false;
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.gráficaToolStripMenuItem.Text = "Gráfica";
            this.gráficaToolStripMenuItem.Click += new System.EventHandler(this.gráficaToolStripMenuItem_Click);
            // 
            // frmPrrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrrincipal";
            this.Text = "Reconocimiento de Patrones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónAutomaticaDeClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;

    }
}

