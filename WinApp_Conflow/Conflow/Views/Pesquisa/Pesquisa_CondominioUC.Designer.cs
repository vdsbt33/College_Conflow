namespace Conflow
{
    partial class Pesquisa_CondominioUC
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
            this.pesquisaList = new System.Windows.Forms.DataGridView();
            this.P_ExcluirBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.P_COD_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_QTD_BLOCOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.filtroTipoCoB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroValorTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.P_ExcluirBtn,
            this.P_COD_CONDOMINIO,
            this.P_ID_CONDOMINIO,
            this.P_QTD_BLOCOS});
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
            this.pesquisaList.TabIndex = 52;
            this.pesquisaList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pesquisaList_CellClick);
            // 
            // P_ExcluirBtn
            // 
            this.P_ExcluirBtn.HeaderText = "Excluir";
            this.P_ExcluirBtn.MinimumWidth = 68;
            this.P_ExcluirBtn.Name = "P_ExcluirBtn";
            this.P_ExcluirBtn.ReadOnly = true;
            this.P_ExcluirBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.P_ExcluirBtn.Text = "Excluir";
            this.P_ExcluirBtn.UseColumnTextForButtonValue = true;
            this.P_ExcluirBtn.Width = 68;
            // 
            // P_COD_CONDOMINIO
            // 
            this.P_COD_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_COD_CONDOMINIO.HeaderText = "Código";
            this.P_COD_CONDOMINIO.MinimumWidth = 80;
            this.P_COD_CONDOMINIO.Name = "P_COD_CONDOMINIO";
            this.P_COD_CONDOMINIO.ReadOnly = true;
            this.P_COD_CONDOMINIO.Visible = false;
            // 
            // P_ID_CONDOMINIO
            // 
            this.P_ID_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.P_ID_CONDOMINIO.HeaderText = "Nome";
            this.P_ID_CONDOMINIO.MinimumWidth = 160;
            this.P_ID_CONDOMINIO.Name = "P_ID_CONDOMINIO";
            this.P_ID_CONDOMINIO.ReadOnly = true;
            // 
            // P_QTD_BLOCOS
            // 
            this.P_QTD_BLOCOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_QTD_BLOCOS.HeaderText = "Qtd. Blocos";
            this.P_QTD_BLOCOS.Name = "P_QTD_BLOCOS";
            this.P_QTD_BLOCOS.ReadOnly = true;
            this.P_QTD_BLOCOS.Width = 105;
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
            this.label6.TabIndex = 50;
            this.label6.Text = "Pesquisar Condomínio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pesquisarBtn.Click += new System.EventHandler(this.pesquisarBtn_Click);
            // 
            // filtroTipoCoB
            // 
            this.filtroTipoCoB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroTipoCoB.FormattingEnabled = true;
            this.filtroTipoCoB.Items.AddRange(new object[] {
            "Identificador"});
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pesquisarBtn);
            this.groupBox1.Controls.Add(this.filtroTipoCoB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filtroValorTbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox1.Location = new System.Drawing.Point(160, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 165);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // Pesquisa_CondominioUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pesquisaList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pesquisa_CondominioUC";
            this.Size = new System.Drawing.Size(773, 460);
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView pesquisaList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.ComboBox filtroTipoCoB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroValorTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn P_ExcluirBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_COD_CONDOMINIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID_CONDOMINIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_QTD_BLOCOS;
    }
}
