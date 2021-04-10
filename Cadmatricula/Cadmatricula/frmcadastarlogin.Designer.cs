namespace Cadmatricula
{
    partial class frmcadastarlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadastarlogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnomelog = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtemaillog = new System.Windows.Forms.TextBox();
            this.txtsenha2 = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbarea = new System.Windows.Forms.ComboBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Área:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Login:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Senha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirmar senha:";
            // 
            // txtnomelog
            // 
            this.txtnomelog.Location = new System.Drawing.Point(56, 194);
            this.txtnomelog.Name = "txtnomelog";
            this.txtnomelog.Size = new System.Drawing.Size(195, 20);
            this.txtnomelog.TabIndex = 7;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(392, 194);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(195, 20);
            this.txtlogin.TabIndex = 8;
            // 
            // txtemaillog
            // 
            this.txtemaillog.Location = new System.Drawing.Point(56, 268);
            this.txtemaillog.Name = "txtemaillog";
            this.txtemaillog.Size = new System.Drawing.Size(195, 20);
            this.txtemaillog.TabIndex = 10;
            // 
            // txtsenha2
            // 
            this.txtsenha2.Location = new System.Drawing.Point(392, 268);
            this.txtsenha2.Name = "txtsenha2";
            this.txtsenha2.Size = new System.Drawing.Size(195, 20);
            this.txtsenha2.TabIndex = 11;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(392, 232);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(195, 20);
            this.txtsenha.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cbarea
            // 
            this.cbarea.FormattingEnabled = true;
            this.cbarea.Items.AddRange(new object[] {
            "Secretária",
            "Coordenação"});
            this.cbarea.Location = new System.Drawing.Point(56, 231);
            this.cbarea.Name = "cbarea";
            this.cbarea.Size = new System.Drawing.Size(195, 21);
            this.cbarea.TabIndex = 14;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(512, 317);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 15;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.ForeColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(12, 317);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 16;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // frmcadastarlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.cbarea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtsenha2);
            this.Controls.Add(this.txtemaillog);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtnomelog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcadastarlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar-se";
            this.Load += new System.EventHandler(this.frmcadastarlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnomelog;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtemaillog;
        private System.Windows.Forms.TextBox txtsenha2;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbarea;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnfechar;
    }
}