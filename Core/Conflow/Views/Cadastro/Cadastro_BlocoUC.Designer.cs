namespace Conflow
{
    partial class Cadastro_BlocoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_BlocoUC));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.identificadorTbox = new System.Windows.Forms.TextBox();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.condominioList = new System.Windows.Forms.DataGridView();
            this.COD_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.localizacaoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condominioList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.label6.TabIndex = 0;
            this.label6.Text = "Cadastro de Bloco";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // identificadorTbox
            // 
            this.identificadorTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.identificadorTbox.Location = new System.Drawing.Point(105, 92);
            this.identificadorTbox.Name = "identificadorTbox";
            this.identificadorTbox.Size = new System.Drawing.Size(235, 26);
            this.identificadorTbox.TabIndex = 1;
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.condominioList);
            this.localizacaoGB.Controls.Add(this.label4);
            this.localizacaoGB.Controls.Add(this.pictureBox1);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(14, 129);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 273);
            this.localizacaoGB.TabIndex = 1;
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
            this.condominioList.StandardTab = true;
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
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(133, 411);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 3;
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
            this.label7.TabIndex = 0;
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
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // Cadastro_BlocoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CriarBtn);
            this.Controls.Add(this.localizacaoGB);
            this.Controls.Add(this.identificadorTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Cadastro_BlocoUC";
            this.Size = new System.Drawing.Size(355, 453);
            this.localizacaoGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.condominioList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox identificadorTbox;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView condominioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONDOMINIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONDOMINIO;
    }
}
