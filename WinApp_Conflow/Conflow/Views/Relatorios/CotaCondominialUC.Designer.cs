namespace Conflow.Views
{
    partial class CotaCondominialUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CotaCondominialUC));
            this.pesquisaList = new System.Windows.Forms.DataGridView();
            this.btnBoleto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.P_COD_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_NOME_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_VALOR_BOLETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_DAT_VENC_BOLETO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_RG_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_CPF_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_CNPJ_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_COD_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_COD_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.filtroTipoCoB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filtroValorTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boletoPanel = new System.Windows.Forms.Panel();
            this.cursorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pesquisaList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pesquisaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesquisaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBoleto,
            this.P_COD_PROPRIETARIO,
            this.P_NOME_PROPRIETARIO,
            this.B_VALOR_BOLETO,
            this.B_DAT_VENC_BOLETO,
            this.P_RG_PROPRIETARIO,
            this.P_CPF_PROPRIETARIO,
            this.P_CNPJ_PROPRIETARIO,
            this.P_COD_APARTAMENTO,
            this.P_ID_APARTAMENTO,
            this.P_COD_PREDIO,
            this.P_ID_PREDIO,
            this.P_ID_BLOCO,
            this.P_ID_CONDOMINIO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pesquisaList.DefaultCellStyle = dataGridViewCellStyle2;
            this.pesquisaList.Location = new System.Drawing.Point(18, 245);
            this.pesquisaList.MultiSelect = false;
            this.pesquisaList.Name = "pesquisaList";
            this.pesquisaList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pesquisaList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pesquisaList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pesquisaList.ShowCellToolTips = false;
            this.pesquisaList.Size = new System.Drawing.Size(740, 200);
            this.pesquisaList.TabIndex = 49;
            this.pesquisaList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnBoleto
            // 
            this.btnBoleto.HeaderText = "Boleto";
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.ReadOnly = true;
            this.btnBoleto.Text = "Exibir";
            this.btnBoleto.Width = 54;
            // 
            // P_COD_PROPRIETARIO
            // 
            this.P_COD_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_COD_PROPRIETARIO.HeaderText = "Código Proprietário";
            this.P_COD_PROPRIETARIO.MinimumWidth = 80;
            this.P_COD_PROPRIETARIO.Name = "P_COD_PROPRIETARIO";
            this.P_COD_PROPRIETARIO.ReadOnly = true;
            this.P_COD_PROPRIETARIO.Visible = false;
            // 
            // P_NOME_PROPRIETARIO
            // 
            this.P_NOME_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_NOME_PROPRIETARIO.HeaderText = "Nome";
            this.P_NOME_PROPRIETARIO.MinimumWidth = 160;
            this.P_NOME_PROPRIETARIO.Name = "P_NOME_PROPRIETARIO";
            this.P_NOME_PROPRIETARIO.ReadOnly = true;
            this.P_NOME_PROPRIETARIO.Width = 160;
            // 
            // B_VALOR_BOLETO
            // 
            this.B_VALOR_BOLETO.HeaderText = "Valor (R$)";
            this.B_VALOR_BOLETO.MinimumWidth = 120;
            this.B_VALOR_BOLETO.Name = "B_VALOR_BOLETO";
            this.B_VALOR_BOLETO.ReadOnly = true;
            this.B_VALOR_BOLETO.Width = 120;
            // 
            // B_DAT_VENC_BOLETO
            // 
            this.B_DAT_VENC_BOLETO.HeaderText = "Data de Vencimento";
            this.B_DAT_VENC_BOLETO.MinimumWidth = 160;
            this.B_DAT_VENC_BOLETO.Name = "B_DAT_VENC_BOLETO";
            this.B_DAT_VENC_BOLETO.ReadOnly = true;
            this.B_DAT_VENC_BOLETO.Width = 160;
            // 
            // P_RG_PROPRIETARIO
            // 
            this.P_RG_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_RG_PROPRIETARIO.HeaderText = "RG";
            this.P_RG_PROPRIETARIO.Name = "P_RG_PROPRIETARIO";
            this.P_RG_PROPRIETARIO.ReadOnly = true;
            this.P_RG_PROPRIETARIO.Width = 53;
            // 
            // P_CPF_PROPRIETARIO
            // 
            this.P_CPF_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_CPF_PROPRIETARIO.HeaderText = "CPF";
            this.P_CPF_PROPRIETARIO.Name = "P_CPF_PROPRIETARIO";
            this.P_CPF_PROPRIETARIO.ReadOnly = true;
            this.P_CPF_PROPRIETARIO.Width = 60;
            // 
            // P_CNPJ_PROPRIETARIO
            // 
            this.P_CNPJ_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_CNPJ_PROPRIETARIO.HeaderText = "CNPJ";
            this.P_CNPJ_PROPRIETARIO.Name = "P_CNPJ_PROPRIETARIO";
            this.P_CNPJ_PROPRIETARIO.ReadOnly = true;
            this.P_CNPJ_PROPRIETARIO.Width = 68;
            // 
            // P_COD_APARTAMENTO
            // 
            this.P_COD_APARTAMENTO.HeaderText = "Código Apartamento";
            this.P_COD_APARTAMENTO.Name = "P_COD_APARTAMENTO";
            this.P_COD_APARTAMENTO.ReadOnly = true;
            this.P_COD_APARTAMENTO.Visible = false;
            this.P_COD_APARTAMENTO.Width = 157;
            // 
            // P_ID_APARTAMENTO
            // 
            this.P_ID_APARTAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_ID_APARTAMENTO.HeaderText = "Apartamento";
            this.P_ID_APARTAMENTO.Name = "P_ID_APARTAMENTO";
            this.P_ID_APARTAMENTO.ReadOnly = true;
            this.P_ID_APARTAMENTO.Width = 109;
            // 
            // P_COD_PREDIO
            // 
            this.P_COD_PREDIO.HeaderText = "Código Prédio";
            this.P_COD_PREDIO.Name = "P_COD_PREDIO";
            this.P_COD_PREDIO.ReadOnly = true;
            this.P_COD_PREDIO.Visible = false;
            this.P_COD_PREDIO.Width = 122;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pesquisarBtn);
            this.groupBox2.Controls.Add(this.filtroTipoCoB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.filtroValorTbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox2.Location = new System.Drawing.Point(160, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 165);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarBtn.Location = new System.Drawing.Point(183, 125);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(96, 32);
            this.pesquisarBtn.TabIndex = 4;
            this.pesquisarBtn.Text = "Pesquisar";
            this.pesquisarBtn.UseVisualStyleBackColor = true;
            this.pesquisarBtn.Click += new System.EventHandler(this.pesquisarBtn_Click);
            // 
            // filtroTipoCoB
            // 
            this.filtroTipoCoB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTipoCoB.FormattingEnabled = true;
            this.filtroTipoCoB.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "CPF",
            "CNPJ"});
            this.filtroTipoCoB.Location = new System.Drawing.Point(191, 25);
            this.filtroTipoCoB.Name = "filtroTipoCoB";
            this.filtroTipoCoB.Size = new System.Drawing.Size(183, 28);
            this.filtroTipoCoB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(61, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filtro de pesquisa:";
            // 
            // filtroValorTbox
            // 
            this.filtroValorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.filtroValorTbox.Location = new System.Drawing.Point(191, 58);
            this.filtroValorTbox.Name = "filtroValorTbox";
            this.filtroValorTbox.Size = new System.Drawing.Size(183, 26);
            this.filtroValorTbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(93, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor do filtro:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(773, 50);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cota Condominial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boletoPanel
            // 
            this.boletoPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boletoPanel.Location = new System.Drawing.Point(18, 464);
            this.boletoPanel.Name = "boletoPanel";
            this.boletoPanel.Size = new System.Drawing.Size(740, 416);
            this.boletoPanel.TabIndex = 51;
            // 
            // cursorToolTip
            // 
            this.cursorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.cursorToolTip.ToolTipTitle = "Em construção:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(18, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            this.cursorToolTip.SetToolTip(this.pictureBox4, "Essa tela está em construção e possui recursos indisponíveis.");
            // 
            // CotaCondominialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.boletoPanel);
            this.Controls.Add(this.pesquisaList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Name = "CotaCondominialUC";
            this.Size = new System.Drawing.Size(773, 899);
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pesquisaList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.ComboBox filtroTipoCoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filtroValorTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel boletoPanel;
        private System.Windows.Forms.DataGridViewButtonColumn btnBoleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_NOME_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_VALOR_BOLETO;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_DAT_VENC_BOLETO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_RG_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_CPF_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_CNPJ_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_CONDOMINIO;
        private System.Windows.Forms.ToolTip cursorToolTip;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
