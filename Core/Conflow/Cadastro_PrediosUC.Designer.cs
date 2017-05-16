namespace Conflow
{
    partial class Cadastro_PrediosUC
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.identificadorTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qtdApartamentosNud = new System.Windows.Forms.NumericUpDown();
            this.valorMensalidadeNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LerBtn = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.ID_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTD_APARTAMENTOS_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAL_MENSALIDADES_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAL_FRACAO_IDEAL_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.condominioList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.blocoList = new System.Windows.Forms.ListBox();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.qtdApartamentosNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorMensalidadeNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.localizacaoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(655, 50);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cadastro de Prédio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Identificador:";
            // 
            // identificadorTbox
            // 
            this.identificadorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.identificadorTbox.Location = new System.Drawing.Point(112, 66);
            this.identificadorTbox.Name = "identificadorTbox";
            this.identificadorTbox.Size = new System.Drawing.Size(152, 26);
            this.identificadorTbox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Qtd. apartamentos:";
            // 
            // qtdApartamentosNud
            // 
            this.qtdApartamentosNud.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.qtdApartamentosNud.Location = new System.Drawing.Point(149, 114);
            this.qtdApartamentosNud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.qtdApartamentosNud.Name = "qtdApartamentosNud";
            this.qtdApartamentosNud.Size = new System.Drawing.Size(115, 26);
            this.qtdApartamentosNud.TabIndex = 46;
            // 
            // valorMensalidadeNud
            // 
            this.valorMensalidadeNud.DecimalPlaces = 2;
            this.valorMensalidadeNud.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.valorMensalidadeNud.Location = new System.Drawing.Point(180, 158);
            this.valorMensalidadeNud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.valorMensalidadeNud.Name = "valorMensalidadeNud";
            this.valorMensalidadeNud.Size = new System.Drawing.Size(115, 26);
            this.valorMensalidadeNud.TabIndex = 48;
            this.valorMensalidadeNud.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Valor mensalidade (R$):";
            // 
            // LerBtn
            // 
            this.LerBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LerBtn.Location = new System.Drawing.Point(429, 226);
            this.LerBtn.Name = "LerBtn";
            this.LerBtn.Size = new System.Drawing.Size(125, 29);
            this.LerBtn.TabIndex = 49;
            this.LerBtn.Text = "Atualizar";
            this.LerBtn.UseVisualStyleBackColor = true;
            this.LerBtn.Click += new System.EventHandler(this.LerBtn_Click);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PREDIO,
            this.QTD_APARTAMENTOS_PREDIO,
            this.VAL_MENSALIDADES_PREDIO,
            this.VAL_FRACAO_IDEAL_PREDIO});
            this.dgView.Location = new System.Drawing.Point(340, 64);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(295, 154);
            this.dgView.TabIndex = 50;
            this.dgView.TabStop = false;
            // 
            // ID_PREDIO
            // 
            this.ID_PREDIO.HeaderText = "Identificador";
            this.ID_PREDIO.Name = "ID_PREDIO";
            // 
            // QTD_APARTAMENTOS_PREDIO
            // 
            this.QTD_APARTAMENTOS_PREDIO.HeaderText = "Qtd. apartamentos";
            this.QTD_APARTAMENTOS_PREDIO.Name = "QTD_APARTAMENTOS_PREDIO";
            // 
            // VAL_MENSALIDADES_PREDIO
            // 
            this.VAL_MENSALIDADES_PREDIO.HeaderText = "Valor mensalidades:";
            this.VAL_MENSALIDADES_PREDIO.Name = "VAL_MENSALIDADES_PREDIO";
            // 
            // VAL_FRACAO_IDEAL_PREDIO
            // 
            this.VAL_FRACAO_IDEAL_PREDIO.HeaderText = "Valor fração ideal:";
            this.VAL_FRACAO_IDEAL_PREDIO.Name = "VAL_FRACAO_IDEAL_PREDIO";
            // 
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(132, 459);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 51;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tabControl.Location = new System.Drawing.Point(11, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(302, 166);
            this.tabControl.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.condominioList);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(294, 133);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Condomínio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // condominioList
            // 
            this.condominioList.FormattingEnabled = true;
            this.condominioList.ItemHeight = 20;
            this.condominioList.Location = new System.Drawing.Point(6, 6);
            this.condominioList.Name = "condominioList";
            this.condominioList.Size = new System.Drawing.Size(282, 104);
            this.condominioList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.blocoList);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 133);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bloco";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // blocoList
            // 
            this.blocoList.FormattingEnabled = true;
            this.blocoList.ItemHeight = 20;
            this.blocoList.Location = new System.Drawing.Point(6, 6);
            this.blocoList.Name = "blocoList";
            this.blocoList.Size = new System.Drawing.Size(282, 104);
            this.blocoList.TabIndex = 1;
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.tabControl);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(14, 237);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 212);
            this.localizacaoGB.TabIndex = 55;
            this.localizacaoGB.TabStop = false;
            this.localizacaoGB.Text = "Localização";
            // 
            // Cadastro_PrediosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.localizacaoGB);
            this.Controls.Add(this.CriarBtn);
            this.Controls.Add(this.LerBtn);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.valorMensalidadeNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qtdApartamentosNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identificadorTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Cadastro_PrediosUC";
            this.Size = new System.Drawing.Size(655, 502);
            this.Load += new System.EventHandler(this.Cadastro_PrediosUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtdApartamentosNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorMensalidadeNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.localizacaoGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox identificadorTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qtdApartamentosNud;
        private System.Windows.Forms.NumericUpDown valorMensalidadeNud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LerBtn;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTD_APARTAMENTOS_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAL_MENSALIDADES_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAL_FRACAO_IDEAL_PREDIO;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox condominioList;
        private System.Windows.Forms.ListBox blocoList;
        private System.Windows.Forms.GroupBox localizacaoGB;
    }
}
