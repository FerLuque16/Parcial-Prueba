namespace Luque.Fernando
{
    partial class FrmPrincipal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDeLosPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDeLosDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDeLosNoDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionDeCadaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionTotalDelJardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaDeAlumnoToolStripMenuItem,
            this.altaDeAulaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDeDocenteToolStripMenuItem
            // 
            this.altaDeDocenteToolStripMenuItem.Name = "altaDeDocenteToolStripMenuItem";
            this.altaDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeDocenteToolStripMenuItem.Text = "Alta de Docente";
            this.altaDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta no Docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaDeAlumnoToolStripMenuItem
            // 
            this.altaDeAlumnoToolStripMenuItem.Name = "altaDeAlumnoToolStripMenuItem";
            this.altaDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeAlumnoToolStripMenuItem.Text = "Alta de Alumno";
            this.altaDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaDeAlumnoToolStripMenuItem_Click);
            // 
            // altaDeAulaToolStripMenuItem
            // 
            this.altaDeAulaToolStripMenuItem.Name = "altaDeAulaToolStripMenuItem";
            this.altaDeAulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeAulaToolStripMenuItem.Text = "Alta de Aula";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDeLosPadresToolStripMenuItem,
            this.sueldoDeLosDocentesToolStripMenuItem,
            this.sueldoDeLosNoDocentesToolStripMenuItem,
            this.recaudacionDeCadaAulaToolStripMenuItem,
            this.recaudacionTotalDelJardinToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // informacionDeLosPadresToolStripMenuItem
            // 
            this.informacionDeLosPadresToolStripMenuItem.Name = "informacionDeLosPadresToolStripMenuItem";
            this.informacionDeLosPadresToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.informacionDeLosPadresToolStripMenuItem.Text = "Informacion de los padres";
            // 
            // sueldoDeLosDocentesToolStripMenuItem
            // 
            this.sueldoDeLosDocentesToolStripMenuItem.Name = "sueldoDeLosDocentesToolStripMenuItem";
            this.sueldoDeLosDocentesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sueldoDeLosDocentesToolStripMenuItem.Text = "Sueldo de los docentes";
            // 
            // sueldoDeLosNoDocentesToolStripMenuItem
            // 
            this.sueldoDeLosNoDocentesToolStripMenuItem.Name = "sueldoDeLosNoDocentesToolStripMenuItem";
            this.sueldoDeLosNoDocentesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sueldoDeLosNoDocentesToolStripMenuItem.Text = "Sueldo de los no docentes";
            // 
            // recaudacionDeCadaAulaToolStripMenuItem
            // 
            this.recaudacionDeCadaAulaToolStripMenuItem.Name = "recaudacionDeCadaAulaToolStripMenuItem";
            this.recaudacionDeCadaAulaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.recaudacionDeCadaAulaToolStripMenuItem.Text = "Recaudacion por aula";
            // 
            // recaudacionTotalDelJardinToolStripMenuItem
            // 
            this.recaudacionTotalDelJardinToolStripMenuItem.Name = "recaudacionTotalDelJardinToolStripMenuItem";
            this.recaudacionTotalDelJardinToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.recaudacionTotalDelJardinToolStripMenuItem.Text = "Recaudacion total del jardin";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDeLosPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDeLosDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDeLosNoDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionDeCadaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionTotalDelJardinToolStripMenuItem;
    }
}

