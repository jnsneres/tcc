namespace Cadmatricula
{
    partial class frmlogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.lblesqueceu = new System.Windows.Forms.Label();
            this.lblcadusuario = new System.Windows.Forms.Label();
            this.cblogin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnentrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblesqueceu
            // 
            this.lblesqueceu.AutoSize = true;
            this.lblesqueceu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblesqueceu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblesqueceu.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblesqueceu.ForeColor = System.Drawing.Color.Black;
            this.lblesqueceu.Location = new System.Drawing.Point(193, 357);
            this.lblesqueceu.Name = "lblesqueceu";
            this.lblesqueceu.Size = new System.Drawing.Size(146, 16);
            this.lblesqueceu.TabIndex = 0;
            this.lblesqueceu.Text = "Esqueceu sua senha?";
            this.lblesqueceu.Click += new System.EventHandler(this.lblesqueceu_Click);
            // 
            // lblcadusuario
            // 
            this.lblcadusuario.AutoSize = true;
            this.lblcadusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcadusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblcadusuario.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadusuario.ForeColor = System.Drawing.Color.Black;
            this.lblcadusuario.Location = new System.Drawing.Point(15, 357);
            this.lblcadusuario.Name = "lblcadusuario";
            this.lblcadusuario.Size = new System.Drawing.Size(162, 16);
            this.lblcadusuario.TabIndex = 11;
            this.lblcadusuario.Text = "Cadastrar novo usuário";
            this.lblcadusuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // cblogin
            // 
            this.cblogin.AutoCompleteCustomSource.AddRange(new string[] {
            "Secrataria",
            "Coordenação"});
            this.cblogin.BackColor = System.Drawing.Color.White;
            this.cblogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cblogin.ForeColor = System.Drawing.Color.Black;
            this.cblogin.FormattingEnabled = true;
            this.cblogin.Items.AddRange(new object[] {
            "Secretária",
            "Coordenação"});
            this.cblogin.Location = new System.Drawing.Point(81, 151);
            this.cblogin.Name = "cblogin";
            this.cblogin.Size = new System.Drawing.Size(121, 21);
            this.cblogin.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Função:";
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.White;
            this.txtlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.Black;
            this.txtlogin.HintForeColor = System.Drawing.Color.Empty;
            this.txtlogin.HintText = "";
            this.txtlogin.isPassword = false;
            this.txtlogin.LineFocusedColor = System.Drawing.Color.Red;
            this.txtlogin.LineIdleColor = System.Drawing.Color.Red;
            this.txtlogin.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtlogin.LineThickness = 4;
            this.txtlogin.Location = new System.Drawing.Point(16, 212);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(364, 32);
            this.txtlogin.TabIndex = 14;
            this.txtlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtlogin.Enter += new System.EventHandler(this.txtlogin_Enter);
            this.txtlogin.Leave += new System.EventHandler(this.txtlogin_Leave);
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.White;
            this.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.HintForeColor = System.Drawing.Color.Empty;
            this.txtsenha.HintText = "";
            this.txtsenha.isPassword = true;
            this.txtsenha.LineFocusedColor = System.Drawing.Color.Red;
            this.txtsenha.LineIdleColor = System.Drawing.Color.Red;
            this.txtsenha.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtsenha.LineThickness = 4;
            this.txtsenha.Location = new System.Drawing.Point(16, 293);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(364, 32);
            this.txtsenha.TabIndex = 18;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsenha.OnValueChanged += new System.EventHandler(this.txtsenha2_OnValueChanged);
            this.txtsenha.Enter += new System.EventHandler(this.txtsenha_Enter);
            this.txtsenha.Leave += new System.EventHandler(this.txtsenha_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 147);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cadmatricula.Properties.Resources._0001;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnentrar
            // 
            this.btnentrar.Activecolor = System.Drawing.Color.Red;
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnentrar.BorderRadius = 0;
            this.btnentrar.ButtonText = "Entrar";
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnentrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnentrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnentrar.Iconimage")));
            this.btnentrar.Iconimage_right = null;
            this.btnentrar.Iconimage_right_Selected = null;
            this.btnentrar.Iconimage_Selected = null;
            this.btnentrar.IconMarginLeft = 0;
            this.btnentrar.IconMarginRight = 0;
            this.btnentrar.IconRightVisible = true;
            this.btnentrar.IconRightZoom = 0D;
            this.btnentrar.IconVisible = true;
            this.btnentrar.IconZoom = 90D;
            this.btnentrar.IsTab = false;
            this.btnentrar.Location = new System.Drawing.Point(16, 395);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnentrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnentrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnentrar.selected = false;
            this.btnentrar.Size = new System.Drawing.Size(241, 48);
            this.btnentrar.TabIndex = 19;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnentrar.Textcolor = System.Drawing.Color.White;
            this.btnentrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click_1);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(445, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cblogin);
            this.Controls.Add(this.lblcadusuario);
            this.Controls.Add(this.lblesqueceu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblesqueceu;
        private System.Windows.Forms.Label lblcadusuario;
        private System.Windows.Forms.ComboBox cblogin;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtlogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsenha;
        private Bunifu.Framework.UI.BunifuFlatButton btnentrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

