namespace Conflow
{
    partial class Pesquisa_MoradorUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_MoradorUC));
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.pesquisaList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.filtroAtivosChB = new System.Windows.Forms.CheckBox();
            this.filtroTipoCoB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroValorTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apagarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_EditarBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.P_COD_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_NOME_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_DAT_NASCIMENTO_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_SEXO_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_COD_APARTAMENTO_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_NUM_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_COD_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datanascimentoDtp = new System.Windows.Forms.DateTimePicker();
            this.predioList = new System.Windows.Forms.DataGridView();
            this.COD_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.sexoPanel = new System.Windows.Forms.Panel();
            this.sexoFRBtn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.sexoMRBtn = new System.Windows.Forms.RadioButton();
            this.apartamentoList = new System.Windows.Forms.DataGridView();
            this.COD_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nomeTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predioList)).BeginInit();
            this.sexoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.localizacaoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBtn.Location = new System.Drawing.Point(276, 708);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(97, 39);
            this.GuardarBtn.TabIndex = 28;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            // 
            // pesquisaList
            // 
            this.pesquisaList.AllowUserToAddRows = false;
            this.pesquisaList.AllowUserToDeleteRows = false;
            this.pesquisaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pesquisaList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.pesquisaList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.pesquisaList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pesquisaList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pesquisaList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.pesquisaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesquisaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_EditarBtn,
            this.P_COD_MORADOR,
            this.P_NOME_MORADOR,
            this.P_DAT_NASCIMENTO_MORADOR,
            this.P_SEXO_MORADOR,
            this.P_COD_APARTAMENTO_MORADOR,
            this.P_NUM_APARTAMENTO,
            this.P_COD_PREDIO,
            this.P_ID_PREDIO,
            this.P_ID_BLOCO,
            this.P_ID_CONDOMINIO});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pesquisaList.DefaultCellStyle = dataGridViewCellStyle5;
            this.pesquisaList.Location = new System.Drawing.Point(18, 245);
            this.pesquisaList.MultiSelect = false;
            this.pesquisaList.Name = "pesquisaList";
            this.pesquisaList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pesquisaList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.pesquisaList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pesquisaList.ShowCellToolTips = false;
            this.pesquisaList.Size = new System.Drawing.Size(740, 200);
            this.pesquisaList.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(773, 50);
            this.label6.TabIndex = 52;
            this.label6.Text = "Pesquisar Morador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarBtn.Location = new System.Drawing.Point(183, 117);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(96, 32);
            this.pesquisarBtn.TabIndex = 4;
            this.pesquisarBtn.Text = "Pesquisar";
            this.pesquisarBtn.UseVisualStyleBackColor = true;
            // 
            // filtroAtivosChB
            // 
            this.filtroAtivosChB.AutoSize = true;
            this.filtroAtivosChB.Location = new System.Drawing.Point(128, 83);
            this.filtroAtivosChB.Name = "filtroAtivosChB";
            this.filtroAtivosChB.Size = new System.Drawing.Size(182, 24);
            this.filtroAtivosChB.TabIndex = 3;
            this.filtroAtivosChB.Text = "Apenas moradores ativos";
            this.filtroAtivosChB.UseVisualStyleBackColor = true;
            // 
            // filtroTipoCoB
            // 
            this.filtroTipoCoB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTipoCoB.FormattingEnabled = true;
            this.filtroTipoCoB.Items.AddRange(new object[] {
            "Nome"});
            this.filtroTipoCoB.Location = new System.Drawing.Point(191, 17);
            this.filtroTipoCoB.Name = "filtroTipoCoB";
            this.filtroTipoCoB.Size = new System.Drawing.Size(183, 28);
            this.filtroTipoCoB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de pesquisa:";
            // 
            // filtroValorTbox
            // 
            this.filtroValorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.filtroValorTbox.Location = new System.Drawing.Point(191, 50);
            this.filtroValorTbox.Name = "filtroValorTbox";
            this.filtroValorTbox.Size = new System.Drawing.Size(183, 26);
            this.filtroValorTbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(93, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do filtro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pesquisarBtn);
            this.groupBox1.Controls.Add(this.filtroAtivosChB);
            this.groupBox1.Controls.Add(this.filtroTipoCoB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filtroValorTbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox1.Location = new System.Drawing.Point(160, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 165);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // apagarBtn
            // 
            this.apagarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagarBtn.Location = new System.Drawing.Point(397, 708);
            this.apagarBtn.Name = "apagarBtn";
            this.apagarBtn.Size = new System.Drawing.Size(97, 39);
            this.apagarBtn.TabIndex = 29;
            this.apagarBtn.Text = "Apagar";
            this.apagarBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.datanascimentoDtp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sexoPanel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.localizacaoGB);
            this.panel1.Controls.Add(this.nomeTbox);
            this.panel1.Controls.Add(this.apagarBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.GuardarBtn);
            this.panel1.Location = new System.Drawing.Point(18, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 946);
            this.panel1.TabIndex = 53;
            // 
            // P_EditarBtn
            // 
            this.P_EditarBtn.HeaderText = "Editar";
            this.P_EditarBtn.MinimumWidth = 68;
            this.P_EditarBtn.Name = "P_EditarBtn";
            this.P_EditarBtn.ReadOnly = true;
            this.P_EditarBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.P_EditarBtn.Text = "Editar";
            this.P_EditarBtn.UseColumnTextForButtonValue = true;
            this.P_EditarBtn.Width = 68;
            // 
            // P_COD_MORADOR
            // 
            this.P_COD_MORADOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_COD_MORADOR.HeaderText = "Código";
            this.P_COD_MORADOR.MinimumWidth = 80;
            this.P_COD_MORADOR.Name = "P_COD_MORADOR";
            this.P_COD_MORADOR.ReadOnly = true;
            this.P_COD_MORADOR.Visible = false;
            this.P_COD_MORADOR.Width = 80;
            // 
            // P_NOME_MORADOR
            // 
            this.P_NOME_MORADOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_NOME_MORADOR.HeaderText = "Nome";
            this.P_NOME_MORADOR.MinimumWidth = 160;
            this.P_NOME_MORADOR.Name = "P_NOME_MORADOR";
            this.P_NOME_MORADOR.ReadOnly = true;
            this.P_NOME_MORADOR.Width = 160;
            // 
            // P_DAT_NASCIMENTO_MORADOR
            // 
            this.P_DAT_NASCIMENTO_MORADOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_DAT_NASCIMENTO_MORADOR.HeaderText = "Data de Nascimento";
            this.P_DAT_NASCIMENTO_MORADOR.Name = "P_DAT_NASCIMENTO_MORADOR";
            this.P_DAT_NASCIMENTO_MORADOR.ReadOnly = true;
            this.P_DAT_NASCIMENTO_MORADOR.Width = 141;
            // 
            // P_SEXO_MORADOR
            // 
            this.P_SEXO_MORADOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_SEXO_MORADOR.HeaderText = "Sexo";
            this.P_SEXO_MORADOR.Name = "P_SEXO_MORADOR";
            this.P_SEXO_MORADOR.ReadOnly = true;
            this.P_SEXO_MORADOR.Width = 66;
            // 
            // P_COD_APARTAMENTO_MORADOR
            // 
            this.P_COD_APARTAMENTO_MORADOR.HeaderText = "Código Apartamento";
            this.P_COD_APARTAMENTO_MORADOR.Name = "P_COD_APARTAMENTO_MORADOR";
            this.P_COD_APARTAMENTO_MORADOR.ReadOnly = true;
            this.P_COD_APARTAMENTO_MORADOR.Visible = false;
            this.P_COD_APARTAMENTO_MORADOR.Width = 143;
            // 
            // P_NUM_APARTAMENTO
            // 
            this.P_NUM_APARTAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_NUM_APARTAMENTO.HeaderText = "Apartamento";
            this.P_NUM_APARTAMENTO.Name = "P_NUM_APARTAMENTO";
            this.P_NUM_APARTAMENTO.ReadOnly = true;
            this.P_NUM_APARTAMENTO.Width = 109;
            // 
            // P_COD_PREDIO
            // 
            this.P_COD_PREDIO.HeaderText = "Código Prédio";
            this.P_COD_PREDIO.Name = "P_COD_PREDIO";
            this.P_COD_PREDIO.ReadOnly = true;
            this.P_COD_PREDIO.Visible = false;
            this.P_COD_PREDIO.Width = 112;
            // 
            // P_ID_PREDIO
            // 
            this.P_ID_PREDIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_ID_PREDIO.HeaderText = "Prédio";
            this.P_ID_PREDIO.Name = "P_ID_PREDIO";
            this.P_ID_PREDIO.ReadOnly = true;
            this.P_ID_PREDIO.Width = 74;
            // 
            // P_ID_BLOCO
            // 
            this.P_ID_BLOCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_ID_BLOCO.HeaderText = "Bloco";
            this.P_ID_BLOCO.Name = "P_ID_BLOCO";
            this.P_ID_BLOCO.ReadOnly = true;
            this.P_ID_BLOCO.Width = 69;
            // 
            // P_ID_CONDOMINIO
            // 
            this.P_ID_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_ID_CONDOMINIO.HeaderText = "Condomínio";
            this.P_ID_CONDOMINIO.Name = "P_ID_CONDOMINIO";
            this.P_ID_CONDOMINIO.ReadOnly = true;
            this.P_ID_CONDOMINIO.Width = 106;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, -8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(740, 50);
            this.label7.TabIndex = 65;
            this.label7.Text = "Editar Proprietário";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Nome:";
            // 
            // datanascimentoDtp
            // 
            this.datanascimentoDtp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanascimentoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascimentoDtp.Location = new System.Drawing.Point(354, 201);
            this.datanascimentoDtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datanascimentoDtp.Name = "datanascimentoDtp";
            this.datanascimentoDtp.Size = new System.Drawing.Size(166, 26);
            this.datanascimentoDtp.TabIndex = 82;
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
            this.predioList.Location = new System.Drawing.Point(16, 100);
            this.predioList.MultiSelect = false;
            this.predioList.Name = "predioList";
            this.predioList.ReadOnly = true;
            this.predioList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predioList.ShowCellToolTips = false;
            this.predioList.Size = new System.Drawing.Size(304, 137);
            this.predioList.TabIndex = 13;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Data de nascimento:";
            // 
            // sexoPanel
            // 
            this.sexoPanel.Controls.Add(this.sexoFRBtn);
            this.sexoPanel.Controls.Add(this.label9);
            this.sexoPanel.Controls.Add(this.sexoMRBtn);
            this.sexoPanel.Location = new System.Drawing.Point(212, 152);
            this.sexoPanel.Name = "sexoPanel";
            this.sexoPanel.Size = new System.Drawing.Size(258, 35);
            this.sexoPanel.TabIndex = 86;
            // 
            // sexoFRBtn
            // 
            this.sexoFRBtn.AutoSize = true;
            this.sexoFRBtn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.sexoFRBtn.Location = new System.Drawing.Point(175, 5);
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
            this.label9.Location = new System.Drawing.Point(9, 5);
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
            this.sexoMRBtn.Location = new System.Drawing.Point(64, 5);
            this.sexoMRBtn.Name = "sexoMRBtn";
            this.sexoMRBtn.Size = new System.Drawing.Size(87, 24);
            this.sexoMRBtn.TabIndex = 65;
            this.sexoMRBtn.TabStop = true;
            this.sexoMRBtn.Text = "Masculino";
            this.sexoMRBtn.UseVisualStyleBackColor = true;
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
            this.apartamentoList.Location = new System.Drawing.Point(16, 256);
            this.apartamentoList.MultiSelect = false;
            this.apartamentoList.Name = "apartamentoList";
            this.apartamentoList.ReadOnly = true;
            this.apartamentoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apartamentoList.ShowCellToolTips = false;
            this.apartamentoList.Size = new System.Drawing.Size(304, 175);
            this.apartamentoList.TabIndex = 14;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "É obrigatório preencher todos os campos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(223, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 45);
            this.label8.TabIndex = 12;
            this.label8.Text = "Selecione o Apartamento ao qual esse morador pertence";
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.predioList);
            this.localizacaoGB.Controls.Add(this.apartamentoList);
            this.localizacaoGB.Controls.Add(this.label8);
            this.localizacaoGB.Controls.Add(this.pictureBox3);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(212, 251);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 443);
            this.localizacaoGB.TabIndex = 83;
            this.localizacaoGB.TabStop = false;
            this.localizacaoGB.Text = "Localização";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(16, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // nomeTbox
            // 
            this.nomeTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTbox.Location = new System.Drawing.Point(275, 114);
            this.nomeTbox.Name = "nomeTbox";
            this.nomeTbox.Size = new System.Drawing.Size(248, 26);
            this.nomeTbox.TabIndex = 81;
            // 
            // Pesquisa_MoradorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pesquisaList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Pesquisa_MoradorUC";
            this.Size = new System.Drawing.Size(773, 1263);
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predioList)).EndInit();
            this.sexoPanel.ResumeLayout(false);
            this.sexoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.localizacaoGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.DataGridView pesquisaList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.CheckBox filtroAtivosChB;
        private System.Windows.Forms.ComboBox filtroTipoCoB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroValorTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button apagarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn P_EditarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_NOME_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_DAT_NASCIMENTO_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_SEXO_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_APARTAMENTO_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_NUM_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_CONDOMINIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datanascimentoDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sexoPanel;
        private System.Windows.Forms.RadioButton sexoFRBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton sexoMRBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.DataGridView predioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PREDIO;
        private System.Windows.Forms.DataGridView apartamentoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_APARTAMENTO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox nomeTbox;
        private System.Windows.Forms.Label label7;
    }
}
