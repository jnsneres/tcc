namespace Cadmatricula
{
    partial class frmmatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmatricula));
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumres = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtano = new System.Windows.Forms.ComboBox();
            this.txtperiodo = new System.Windows.Forms.ComboBox();
            this.txtcelular2 = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txttipocurso = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtapto = new System.Windows.Forms.TextBox();
            this.txtbloco = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtescolaridade = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtuf = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtdataini = new System.Windows.Forms.MaskedTextBox();
            this.txtdataterm = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnalteracao = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnfoto = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(12, 238);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(101, 20);
            this.lblnome.TabIndex = 14;
            this.lblnome.Text = "Nome completo:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(119, 238);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(233, 20);
            this.txtnome.TabIndex = 15;
            // 
            // txtnascimento
            // 
            this.txtnascimento.Location = new System.Drawing.Point(502, 238);
            this.txtnascimento.Mask = "00/00/0000";
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(82, 20);
            this.txtnascimento.TabIndex = 16;
            this.txtnascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Endereço:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(119, 294);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(233, 20);
            this.txtRua.TabIndex = 20;
            this.txtRua.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtRua_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(47, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 13);
            this.textBox2.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(21, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 1);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Complemento:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcomplemento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtcomplemento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomplemento.FormattingEnabled = true;
            this.txtcomplemento.Items.AddRange(new object[] {
            "Casa",
            "Apartamento"});
            this.txtcomplemento.Location = new System.Drawing.Point(703, 293);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(140, 24);
            this.txtcomplemento.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Número residencia:";
            // 
            // txtnumres
            // 
            this.txtnumres.Location = new System.Drawing.Point(502, 293);
            this.txtnumres.Name = "txtnumres";
            this.txtnumres.Size = new System.Drawing.Size(82, 20);
            this.txtnumres.TabIndex = 28;
            this.txtnumres.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtnumres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(119, 447);
            this.txttelefone.Mask = "(99)0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(95, 20);
            this.txttelefone.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Informações para contato";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(278, 447);
            this.txtcelular.Mask = "(00) 90000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(119, 20);
            this.txtcelular.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Celular:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 1);
            this.panel1.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Celular 2:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(687, 449);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(233, 20);
            this.txtemail.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(637, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Email:";
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(641, 238);
            this.txtrg.Mask = "00.000.000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(94, 20);
            this.txtrg.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(613, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "RG:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(757, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "CPF:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(16, 504);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 1);
            this.panel3.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 508);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Informações sobre o curso";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(575, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "Período do curso:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(378, 556);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "Ano:";
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(119, 559);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(253, 20);
            this.txtcurso.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(68, 559);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "Curso:";
            // 
            // txtano
            // 
            this.txtano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtano.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtano.FormattingEnabled = true;
            this.txtano.Items.AddRange(new object[] {
            "1° Ano",
            "2° Ano",
            "3° Ano"});
            this.txtano.Location = new System.Drawing.Point(417, 558);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(140, 21);
            this.txtano.TabIndex = 54;
            this.txtano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtano_KeyPress);
            // 
            // txtperiodo
            // 
            this.txtperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtperiodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtperiodo.FormattingEnabled = true;
            this.txtperiodo.Items.AddRange(new object[] {
            "INTEGRAL",
            "TARDE",
            "NOITE"});
            this.txtperiodo.Location = new System.Drawing.Point(687, 558);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(140, 21);
            this.txtperiodo.TabIndex = 55;
            this.txtperiodo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtperiodo_KeyDown);
            // 
            // txtcelular2
            // 
            this.txtcelular2.Location = new System.Drawing.Point(500, 447);
            this.txtcelular2.Mask = "(00) 00000-0000";
            this.txtcelular2.Name = "txtcelular2";
            this.txtcelular2.Size = new System.Drawing.Size(119, 20);
            this.txtcelular2.TabIndex = 56;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(800, 240);
            this.txtcpf.Mask = "000000000/00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(94, 20);
            this.txtcpf.TabIndex = 57;
            // 
            // txttipocurso
            // 
            this.txttipocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttipocurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txttipocurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttipocurso.FormattingEnabled = true;
            this.txttipocurso.Items.AddRange(new object[] {
            "Presencial",
            "EAD"});
            this.txttipocurso.Location = new System.Drawing.Point(949, 559);
            this.txttipocurso.Name = "txttipocurso";
            this.txttipocurso.Size = new System.Drawing.Size(140, 21);
            this.txttipocurso.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(854, 556);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 58;
            this.label14.Text = "Tipo do curso:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(863, 291);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 20);
            this.label18.TabIndex = 60;
            this.label18.Text = "Apto:";
            // 
            // txtapto
            // 
            this.txtapto.Location = new System.Drawing.Point(905, 292);
            this.txtapto.Name = "txtapto";
            this.txtapto.Size = new System.Drawing.Size(121, 20);
            this.txtapto.TabIndex = 61;
            // 
            // txtbloco
            // 
            this.txtbloco.Location = new System.Drawing.Point(1090, 295);
            this.txtbloco.Name = "txtbloco";
            this.txtbloco.Size = new System.Drawing.Size(121, 20);
            this.txtbloco.TabIndex = 63;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1040, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 20);
            this.label19.TabIndex = 62;
            this.label19.Text = "Bloco:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(262, 344);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(154, 20);
            this.txtBairro.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(211, 342);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 20);
            this.label20.TabIndex = 64;
            this.label20.Text = "Bairro:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(119, 342);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(63, 20);
            this.txtCep.TabIndex = 67;
            this.txtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCep_MaskInputRejected);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(76, 340);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 20);
            this.label21.TabIndex = 66;
            this.label21.Text = "CEP:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(493, 346);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(142, 20);
            this.txtCidade.TabIndex = 69;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(435, 344);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 20);
            this.label22.TabIndex = 68;
            this.label22.Text = "Cidade:";
            // 
            // txtescolaridade
            // 
            this.txtescolaridade.Location = new System.Drawing.Point(119, 610);
            this.txtescolaridade.Name = "txtescolaridade";
            this.txtescolaridade.Size = new System.Drawing.Size(253, 20);
            this.txtescolaridade.TabIndex = 73;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(28, 608);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 20);
            this.label25.TabIndex = 72;
            this.label25.Text = "Escolaridade:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackgroundImage = global::Cadmatricula.Properties.Resources.aaaaa;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Location = new System.Drawing.Point(1129, 664);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(82, 23);
            this.btnsalvar.TabIndex = 75;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtuf
            // 
            this.txtuf.Location = new System.Drawing.Point(720, 348);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(43, 20);
            this.txtuf.TabIndex = 77;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(685, 348);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 20);
            this.label23.TabIndex = 76;
            this.label23.Text = "UF:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(388, 610);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 20);
            this.label24.TabIndex = 79;
            this.label24.Text = "Data de Início:";
            // 
            // txtdataini
            // 
            this.txtdataini.Location = new System.Drawing.Point(482, 610);
            this.txtdataini.Mask = "00/00/0000";
            this.txtdataini.Name = "txtdataini";
            this.txtdataini.Size = new System.Drawing.Size(69, 20);
            this.txtdataini.TabIndex = 80;
            this.txtdataini.ValidatingType = typeof(System.DateTime);
            // 
            // txtdataterm
            // 
            this.txtdataterm.Location = new System.Drawing.Point(705, 612);
            this.txtdataterm.Mask = "00/00/0000";
            this.txtdataterm.Name = "txtdataterm";
            this.txtdataterm.Size = new System.Drawing.Size(69, 20);
            this.txtdataterm.TabIndex = 82;
            this.txtdataterm.ValidatingType = typeof(System.DateTime);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(593, 610);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 20);
            this.label26.TabIndex = 81;
            this.label26.Text = "Data de Término:";
            // 
            // btnalteracao
            // 
            this.btnalteracao.BackColor = System.Drawing.Color.White;
            this.btnalteracao.BackgroundImage = global::Cadmatricula.Properties.Resources.aaaaa;
            this.btnalteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalteracao.Location = new System.Drawing.Point(1024, 664);
            this.btnalteracao.Name = "btnalteracao";
            this.btnalteracao.Size = new System.Drawing.Size(132, 23);
            this.btnalteracao.TabIndex = 83;
            this.btnalteracao.Text = "Salvar Alteração";
            this.btnalteracao.UseVisualStyleBackColor = false;
            this.btnalteracao.Visible = false;
            this.btnalteracao.Click += new System.EventHandler(this.btnalteracao_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(742, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(21, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(143, 143);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // btnfoto
            // 
            this.btnfoto.BackColor = System.Drawing.Color.White;
            this.btnfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnfoto.Image")));
            this.btnfoto.ImageActive = null;
            this.btnfoto.Location = new System.Drawing.Point(21, 161);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(71, 46);
            this.btnfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnfoto.TabIndex = 86;
            this.btnfoto.TabStop = false;
            this.btnfoto.Zoom = 10;
            this.btnfoto.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frmmatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 710);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.btnalteracao);
            this.Controls.Add(this.txtdataterm);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtdataini);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtescolaridade);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtbloco);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtapto);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txttipocurso);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtcelular2);
            this.Controls.Add(this.txtperiodo);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnumres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar matrícula";
            this.Load += new System.EventHandler(this.frmmatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.MaskedTextBox txtnascimento;
        public System.Windows.Forms.MaskedTextBox txtRua;
        public System.Windows.Forms.ComboBox txtcomplemento;
        public System.Windows.Forms.TextBox txtnumres;
        public System.Windows.Forms.MaskedTextBox txttelefone;
        public System.Windows.Forms.MaskedTextBox txtcelular;
        public System.Windows.Forms.MaskedTextBox txtemail;
        public System.Windows.Forms.MaskedTextBox txtrg;
        public System.Windows.Forms.MaskedTextBox txtcurso;
        public System.Windows.Forms.ComboBox txtano;
        public System.Windows.Forms.ComboBox txtperiodo;
        public System.Windows.Forms.MaskedTextBox txtcelular2;
        public System.Windows.Forms.MaskedTextBox txtcpf;
        public System.Windows.Forms.ComboBox txttipocurso;
        public System.Windows.Forms.TextBox txtapto;
        public System.Windows.Forms.TextBox txtbloco;
        public System.Windows.Forms.MaskedTextBox txtBairro;
        public System.Windows.Forms.MaskedTextBox txtCep;
        public System.Windows.Forms.MaskedTextBox txtCidade;
        public System.Windows.Forms.MaskedTextBox txtescolaridade;
        public System.Windows.Forms.MaskedTextBox txtuf;
        public System.Windows.Forms.MaskedTextBox txtdataini;
        public System.Windows.Forms.MaskedTextBox txtdataterm;
        public System.Windows.Forms.Button btnsalvar;
        public System.Windows.Forms.Button btnalteracao;
        private Bunifu.Framework.UI.BunifuImageButton btnfoto;
    }
}