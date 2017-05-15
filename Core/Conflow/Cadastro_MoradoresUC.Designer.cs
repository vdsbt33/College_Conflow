namespace Conflow
{
    partial class Cadastro_MoradoresUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_MoradoresUC));
            this.label6 = new System.Windows.Forms.Label();
            this.pessoaJuridicaRb = new System.Windows.Forms.RadioButton();
            this.pessoaFisicaRb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cpfRgPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgTbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroestacionamentoNud = new System.Windows.Forms.NumericUpDown();
            this.datanascimentoDtp = new System.Windows.Forms.DateTimePicker();
            this.nomeTbox = new System.Windows.Forms.TextBox();
            this.LerBtn = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NOME_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAT_NASCIMENTO_MORADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numeroestacionamentoNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(660, 50);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cadastro de Morador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pessoaJuridicaRb
            // 
            this.pessoaJuridicaRb.AutoSize = true;
            this.pessoaJuridicaRb.BackColor = System.Drawing.Color.Transparent;
            this.pessoaJuridicaRb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaJuridicaRb.Location = new System.Drawing.Point(182, 186);
            this.pessoaJuridicaRb.Name = "pessoaJuridicaRb";
            this.pessoaJuridicaRb.Size = new System.Drawing.Size(123, 24);
            this.pessoaJuridicaRb.TabIndex = 4;
            this.pessoaJuridicaRb.TabStop = true;
            this.pessoaJuridicaRb.Text = "Pessoa Jurídica";
            this.pessoaJuridicaRb.UseVisualStyleBackColor = false;
            this.pessoaJuridicaRb.CheckedChanged += new System.EventHandler(this.pessoaJuridicaRb_CheckedChanged);
            // 
            // pessoaFisicaRb
            // 
            this.pessoaFisicaRb.AutoSize = true;
            this.pessoaFisicaRb.BackColor = System.Drawing.Color.Transparent;
            this.pessoaFisicaRb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaFisicaRb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pessoaFisicaRb.Location = new System.Drawing.Point(21, 186);
            this.pessoaFisicaRb.Name = "pessoaFisicaRb";
            this.pessoaFisicaRb.Size = new System.Drawing.Size(112, 24);
            this.pessoaFisicaRb.TabIndex = 3;
            this.pessoaFisicaRb.TabStop = true;
            this.pessoaFisicaRb.Text = "Pessoa Física";
            this.pessoaFisicaRb.UseVisualStyleBackColor = false;
            this.pessoaFisicaRb.CheckedChanged += new System.EventHandler(this.pessoaFisicaRb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Escolha o tipo de morador:";
            // 
            // cpfRgPanel
            // 
            this.cpfRgPanel.Location = new System.Drawing.Point(21, 217);
            this.cpfRgPanel.Name = "cpfRgPanel";
            this.cpfRgPanel.Size = new System.Drawing.Size(284, 55);
            this.cpfRgPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Número do estacionamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data de nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "RG:";
            // 
            // rgTbox
            // 
            this.rgTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTbox.Location = new System.Drawing.Point(59, 108);
            this.rgTbox.Mask = "000.000.000-0";
            this.rgTbox.Name = "rgTbox";
            this.rgTbox.Size = new System.Drawing.Size(136, 26);
            this.rgTbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome:";
            // 
            // numeroestacionamentoNud
            // 
            this.numeroestacionamentoNud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroestacionamentoNud.Location = new System.Drawing.Point(205, 335);
            this.numeroestacionamentoNud.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeroestacionamentoNud.Name = "numeroestacionamentoNud";
            this.numeroestacionamentoNud.Size = new System.Drawing.Size(100, 26);
            this.numeroestacionamentoNud.TabIndex = 7;
            // 
            // datanascimentoDtp
            // 
            this.datanascimentoDtp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanascimentoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascimentoDtp.Location = new System.Drawing.Point(158, 291);
            this.datanascimentoDtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datanascimentoDtp.Name = "datanascimentoDtp";
            this.datanascimentoDtp.Size = new System.Drawing.Size(147, 26);
            this.datanascimentoDtp.TabIndex = 6;
            // 
            // nomeTbox
            // 
            this.nomeTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTbox.Location = new System.Drawing.Point(76, 64);
            this.nomeTbox.Name = "nomeTbox";
            this.nomeTbox.Size = new System.Drawing.Size(229, 26);
            this.nomeTbox.TabIndex = 1;
            // 
            // LerBtn
            // 
            this.LerBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LerBtn.Location = new System.Drawing.Point(423, 224);
            this.LerBtn.Name = "LerBtn";
            this.LerBtn.Size = new System.Drawing.Size(125, 29);
            this.LerBtn.TabIndex = 9;
            this.LerBtn.Text = "Atualizar";
            this.LerBtn.UseVisualStyleBackColor = true;
            this.LerBtn.Click += new System.EventHandler(this.LerBtn_Click);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME_MORADOR,
            this.RG_MORADOR,
            this.CPF_MORADOR,
            this.DAT_NASCIMENTO_MORADOR});
            this.dgView.Location = new System.Drawing.Point(340, 64);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(295, 154);
            this.dgView.TabIndex = 26;
            this.dgView.TabStop = false;
            // 
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(111, 388);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 8;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(21, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // NOME_MORADOR
            // 
            this.NOME_MORADOR.HeaderText = "Nome";
            this.NOME_MORADOR.Name = "NOME_MORADOR";
            // 
            // RG_MORADOR
            // 
            this.RG_MORADOR.HeaderText = "RG";
            this.RG_MORADOR.Name = "RG_MORADOR";
            // 
            // CPF_MORADOR
            // 
            this.CPF_MORADOR.HeaderText = "CPF/CNPJ";
            this.CPF_MORADOR.Name = "CPF_MORADOR";
            // 
            // DAT_NASCIMENTO_MORADOR
            // 
            this.DAT_NASCIMENTO_MORADOR.HeaderText = "Data de Nascimento";
            this.DAT_NASCIMENTO_MORADOR.Name = "DAT_NASCIMENTO_MORADOR";
            // 
            // Cadastro_MoradoresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pessoaJuridicaRb);
            this.Controls.Add(this.pessoaFisicaRb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpfRgPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rgTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroestacionamentoNud);
            this.Controls.Add(this.datanascimentoDtp);
            this.Controls.Add(this.nomeTbox);
            this.Controls.Add(this.LerBtn);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.CriarBtn);
            this.Name = "Cadastro_MoradoresUC";
            this.Size = new System.Drawing.Size(655, 431);
            this.Load += new System.EventHandler(this.Cadastro_MoradoresUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroestacionamentoNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton pessoaJuridicaRb;
        private System.Windows.Forms.RadioButton pessoaFisicaRb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel cpfRgPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox rgTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeroestacionamentoNud;
        private System.Windows.Forms.DateTimePicker datanascimentoDtp;
        private System.Windows.Forms.TextBox nomeTbox;
        private System.Windows.Forms.Button LerBtn;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_MORADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAT_NASCIMENTO_MORADOR;
    }
}
