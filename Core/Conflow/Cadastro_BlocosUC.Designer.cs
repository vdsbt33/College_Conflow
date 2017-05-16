namespace Conflow
{
    partial class Cadastro_BlocosUC
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
            this.qtdPrediosNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LerBtn = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.ID_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTD_PREDIOS_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.condominioList = new System.Windows.Forms.ListBox();
            this.CriarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtdPrediosNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.localizacaoGB.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.label6.Size = new System.Drawing.Size(651, 50);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cadastro de Bloco";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Identificador:";
            // 
            // identificadorTbox
            // 
            this.identificadorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.identificadorTbox.Location = new System.Drawing.Point(112, 66);
            this.identificadorTbox.Name = "identificadorTbox";
            this.identificadorTbox.Size = new System.Drawing.Size(152, 26);
            this.identificadorTbox.TabIndex = 45;
            // 
            // qtdPrediosNud
            // 
            this.qtdPrediosNud.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.qtdPrediosNud.Location = new System.Drawing.Point(115, 104);
            this.qtdPrediosNud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.qtdPrediosNud.Name = "qtdPrediosNud";
            this.qtdPrediosNud.Size = new System.Drawing.Size(115, 26);
            this.qtdPrediosNud.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Qtd. prédios:";
            // 
            // LerBtn
            // 
            this.LerBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LerBtn.Location = new System.Drawing.Point(429, 226);
            this.LerBtn.Name = "LerBtn";
            this.LerBtn.Size = new System.Drawing.Size(125, 29);
            this.LerBtn.TabIndex = 56;
            this.LerBtn.Text = "Atualizar";
            this.LerBtn.UseVisualStyleBackColor = true;
            this.LerBtn.Click += new System.EventHandler(this.LerBtn_Click);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_BLOCO,
            this.QTD_PREDIOS_BLOCO});
            this.dgView.Location = new System.Drawing.Point(346, 66);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(295, 154);
            this.dgView.TabIndex = 57;
            this.dgView.TabStop = false;
            // 
            // ID_BLOCO
            // 
            this.ID_BLOCO.HeaderText = "Identificador";
            this.ID_BLOCO.Name = "ID_BLOCO";
            // 
            // QTD_PREDIOS_BLOCO
            // 
            this.QTD_PREDIOS_BLOCO.HeaderText = "Qtd. predios";
            this.QTD_PREDIOS_BLOCO.Name = "QTD_PREDIOS_BLOCO";
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.tabControl);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(14, 149);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 212);
            this.localizacaoGB.TabIndex = 58;
            this.localizacaoGB.TabStop = false;
            this.localizacaoGB.Text = "Localização";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
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
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(133, 371);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 59;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // Cadastro_BlocosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CriarBtn);
            this.Controls.Add(this.localizacaoGB);
            this.Controls.Add(this.LerBtn);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.qtdPrediosNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identificadorTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Cadastro_BlocosUC";
            this.Size = new System.Drawing.Size(651, 417);
            this.Load += new System.EventHandler(this.Cadastro_BlocosUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtdPrediosNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.localizacaoGB.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox identificadorTbox;
        private System.Windows.Forms.NumericUpDown qtdPrediosNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LerBtn;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox condominioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTD_PREDIOS_BLOCO;
        private System.Windows.Forms.Button CriarBtn;
    }
}
