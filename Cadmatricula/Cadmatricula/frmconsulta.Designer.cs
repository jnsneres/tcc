namespace Cadmatricula
{
    partial class frmconsulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsulta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgresultado = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconsulta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnome = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnbuscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgresultado)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgresultado);
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgresultado
            // 
            this.dgresultado.AllowUserToAddRows = false;
            this.dgresultado.AllowUserToDeleteRows = false;
            this.dgresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresultado.ContextMenuStrip = this.contextMenuStrip1;
            this.dgresultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgresultado.Location = new System.Drawing.Point(3, 16);
            this.dgresultado.Name = "dgresultado";
            this.dgresultado.ReadOnly = true;
            this.dgresultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgresultado.Size = new System.Drawing.Size(582, 286);
            this.dgresultado.TabIndex = 0;
            this.dgresultado.TabStop = false;
            this.dgresultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgresultado_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar matrícula";
            // 
            // btnconsulta
            // 
            this.btnconsulta.ActiveBorderThickness = 1;
            this.btnconsulta.ActiveCornerRadius = 20;
            this.btnconsulta.ActiveFillColor = System.Drawing.Color.Red;
            this.btnconsulta.ActiveForecolor = System.Drawing.Color.White;
            this.btnconsulta.ActiveLineColor = System.Drawing.Color.Red;
            this.btnconsulta.BackColor = System.Drawing.Color.White;
            this.btnconsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconsulta.BackgroundImage")));
            this.btnconsulta.ButtonText = "Editar matrícula";
            this.btnconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.ForeColor = System.Drawing.Color.Red;
            this.btnconsulta.IdleBorderThickness = 1;
            this.btnconsulta.IdleCornerRadius = 20;
            this.btnconsulta.IdleFillColor = System.Drawing.Color.White;
            this.btnconsulta.IdleForecolor = System.Drawing.Color.Red;
            this.btnconsulta.IdleLineColor = System.Drawing.Color.Red;
            this.btnconsulta.Location = new System.Drawing.Point(18, 548);
            this.btnconsulta.Margin = new System.Windows.Forms.Padding(5);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(582, 52);
            this.btnconsulta.TabIndex = 7;
            this.btnconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnconsulta.Click += new System.EventHandler(this.btncadmat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 152);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.White;
            this.txtnome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtnome.BackgroundImage")));
            this.txtnome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtnome.ForeColor = System.Drawing.Color.Red;
            this.txtnome.Icon = ((System.Drawing.Image)(resources.GetObject("txtnome.Icon")));
            this.txtnome.Location = new System.Drawing.Point(18, 203);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(250, 36);
            this.txtnome.TabIndex = 10;
            this.txtnome.text = "Nome";
            // 
            // btnbuscar
            // 
            this.btnbuscar.ActiveBorderThickness = 1;
            this.btnbuscar.ActiveCornerRadius = 20;
            this.btnbuscar.ActiveFillColor = System.Drawing.Color.Red;
            this.btnbuscar.ActiveForecolor = System.Drawing.Color.Red;
            this.btnbuscar.ActiveLineColor = System.Drawing.Color.Red;
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.ButtonText = "Buscar";
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.IdleBorderThickness = 1;
            this.btnbuscar.IdleCornerRadius = 20;
            this.btnbuscar.IdleFillColor = System.Drawing.Color.White;
            this.btnbuscar.IdleForecolor = System.Drawing.Color.Red;
            this.btnbuscar.IdleLineColor = System.Drawing.Color.Red;
            this.btnbuscar.Location = new System.Drawing.Point(276, 200);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(142, 39);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 635);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnconsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar matrícula";
            this.Load += new System.EventHandler(this.frmconsulta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgresultado)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgresultado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnconsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox txtnome;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbuscar;
    }
}