namespace Conflow
{
    partial class Pesquisa_MoradoresUC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtroTipoCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroValorTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesquisaList = new System.Windows.Forms.DataGridView();
            this.EditarBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.COD_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAT_NASCIMENTO_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_UF_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_CIDADE_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_BAIRRO_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_RUA_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_NUM_PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filtroTipoCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filtroValorTbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox1.Location = new System.Drawing.Point(18, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 100);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // filtroTipoCB
            // 
            this.filtroTipoCB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTipoCB.FormattingEnabled = true;
            this.filtroTipoCB.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "CPF",
            "CNPJ"});
            this.filtroTipoCB.Location = new System.Drawing.Point(180, 25);
            this.filtroTipoCB.Name = "filtroTipoCB";
            this.filtroTipoCB.Size = new System.Drawing.Size(183, 28);
            this.filtroTipoCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de pesquisa:";
            // 
            // filtroValorTbox
            // 
            this.filtroValorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.filtroValorTbox.Location = new System.Drawing.Point(180, 58);
            this.filtroValorTbox.Name = "filtroValorTbox";
            this.filtroValorTbox.Size = new System.Drawing.Size(183, 26);
            this.filtroValorTbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(85, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor do filtro:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(480, 50);
            this.label6.TabIndex = 44;
            this.label6.Text = "Pesquisa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 50);
            this.label3.TabIndex = 47;
            this.label3.Text = "Edição";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.EditarBtn,
            this.COD_PROPRIETARIO,
            this.NOME_PROPRIETARIO,
            this.DAT_NASCIMENTO_PROPRIETARIO,
            this.SEXO_PROPRIETARIO,
            this.RG_PROPRIETARIO,
            this.CPF_PROPRIETARIO,
            this.CNPJ_PROPRIETARIO,
            this.END_UF_PROPRIETARIO,
            this.END_CIDADE_PROPRIETARIO,
            this.END_BAIRRO_PROPRIETARIO,
            this.END_RUA_PROPRIETARIO,
            this.END_NUM_PROPRIETARIO,
            this.NUM_APARTAMENTO,
            this.ID_PREDIO,
            this.ID_BLOCO,
            this.ID_CONDOMINIO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pesquisaList.DefaultCellStyle = dataGridViewCellStyle2;
            this.pesquisaList.Location = new System.Drawing.Point(18, 211);
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
            this.pesquisaList.Size = new System.Drawing.Size(441, 200);
            this.pesquisaList.TabIndex = 48;
            // 
            // EditarBtn
            // 
            this.EditarBtn.HeaderText = "Editar";
            this.EditarBtn.MinimumWidth = 68;
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.ReadOnly = true;
            this.EditarBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditarBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseColumnTextForButtonValue = true;
            this.EditarBtn.Width = 68;
            // 
            // COD_PROPRIETARIO
            // 
            this.COD_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COD_PROPRIETARIO.HeaderText = "Código";
            this.COD_PROPRIETARIO.MinimumWidth = 80;
            this.COD_PROPRIETARIO.Name = "COD_PROPRIETARIO";
            this.COD_PROPRIETARIO.ReadOnly = true;
            this.COD_PROPRIETARIO.Visible = false;
            // 
            // NOME_PROPRIETARIO
            // 
            this.NOME_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOME_PROPRIETARIO.HeaderText = "Nome";
            this.NOME_PROPRIETARIO.MinimumWidth = 160;
            this.NOME_PROPRIETARIO.Name = "NOME_PROPRIETARIO";
            this.NOME_PROPRIETARIO.ReadOnly = true;
            this.NOME_PROPRIETARIO.Width = 160;
            // 
            // DAT_NASCIMENTO_PROPRIETARIO
            // 
            this.DAT_NASCIMENTO_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DAT_NASCIMENTO_PROPRIETARIO.HeaderText = "Data de Nascimento";
            this.DAT_NASCIMENTO_PROPRIETARIO.Name = "DAT_NASCIMENTO_PROPRIETARIO";
            this.DAT_NASCIMENTO_PROPRIETARIO.ReadOnly = true;
            this.DAT_NASCIMENTO_PROPRIETARIO.Width = 141;
            // 
            // SEXO_PROPRIETARIO
            // 
            this.SEXO_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SEXO_PROPRIETARIO.HeaderText = "Sexo";
            this.SEXO_PROPRIETARIO.Name = "SEXO_PROPRIETARIO";
            this.SEXO_PROPRIETARIO.ReadOnly = true;
            this.SEXO_PROPRIETARIO.Width = 66;
            // 
            // RG_PROPRIETARIO
            // 
            this.RG_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RG_PROPRIETARIO.HeaderText = "RG";
            this.RG_PROPRIETARIO.Name = "RG_PROPRIETARIO";
            this.RG_PROPRIETARIO.ReadOnly = true;
            this.RG_PROPRIETARIO.Width = 53;
            // 
            // CPF_PROPRIETARIO
            // 
            this.CPF_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPF_PROPRIETARIO.HeaderText = "CPF";
            this.CPF_PROPRIETARIO.Name = "CPF_PROPRIETARIO";
            this.CPF_PROPRIETARIO.ReadOnly = true;
            this.CPF_PROPRIETARIO.Width = 60;
            // 
            // CNPJ_PROPRIETARIO
            // 
            this.CNPJ_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CNPJ_PROPRIETARIO.HeaderText = "CNPJ";
            this.CNPJ_PROPRIETARIO.Name = "CNPJ_PROPRIETARIO";
            this.CNPJ_PROPRIETARIO.ReadOnly = true;
            this.CNPJ_PROPRIETARIO.Width = 68;
            // 
            // END_UF_PROPRIETARIO
            // 
            this.END_UF_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.END_UF_PROPRIETARIO.HeaderText = "End: Estado";
            this.END_UF_PROPRIETARIO.Name = "END_UF_PROPRIETARIO";
            this.END_UF_PROPRIETARIO.ReadOnly = true;
            this.END_UF_PROPRIETARIO.Width = 99;
            // 
            // END_CIDADE_PROPRIETARIO
            // 
            this.END_CIDADE_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.END_CIDADE_PROPRIETARIO.HeaderText = "End: Cidade";
            this.END_CIDADE_PROPRIETARIO.Name = "END_CIDADE_PROPRIETARIO";
            this.END_CIDADE_PROPRIETARIO.ReadOnly = true;
            // 
            // END_BAIRRO_PROPRIETARIO
            // 
            this.END_BAIRRO_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.END_BAIRRO_PROPRIETARIO.HeaderText = "End: Bairro";
            this.END_BAIRRO_PROPRIETARIO.Name = "END_BAIRRO_PROPRIETARIO";
            this.END_BAIRRO_PROPRIETARIO.ReadOnly = true;
            this.END_BAIRRO_PROPRIETARIO.Width = 93;
            // 
            // END_RUA_PROPRIETARIO
            // 
            this.END_RUA_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.END_RUA_PROPRIETARIO.HeaderText = "End: Rua";
            this.END_RUA_PROPRIETARIO.Name = "END_RUA_PROPRIETARIO";
            this.END_RUA_PROPRIETARIO.ReadOnly = true;
            this.END_RUA_PROPRIETARIO.Width = 82;
            // 
            // END_NUM_PROPRIETARIO
            // 
            this.END_NUM_PROPRIETARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.END_NUM_PROPRIETARIO.HeaderText = "End: Número";
            this.END_NUM_PROPRIETARIO.Name = "END_NUM_PROPRIETARIO";
            this.END_NUM_PROPRIETARIO.ReadOnly = true;
            this.END_NUM_PROPRIETARIO.Width = 104;
            // 
            // NUM_APARTAMENTO
            // 
            this.NUM_APARTAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NUM_APARTAMENTO.HeaderText = "Apartamento";
            this.NUM_APARTAMENTO.Name = "NUM_APARTAMENTO";
            this.NUM_APARTAMENTO.ReadOnly = true;
            this.NUM_APARTAMENTO.Width = 109;
            // 
            // ID_PREDIO
            // 
            this.ID_PREDIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_PREDIO.HeaderText = "Prédio";
            this.ID_PREDIO.Name = "ID_PREDIO";
            this.ID_PREDIO.ReadOnly = true;
            this.ID_PREDIO.Width = 74;
            // 
            // ID_BLOCO
            // 
            this.ID_BLOCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_BLOCO.HeaderText = "Bloco";
            this.ID_BLOCO.Name = "ID_BLOCO";
            this.ID_BLOCO.ReadOnly = true;
            this.ID_BLOCO.Width = 69;
            // 
            // ID_CONDOMINIO
            // 
            this.ID_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_CONDOMINIO.HeaderText = "Condomínio";
            this.ID_CONDOMINIO.Name = "ID_CONDOMINIO";
            this.ID_CONDOMINIO.ReadOnly = true;
            this.ID_CONDOMINIO.Width = 106;
            // 
            // Pesquisa_MoradoresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pesquisaList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "Pesquisa_MoradoresUC";
            this.Size = new System.Drawing.Size(480, 658);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox filtroTipoCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroValorTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView pesquisaList;
        private System.Windows.Forms.DataGridViewButtonColumn EditarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAT_NASCIMENTO_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_UF_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_CIDADE_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_BAIRRO_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_RUA_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_NUM_PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONDOMINIO;
    }
}
