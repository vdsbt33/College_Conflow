namespace Conflow
{
    partial class Cadastro_MoradorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_MoradorUC));
            this.sexoFRBtn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.sexoMRBtn = new System.Windows.Forms.RadioButton();
            this.predioList = new System.Windows.Forms.DataGridView();
            this.COD_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PREDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentoList = new System.Windows.Forms.DataGridView();
            this.COD_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_APARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.condominioList = new System.Windows.Forms.DataGridView();
            this.COD_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sexoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.datanascimentoDtp = new System.Windows.Forms.DateTimePicker();
            this.nomeTbox = new System.Windows.Forms.TextBox();
            this.CriarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.predioList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.localizacaoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.condominioList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sexoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sexoFRBtn
            // 
            this.sexoFRBtn.AutoSize = true;
            this.sexoFRBtn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.sexoFRBtn.Location = new System.Drawing.Point(175, 5);
            this.sexoFRBtn.Name = "sexoFRBtn";
            this.sexoFRBtn.Size = new System.Drawing.Size(82, 24);
            this.sexoFRBtn.TabIndex = 3;
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
            this.sexoMRBtn.TabIndex = 2;
            this.sexoMRBtn.TabStop = true;
            this.sexoMRBtn.Text = "Masculino";
            this.sexoMRBtn.UseVisualStyleBackColor = true;
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
            this.predioList.Location = new System.Drawing.Point(11, 255);
            this.predioList.MultiSelect = false;
            this.predioList.Name = "predioList";
            this.predioList.ReadOnly = true;
            this.predioList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.predioList.ShowCellToolTips = false;
            this.predioList.Size = new System.Drawing.Size(304, 137);
            this.predioList.StandardTab = true;
            this.predioList.TabIndex = 5;
            this.predioList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.predioList_RowEnter);
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
            this.apartamentoList.Location = new System.Drawing.Point(11, 411);
            this.apartamentoList.MultiSelect = false;
            this.apartamentoList.Name = "apartamentoList";
            this.apartamentoList.ReadOnly = true;
            this.apartamentoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apartamentoList.ShowCellToolTips = false;
            this.apartamentoList.Size = new System.Drawing.Size(304, 175);
            this.apartamentoList.StandardTab = true;
            this.apartamentoList.TabIndex = 6;
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
            this.label8.Location = new System.Drawing.Point(46, 27);
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
            this.pictureBox3.Location = new System.Drawing.Point(16, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 50);
            this.label6.TabIndex = 65;
            this.label6.Text = "Cadastro de Morador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.condominioList);
            this.localizacaoGB.Controls.Add(this.predioList);
            this.localizacaoGB.Controls.Add(this.apartamentoList);
            this.localizacaoGB.Controls.Add(this.label8);
            this.localizacaoGB.Controls.Add(this.pictureBox3);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(10, 248);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 598);
            this.localizacaoGB.TabIndex = 72;
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
            this.condominioList.Location = new System.Drawing.Point(11, 98);
            this.condominioList.MultiSelect = false;
            this.condominioList.Name = "condominioList";
            this.condominioList.ReadOnly = true;
            this.condominioList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.condominioList.ShowCellToolTips = false;
            this.condominioList.Size = new System.Drawing.Size(304, 137);
            this.condominioList.TabIndex = 64;
            this.condominioList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.condominioList_RowEnter);
            // 
            // COD_CONDOMINIO
            // 
            this.COD_CONDOMINIO.HeaderText = "Código do Condomínio";
            this.COD_CONDOMINIO.Name = "COD_CONDOMINIO";
            this.COD_CONDOMINIO.ReadOnly = true;
            this.COD_CONDOMINIO.Visible = false;
            this.COD_CONDOMINIO.Width = 174;
            // 
            // ID_CONDOMINIO
            // 
            this.ID_CONDOMINIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_CONDOMINIO.HeaderText = "Condominio";
            this.ID_CONDOMINIO.MinimumWidth = 200;
            this.ID_CONDOMINIO.Name = "ID_CONDOMINIO";
            this.ID_CONDOMINIO.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 66;
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
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Data de nascimento:";
            // 
            // sexoPanel
            // 
            this.sexoPanel.Controls.Add(this.sexoFRBtn);
            this.sexoPanel.Controls.Add(this.label9);
            this.sexoPanel.Controls.Add(this.sexoMRBtn);
            this.sexoPanel.Location = new System.Drawing.Point(10, 149);
            this.sexoPanel.Name = "sexoPanel";
            this.sexoPanel.Size = new System.Drawing.Size(258, 35);
            this.sexoPanel.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nome:";
            // 
            // datanascimentoDtp
            // 
            this.datanascimentoDtp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanascimentoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascimentoDtp.Location = new System.Drawing.Point(152, 198);
            this.datanascimentoDtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datanascimentoDtp.Name = "datanascimentoDtp";
            this.datanascimentoDtp.Size = new System.Drawing.Size(166, 26);
            this.datanascimentoDtp.TabIndex = 4;
            // 
            // nomeTbox
            // 
            this.nomeTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTbox.Location = new System.Drawing.Point(73, 111);
            this.nomeTbox.Name = "nomeTbox";
            this.nomeTbox.Size = new System.Drawing.Size(248, 26);
            this.nomeTbox.TabIndex = 1;
            // 
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(119, 868);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 39);
            this.CriarBtn.TabIndex = 74;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // Cadastro_MoradorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.localizacaoGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sexoPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datanascimentoDtp);
            this.Controls.Add(this.nomeTbox);
            this.Controls.Add(this.CriarBtn);
            this.Name = "Cadastro_MoradorUC";
            this.Size = new System.Drawing.Size(361, 918);
            ((System.ComponentModel.ISupportInitialize)(this.predioList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.localizacaoGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.condominioList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sexoPanel.ResumeLayout(false);
            this.sexoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sexoFRBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton sexoMRBtn;
        private System.Windows.Forms.DataGridView predioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PREDIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PREDIO;
        private System.Windows.Forms.DataGridView apartamentoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_APARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_APARTAMENTO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel sexoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datanascimentoDtp;
        private System.Windows.Forms.TextBox nomeTbox;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.DataGridView condominioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CONDOMINIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONDOMINIO;
    }
}
