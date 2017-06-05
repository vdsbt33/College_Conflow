namespace Conflow
{
    partial class Pesquisa_BlocoUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_BlocoUC));
            this.filtroAtivosChB = new System.Windows.Forms.CheckBox();
            this.filtroTipoCoB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroValorTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pesquisaList = new System.Windows.Forms.DataGridView();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.apagarBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.condominioList = new System.Windows.Forms.DataGridView();
            this.COD_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.identificadorTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.P_EditarBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.P_COD_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_COD_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).BeginInit();
            this.panel1.SuspendLayout();
            this.localizacaoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condominioList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtroAtivosChB
            // 
            this.filtroAtivosChB.AutoSize = true;
            this.filtroAtivosChB.Location = new System.Drawing.Point(151, 91);
            this.filtroAtivosChB.Name = "filtroAtivosChB";
            this.filtroAtivosChB.Size = new System.Drawing.Size(158, 24);
            this.filtroAtivosChB.TabIndex = 5;
            this.filtroAtivosChB.Text = "Apenas blocos ativos";
            this.filtroAtivosChB.UseVisualStyleBackColor = true;
            // 
            // filtroTipoCoB
            // 
            this.filtroTipoCoB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTipoCoB.FormattingEnabled = true;
            this.filtroTipoCoB.Items.AddRange(new object[] {
            "Identificador",
            "Condomínio que pertence"});
            this.filtroTipoCoB.Location = new System.Drawing.Point(191, 25);
            this.filtroTipoCoB.Name = "filtroTipoCoB";
            this.filtroTipoCoB.Size = new System.Drawing.Size(183, 28);
            this.filtroTipoCoB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de pesquisa:";
            // 
            // filtroValorTbox
            // 
            this.filtroValorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.filtroValorTbox.Location = new System.Drawing.Point(191, 58);
            this.filtroValorTbox.Name = "filtroValorTbox";
            this.filtroValorTbox.Size = new System.Drawing.Size(183, 26);
            this.filtroValorTbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(93, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor do filtro:";
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
            this.P_EditarBtn,
            this.P_COD_BLOCO,
            this.P_ID_BLOCO,
            this.P_COD_CONDOMINIO,
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
            this.pesquisaList.TabIndex = 56;
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarBtn.Location = new System.Drawing.Point(183, 125);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(96, 32);
            this.pesquisarBtn.TabIndex = 75;
            this.pesquisarBtn.Text = "Pesquisar";
            this.pesquisarBtn.UseVisualStyleBackColor = true;
            // 
            // apagarBtn
            // 
            this.apagarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagarBtn.Location = new System.Drawing.Point(377, 412);
            this.apagarBtn.Name = "apagarBtn";
            this.apagarBtn.Size = new System.Drawing.Size(97, 39);
            this.apagarBtn.TabIndex = 80;
            this.apagarBtn.Text = "Apagar";
            this.apagarBtn.UseVisualStyleBackColor = true;
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
            this.label6.TabIndex = 54;
            this.label6.Text = "Pesquisar Bloco";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(740, 50);
            this.label7.TabIndex = 65;
            this.label7.Text = "Editar Proprietário";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBtn.Location = new System.Drawing.Point(256, 412);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(97, 39);
            this.GuardarBtn.TabIndex = 74;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.localizacaoGB);
            this.panel1.Controls.Add(this.identificadorTbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.apagarBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.GuardarBtn);
            this.panel1.Location = new System.Drawing.Point(18, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 465);
            this.panel1.TabIndex = 57;
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.condominioList);
            this.localizacaoGB.Controls.Add(this.label4);
            this.localizacaoGB.Controls.Add(this.pictureBox1);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(200, 129);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 273);
            this.localizacaoGB.TabIndex = 84;
            this.localizacaoGB.TabStop = false;
            this.localizacaoGB.Text = "Localização";
            // 
            // condominioList
            // 
            this.condominioList.AllowUserToAddRows = false;
            this.condominioList.AllowUserToDeleteRows = false;
            this.condominioList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.condominioList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.condominioList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.condominioList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.condominioList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.condominioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.condominioList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CONDOMINIO,
            this.ID_CONDOMINIO});
            this.condominioList.Location = new System.Drawing.Point(11, 87);
            this.condominioList.MultiSelect = false;
            this.condominioList.Name = "condominioList";
            this.condominioList.ReadOnly = true;
            this.condominioList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.condominioList.ShowCellToolTips = false;
            this.condominioList.Size = new System.Drawing.Size(304, 175);
            this.condominioList.TabIndex = 2;
            // 
            // COD_CONDOMINIO
            // 
            this.COD_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COD_CONDOMINIO.HeaderText = "Código";
            this.COD_CONDOMINIO.MinimumWidth = 80;
            this.COD_CONDOMINIO.Name = "COD_CONDOMINIO";
            this.COD_CONDOMINIO.ReadOnly = true;
            this.COD_CONDOMINIO.Visible = false;
            // 
            // ID_CONDOMINIO
            // 
            this.ID_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_CONDOMINIO.HeaderText = "Identificador";
            this.ID_CONDOMINIO.MinimumWidth = 160;
            this.ID_CONDOMINIO.Name = "ID_CONDOMINIO";
            this.ID_CONDOMINIO.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selecione o Condomínio ao qual esse bloco pertence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // identificadorTbox
            // 
            this.identificadorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.identificadorTbox.Location = new System.Drawing.Point(291, 92);
            this.identificadorTbox.Name = "identificadorTbox";
            this.identificadorTbox.Size = new System.Drawing.Size(235, 26);
            this.identificadorTbox.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(200, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Identificador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "É obrigatório preencher todos os campos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(207, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
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
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
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
            // P_COD_BLOCO
            // 
            this.P_COD_BLOCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_COD_BLOCO.HeaderText = "Código";
            this.P_COD_BLOCO.MinimumWidth = 80;
            this.P_COD_BLOCO.Name = "P_COD_BLOCO";
            this.P_COD_BLOCO.ReadOnly = true;
            this.P_COD_BLOCO.Visible = false;
            this.P_COD_BLOCO.Width = 80;
            // 
            // P_ID_BLOCO
            // 
            this.P_ID_BLOCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P_ID_BLOCO.HeaderText = "Identificador";
            this.P_ID_BLOCO.MinimumWidth = 160;
            this.P_ID_BLOCO.Name = "P_ID_BLOCO";
            this.P_ID_BLOCO.ReadOnly = true;
            // 
            // P_COD_CONDOMINIO
            // 
            this.P_COD_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_COD_CONDOMINIO.HeaderText = "Código Condomínio";
            this.P_COD_CONDOMINIO.Name = "P_COD_CONDOMINIO";
            this.P_COD_CONDOMINIO.ReadOnly = true;
            this.P_COD_CONDOMINIO.Visible = false;
            this.P_COD_CONDOMINIO.Width = 154;
            // 
            // P_ID_CONDOMINIO
            // 
            this.P_ID_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P_ID_CONDOMINIO.HeaderText = "Condomínio";
            this.P_ID_CONDOMINIO.Name = "P_ID_CONDOMINIO";
            this.P_ID_CONDOMINIO.ReadOnly = true;
            // 
            // Pesquisa_BlocoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pesquisaList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pesquisa_BlocoUC";
            this.Size = new System.Drawing.Size(773, 992);
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.localizacaoGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.condominioList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox filtroAtivosChB;
        private System.Windows.Forms.ComboBox filtroTipoCoB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroValorTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView pesquisaList;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.Button apagarBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.DataGridView condominioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONDOMINIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONDOMINIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox identificadorTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewButtonColumn P_EditarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_CONDOMINIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_CONDOMINIO;
    }
}
