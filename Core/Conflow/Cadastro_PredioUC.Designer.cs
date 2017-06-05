namespace Conflow
{
    partial class Cadastro_PredioUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_PredioUC));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.identificadorTbox = new System.Windows.Forms.TextBox();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qtdAPAndarNud = new System.Windows.Forms.NumericUpDown();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.blocoList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qtdAndaresNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.COD_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BLOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdAPAndarNud)).BeginInit();
            this.localizacaoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blocoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdAndaresNud)).BeginInit();
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
            this.label6.Size = new System.Drawing.Size(355, 50);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cadastro de Prédio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Identificador:";
            // 
            // identificadorTbox
            // 
            this.identificadorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.identificadorTbox.Location = new System.Drawing.Point(105, 91);
            this.identificadorTbox.Name = "identificadorTbox";
            this.identificadorTbox.Size = new System.Drawing.Size(215, 26);
            this.identificadorTbox.TabIndex = 44;
            // 
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(132, 507);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 51;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "É obrigatório preencher todos os campos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(21, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Qtd. apartamentos por andar:";
            // 
            // qtdAPAndarNud
            // 
            this.qtdAPAndarNud.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.qtdAPAndarNud.Location = new System.Drawing.Point(203, 136);
            this.qtdAPAndarNud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.qtdAPAndarNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdAPAndarNud.Name = "qtdAPAndarNud";
            this.qtdAPAndarNud.Size = new System.Drawing.Size(115, 26);
            this.qtdAPAndarNud.TabIndex = 46;
            this.qtdAPAndarNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.blocoList);
            this.localizacaoGB.Controls.Add(this.label4);
            this.localizacaoGB.Controls.Add(this.pictureBox1);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(14, 212);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 273);
            this.localizacaoGB.TabIndex = 61;
            this.localizacaoGB.TabStop = false;
            this.localizacaoGB.Text = "Localização";
            // 
            // blocoList
            // 
            this.blocoList.AllowUserToAddRows = false;
            this.blocoList.AllowUserToDeleteRows = false;
            this.blocoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.blocoList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.blocoList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.blocoList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blocoList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.blocoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blocoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_BLOCO,
            this.ID_BLOCO,
            this.ID_CONDOMINIO});
            this.blocoList.Location = new System.Drawing.Point(11, 87);
            this.blocoList.MultiSelect = false;
            this.blocoList.Name = "blocoList";
            this.blocoList.ReadOnly = true;
            this.blocoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blocoList.ShowCellToolTips = false;
            this.blocoList.Size = new System.Drawing.Size(304, 175);
            this.blocoList.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selecione o Bloco ao qual esse prédio pertence";
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
            // qtdAndaresNud
            // 
            this.qtdAndaresNud.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.qtdAndaresNud.Location = new System.Drawing.Point(110, 176);
            this.qtdAndaresNud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.qtdAndaresNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdAndaresNud.Name = "qtdAndaresNud";
            this.qtdAndaresNud.Size = new System.Drawing.Size(115, 26);
            this.qtdAndaresNud.TabIndex = 63;
            this.qtdAndaresNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.Location = new System.Drawing.Point(14, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Qtd. andares:";
            // 
            // COD_BLOCO
            // 
            this.COD_BLOCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COD_BLOCO.HeaderText = "Código";
            this.COD_BLOCO.MinimumWidth = 80;
            this.COD_BLOCO.Name = "COD_BLOCO";
            this.COD_BLOCO.ReadOnly = true;
            this.COD_BLOCO.Visible = false;
            this.COD_BLOCO.Width = 80;
            // 
            // ID_BLOCO
            // 
            this.ID_BLOCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_BLOCO.HeaderText = "Identificador";
            this.ID_BLOCO.MinimumWidth = 160;
            this.ID_BLOCO.Name = "ID_BLOCO";
            this.ID_BLOCO.ReadOnly = true;
            this.ID_BLOCO.Width = 160;
            // 
            // ID_CONDOMINIO
            // 
            this.ID_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_CONDOMINIO.HeaderText = "Bloco que pertence";
            this.ID_CONDOMINIO.MinimumWidth = 160;
            this.ID_CONDOMINIO.Name = "ID_CONDOMINIO";
            this.ID_CONDOMINIO.ReadOnly = true;
            // 
            // Cadastro_PrediosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.qtdAndaresNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localizacaoGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CriarBtn);
            this.Controls.Add(this.qtdAPAndarNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identificadorTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Cadastro_PrediosUC";
            this.Size = new System.Drawing.Size(355, 549);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdAPAndarNud)).EndInit();
            this.localizacaoGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blocoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdAndaresNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox identificadorTbox;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qtdAPAndarNud;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView blocoList;
        private System.Windows.Forms.NumericUpDown qtdAndaresNud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BLOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONDOMINIO;
    }
}
