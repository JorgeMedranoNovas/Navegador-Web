namespace navegador_wed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnretroseder = new System.Windows.Forms.ToolStripButton();
            this.btnAdelante = new System.Windows.Forms.ToolStripButton();
            this.btnrepetir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btncasa = new System.Windows.Forms.ToolStripButton();
            this.TBbuscador = new System.Windows.Forms.ToolStripTextBox();
            this.btngo = new System.Windows.Forms.ToolStripButton();
            this.cmdFavoritos = new System.Windows.Forms.ToolStripComboBox();
            this.btnFavoritos = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnretroseder,
            this.btnAdelante,
            this.btnrepetir,
            this.toolStripButton1,
            this.btncasa,
            this.TBbuscador,
            this.btngo,
            this.cmdFavoritos,
            this.btnFavoritos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnretroseder
            // 
            this.btnretroseder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnretroseder.Image = ((System.Drawing.Image)(resources.GetObject("btnretroseder.Image")));
            this.btnretroseder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnretroseder.Name = "btnretroseder";
            this.btnretroseder.Size = new System.Drawing.Size(23, 22);
            this.btnretroseder.Text = "toolStripButton1";
            this.btnretroseder.Click += new System.EventHandler(this.btnretroseder_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdelante.Image = ((System.Drawing.Image)(resources.GetObject("btnAdelante.Image")));
            this.btnAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(23, 22);
            this.btnAdelante.Text = "toolStripButton1";
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnrepetir
            // 
            this.btnrepetir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrepetir.Image = ((System.Drawing.Image)(resources.GetObject("btnrepetir.Image")));
            this.btnrepetir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrepetir.Name = "btnrepetir";
            this.btnrepetir.Size = new System.Drawing.Size(23, 22);
            this.btnrepetir.Text = "toolStripButton2";
            this.btnrepetir.Click += new System.EventHandler(this.btnrepetir_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btncasa
            // 
            this.btncasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncasa.Image = ((System.Drawing.Image)(resources.GetObject("btncasa.Image")));
            this.btncasa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncasa.Name = "btncasa";
            this.btncasa.Size = new System.Drawing.Size(23, 22);
            this.btncasa.Text = "toolStripButton3";
            this.btncasa.Click += new System.EventHandler(this.btncasa_Click);
            // 
            // TBbuscador
            // 
            this.TBbuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBbuscador.Name = "TBbuscador";
            this.TBbuscador.Size = new System.Drawing.Size(600, 25);
            this.TBbuscador.Click += new System.EventHandler(this.TBbuscador_Click);
            // 
            // btngo
            // 
            this.btngo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btngo.Image = ((System.Drawing.Image)(resources.GetObject("btngo.Image")));
            this.btngo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(23, 22);
            this.btngo.Text = "toolStripButton2";
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // cmdFavoritos
            // 
            this.cmdFavoritos.Name = "cmdFavoritos";
            this.cmdFavoritos.Size = new System.Drawing.Size(121, 25);
            this.cmdFavoritos.SelectedIndexChanged += new System.EventHandler(this.cmdFavoritos_SelectedIndexChanged);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavoritos.Image = ((System.Drawing.Image)(resources.GetObject("btnFavoritos.Image")));
            this.btnFavoritos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(23, 22);
            this.btnFavoritos.Text = "toolStripButton2";
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(959, 425);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnretroseder;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton btnAdelante;
        private System.Windows.Forms.ToolStripButton btnrepetir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btncasa;
        private System.Windows.Forms.ToolStripTextBox TBbuscador;
        private System.Windows.Forms.ToolStripButton btngo;
        private System.Windows.Forms.ToolStripComboBox cmdFavoritos;
        private System.Windows.Forms.ToolStripButton btnFavoritos;
    }
}

