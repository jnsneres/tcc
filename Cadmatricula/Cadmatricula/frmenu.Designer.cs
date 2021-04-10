namespace Cadmatricula
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblhora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncadmat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnedit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de matrícula";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(12, 322);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(0, 13);
            this.lblhora.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 145);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btncadmat
            // 
            this.btncadmat.ActiveBorderThickness = 1;
            this.btncadmat.ActiveCornerRadius = 20;
            this.btncadmat.ActiveFillColor = System.Drawing.Color.Red;
            this.btncadmat.ActiveForecolor = System.Drawing.Color.White;
            this.btncadmat.ActiveLineColor = System.Drawing.Color.Red;
            this.btncadmat.BackColor = System.Drawing.Color.White;
            this.btncadmat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncadmat.BackgroundImage")));
            this.btncadmat.ButtonText = "Cadastrar Matrícula";
            this.btncadmat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadmat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadmat.ForeColor = System.Drawing.Color.Red;
            this.btncadmat.IdleBorderThickness = 1;
            this.btncadmat.IdleCornerRadius = 20;
            this.btncadmat.IdleFillColor = System.Drawing.Color.White;
            this.btncadmat.IdleForecolor = System.Drawing.Color.Red;
            this.btncadmat.IdleLineColor = System.Drawing.Color.Red;
            this.btncadmat.Location = new System.Drawing.Point(25, 198);
            this.btncadmat.Margin = new System.Windows.Forms.Padding(5);
            this.btncadmat.Name = "btncadmat";
            this.btncadmat.Size = new System.Drawing.Size(501, 52);
            this.btncadmat.TabIndex = 6;
            this.btncadmat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncadmat.Click += new System.EventHandler(this.btncadmat_Click);
            // 
            // btnedit
            // 
            this.btnedit.ActiveBorderThickness = 1;
            this.btnedit.ActiveCornerRadius = 20;
            this.btnedit.ActiveFillColor = System.Drawing.Color.Red;
            this.btnedit.ActiveForecolor = System.Drawing.Color.White;
            this.btnedit.ActiveLineColor = System.Drawing.Color.Red;
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.ButtonText = "Editar Matrícula";
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.Red;
            this.btnedit.IdleBorderThickness = 1;
            this.btnedit.IdleCornerRadius = 20;
            this.btnedit.IdleFillColor = System.Drawing.Color.White;
            this.btnedit.IdleForecolor = System.Drawing.Color.Red;
            this.btnedit.IdleLineColor = System.Drawing.Color.Red;
            this.btnedit.Location = new System.Drawing.Point(25, 257);
            this.btnedit.Margin = new System.Windows.Forms.Padding(5);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(501, 52);
            this.btnedit.TabIndex = 7;
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 344);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btncadmat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btncadmat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnedit;
    }
}