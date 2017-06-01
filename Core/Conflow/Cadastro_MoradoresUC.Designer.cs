namespace Conflow
{
    partial class Cadastro_MoradoresUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_MoradoresUC));
            this.label6 = new System.Windows.Forms.Label();
            this.pessoaJuridicaRb = new System.Windows.Forms.RadioButton();
            this.pessoaFisicaRb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cpfRgPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgTbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroestacionamentoNud = new System.Windows.Forms.NumericUpDown();
            this.datanascimentoDtp = new System.Windows.Forms.DateTimePicker();
            this.nomeTbox = new System.Windows.Forms.TextBox();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.predioList = new System.Windows.Forms.DataGridView();
            this.apartamentoList = new System.Windows.Forms.DataGridView();
            this.COD_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sexoPanel = new System.Windows.Forms.Panel();
            this.sexoFRBtn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.sexoMRBtn = new System.Windows.Forms.RadioButton();
            this.adicionarContatoBtn = new System.Windows.Forms.Button();
            this.contatoList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contatoTbox = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tipoContatoCB = new System.Windows.Forms.ComboBox();
            this.removerContatoBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.COD_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numeroestacionamentoNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.localizacaoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predioList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sexoPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(698, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cadastro de Proprietário";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pessoaJuridicaRb
            // 
            this.pessoaJuridicaRb.AutoSize = true;
            this.pessoaJuridicaRb.BackColor = System.Drawing.Color.Transparent;
            this.pessoaJuridicaRb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaJuridicaRb.Location = new System.Drawing.Point(175, 329);
            this.pessoaJuridicaRb.Name = "pessoaJuridicaRb";
            this.pessoaJuridicaRb.Size = new System.Drawing.Size(123, 24);
            this.pessoaJuridicaRb.TabIndex = 4;
            this.pessoaJuridicaRb.Text = "Pessoa Jurídica";
            this.pessoaJuridicaRb.UseVisualStyleBackColor = false;
            this.pessoaJuridicaRb.CheckedChanged += new System.EventHandler(this.pessoaJuridicaRb_CheckedChanged);
            // 
            // pessoaFisicaRb
            // 
            this.pessoaFisicaRb.AutoSize = true;
            this.pessoaFisicaRb.BackColor = System.Drawing.Color.Transparent;
            this.pessoaFisicaRb.Checked = true;
            this.pessoaFisicaRb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaFisicaRb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pessoaFisicaRb.Location = new System.Drawing.Point(14, 329);
            this.pessoaFisicaRb.Name = "pessoaFisicaRb";
            this.pessoaFisicaRb.Size = new System.Drawing.Size(112, 24);
            this.pessoaFisicaRb.TabIndex = 3;
            this.pessoaFisicaRb.TabStop = true;
            this.pessoaFisicaRb.Text = "Pessoa Física";
            this.pessoaFisicaRb.UseVisualStyleBackColor = false;
            this.pessoaFisicaRb.CheckedChanged += new System.EventHandler(this.pessoaFisicaRb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha o tipo do proprietário:";
            // 
            // cpfRgPanel
            // 
            this.cpfRgPanel.Location = new System.Drawing.Point(14, 360);
            this.cpfRgPanel.Name = "cpfRgPanel";
            this.cpfRgPanel.Size = new System.Drawing.Size(284, 55);
            this.cpfRgPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número do estacionamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "RG:";
            // 
            // rgTbox
            // 
            this.rgTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTbox.Location = new System.Drawing.Point(52, 141);
            this.rgTbox.Mask = "000.000.000-0";
            this.rgTbox.Name = "rgTbox";
            this.rgTbox.Size = new System.Drawing.Size(136, 26);
            this.rgTbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // numeroestacionamentoNud
            // 
            this.numeroestacionamentoNud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroestacionamentoNud.Location = new System.Drawing.Point(198, 630);
            this.numeroestacionamentoNud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeroestacionamentoNud.Name = "numeroestacionamentoNud";
            this.numeroestacionamentoNud.Size = new System.Drawing.Size(100, 26);
            this.numeroestacionamentoNud.TabIndex = 14;
            // 
            // datanascimentoDtp
            // 
            this.datanascimentoDtp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanascimentoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascimentoDtp.Location = new System.Drawing.Point(151, 249);
            this.datanascimentoDtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datanascimentoDtp.Name = "datanascimentoDtp";
            this.datanascimentoDtp.Size = new System.Drawing.Size(166, 26);
            this.datanascimentoDtp.TabIndex = 6;
            // 
            // nomeTbox
            // 
            this.nomeTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTbox.Location = new System.Drawing.Point(69, 92);
            this.nomeTbox.Name = "nomeTbox";
            this.nomeTbox.Size = new System.Drawing.Size(248, 26);
            this.nomeTbox.TabIndex = 1;
            // 
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(110, 711);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 15;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(21, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(21, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "É obrigatório preencher todos os campos";
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.predioList);
            this.localizacaoGB.Controls.Add(this.apartamentoList);
            this.localizacaoGB.Controls.Add(this.label8);
            this.localizacaoGB.Controls.Add(this.pictureBox3);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(345, 373);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 443);
            this.localizacaoGB.TabIndex = 12;
            this.localizacaoGB.TabStop = false;
            this.localizacaoGB.Text = "Localização";
            // 
            // predioList
            // 
            this.predioList.AllowUserToAddRows = false;
            this.predioList.AllowUserToDeleteRows = false;
            this.predioList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.predioList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.predioList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.predioList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.predioList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.predioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.predioList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_PREDIO,
            this.ID_PREDIO});
            this.predioList.Location = new System.Drawing.Point(11, 100);
            this.predioList.MultiSelect = false;
            this.predioList.Name = "predioList";
            this.predioList.ReadOnly = true;
            this.predioList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predioList.ShowCellToolTips = false;
            this.predioList.Size = new System.Drawing.Size(304, 137);
            this.predioList.TabIndex = 64;
            this.predioList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.predioList_RowEnter);
            // 
            // apartamentoList
            // 
            this.apartamentoList.AllowUserToAddRows = false;
            this.apartamentoList.AllowUserToDeleteRows = false;
            this.apartamentoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.apartamentoList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.apartamentoList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.apartamentoList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.apartamentoList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.apartamentoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apartamentoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_APARTAMENTO,
            this.NUM_APARTAMENTO});
            this.apartamentoList.Location = new System.Drawing.Point(11, 256);
            this.apartamentoList.MultiSelect = false;
            this.apartamentoList.Name = "apartamentoList";
            this.apartamentoList.ReadOnly = true;
            this.apartamentoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apartamentoList.ShowCellToolTips = false;
            this.apartamentoList.Size = new System.Drawing.Size(304, 175);
            this.apartamentoList.TabIndex = 13;
            // 
            // COD_APARTAMENTO
            // 
            this.COD_APARTAMENTO.HeaderText = "Código";
            this.COD_APARTAMENTO.MinimumWidth = 80;
            this.COD_APARTAMENTO.Name = "COD_APARTAMENTO";
            this.COD_APARTAMENTO.ReadOnly = true;
            this.COD_APARTAMENTO.Visible = false;
            this.COD_APARTAMENTO.Width = 80;
            // 
            // NUM_APARTAMENTO
            // 
            this.NUM_APARTAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NUM_APARTAMENTO.HeaderText = "Número do apartamento";
            this.NUM_APARTAMENTO.MinimumWidth = 200;
            this.NUM_APARTAMENTO.Name = "NUM_APARTAMENTO";
            this.NUM_APARTAMENTO.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 45);
            this.label8.TabIndex = 12;
            this.label8.Text = "Selecione o Apartamento ao qual esse morador pertence";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(11, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // sexoPanel
            // 
            this.sexoPanel.Controls.Add(this.sexoFRBtn);
            this.sexoPanel.Controls.Add(this.label9);
            this.sexoPanel.Controls.Add(this.sexoMRBtn);
            this.sexoPanel.Location = new System.Drawing.Point(9, 192);
            this.sexoPanel.Name = "sexoPanel";
            this.sexoPanel.Size = new System.Drawing.Size(258, 35);
            this.sexoPanel.TabIndex = 58;
            // 
            // sexoFRBtn
            // 
            this.sexoFRBtn.AutoSize = true;
            this.sexoFRBtn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.sexoFRBtn.Location = new System.Drawing.Point(170, 5);
            this.sexoFRBtn.Name = "sexoFRBtn";
            this.sexoFRBtn.Size = new System.Drawing.Size(82, 24);
            this.sexoFRBtn.TabIndex = 66;
            this.sexoFRBtn.Text = "Feminino";
            this.sexoFRBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Sexo:";
            // 
            // sexoMRBtn
            // 
            this.sexoMRBtn.AutoSize = true;
            this.sexoMRBtn.Checked = true;
            this.sexoMRBtn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.sexoMRBtn.Location = new System.Drawing.Point(59, 5);
            this.sexoMRBtn.Name = "sexoMRBtn";
            this.sexoMRBtn.Size = new System.Drawing.Size(87, 24);
            this.sexoMRBtn.TabIndex = 65;
            this.sexoMRBtn.TabStop = true;
            this.sexoMRBtn.Text = "Masculino";
            this.sexoMRBtn.UseVisualStyleBackColor = true;
            // 
            // adicionarContatoBtn
            // 
            this.adicionarContatoBtn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.adicionarContatoBtn.Location = new System.Drawing.Point(159, 253);
            this.adicionarContatoBtn.Name = "adicionarContatoBtn";
            this.adicionarContatoBtn.Size = new System.Drawing.Size(75, 26);
            this.adicionarContatoBtn.TabIndex = 10;
            this.adicionarContatoBtn.Text = "Adicionar";
            this.adicionarContatoBtn.UseVisualStyleBackColor = true;
            this.adicionarContatoBtn.Click += new System.EventHandler(this.adicionarContatoBtn_Click);
            // 
            // contatoList
            // 
            this.contatoList.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.contatoList.FormattingEnabled = true;
            this.contatoList.ItemHeight = 20;
            this.contatoList.Location = new System.Drawing.Point(11, 98);
            this.contatoList.Name = "contatoList";
            this.contatoList.Size = new System.Drawing.Size(304, 104);
            this.contatoList.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contatoTbox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tipoContatoCB);
            this.groupBox1.Controls.Add(this.removerContatoBtn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.contatoList);
            this.groupBox1.Controls.Add(this.adicionarContatoBtn);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox1.Location = new System.Drawing.Point(345, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 290);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contato";
            // 
            // contatoTbox
            // 
            this.contatoTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.contatoTbox.Location = new System.Drawing.Point(11, 253);
            this.contatoTbox.Name = "contatoTbox";
            this.contatoTbox.Size = new System.Drawing.Size(142, 26);
            this.contatoTbox.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(46, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Tipo:";
            // 
            // tipoContatoCB
            // 
            this.tipoContatoCB.FormattingEnabled = true;
            this.tipoContatoCB.Items.AddRange(new object[] {
            "Telefone",
            "E-mail"});
            this.tipoContatoCB.Location = new System.Drawing.Point(89, 214);
            this.tipoContatoCB.Name = "tipoContatoCB";
            this.tipoContatoCB.Size = new System.Drawing.Size(188, 28);
            this.tipoContatoCB.TabIndex = 8;
            this.tipoContatoCB.SelectedIndexChanged += new System.EventHandler(this.tipoContatoCB_SelectedIndexChanged);
            // 
            // removerContatoBtn
            // 
            this.removerContatoBtn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.removerContatoBtn.Location = new System.Drawing.Point(240, 253);
            this.removerContatoBtn.Name = "removerContatoBtn";
            this.removerContatoBtn.Size = new System.Drawing.Size(75, 26);
            this.removerContatoBtn.TabIndex = 11;
            this.removerContatoBtn.Text = "Remover";
            this.removerContatoBtn.UseVisualStyleBackColor = true;
            this.removerContatoBtn.Click += new System.EventHandler(this.removerContatoBtn_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 45);
            this.label10.TabIndex = 6;
            this.label10.Text = "Insira um meio de contato com o proprietário";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(11, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // COD_PREDIO
            // 
            this.COD_PREDIO.HeaderText = "Código do Prédio";
            this.COD_PREDIO.Name = "COD_PREDIO";
            this.COD_PREDIO.ReadOnly = true;
            this.COD_PREDIO.Visible = false;
            this.COD_PREDIO.Width = 142;
            // 
            // ID_PREDIO
            // 
            this.ID_PREDIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_PREDIO.HeaderText = "Prédio";
            this.ID_PREDIO.MinimumWidth = 200;
            this.ID_PREDIO.Name = "ID_PREDIO";
            this.ID_PREDIO.ReadOnly = true;
            // 
            // Cadastro_MoradoresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sexoPanel);
            this.Controls.Add(this.localizacaoGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pessoaJuridicaRb);
            this.Controls.Add(this.pessoaFisicaRb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpfRgPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rgTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroestacionamentoNud);
            this.Controls.Add(this.datanascimentoDtp);
            this.Controls.Add(this.nomeTbox);
            this.Controls.Add(this.CriarBtn);
            this.Name = "Cadastro_MoradoresUC";
            this.Size = new System.Drawing.Size(693, 846);
            ((System.ComponentModel.ISupportInitialize)(this.numeroestacionamentoNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.localizacaoGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.predioList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sexoPanel.ResumeLayout(false);
            this.sexoPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton pessoaJuridicaRb;
        private System.Windows.Forms.RadioButton pessoaFisicaRb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel cpfRgPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox rgTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeroestacionamentoNud;
        private System.Windows.Forms.DateTimePicker datanascimentoDtp;
        private System.Windows.Forms.TextBox nomeTbox;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView apartamentoList;
        private System.Windows.Forms.Panel sexoPanel;
        private System.Windows.Forms.RadioButton sexoFRBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton sexoMRBtn;
        private System.Windows.Forms.Button adicionarContatoBtn;
        private System.Windows.Forms.ListBox contatoList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button removerContatoBtn;
        private System.Windows.Forms.ComboBox tipoContatoCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox contatoTbox;
        private System.Windows.Forms.DataGridView predioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PREDIO;
    }
}
