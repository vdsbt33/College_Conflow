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
            this.CriarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.localizacaoGB = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCondominio = new System.Windows.Forms.TabPage();
            this.condominioLB = new System.Windows.Forms.ListBox();
            this.tabBloco = new System.Windows.Forms.TabPage();
            this.blocoLB = new System.Windows.Forms.ListBox();
            this.tabPredio = new System.Windows.Forms.TabPage();
            this.predioLB = new System.Windows.Forms.ListBox();
            this.tabApartamento = new System.Windows.Forms.TabPage();
            this.apartamentoLB = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeroestacionamentoNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.localizacaoGB.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabCondominio.SuspendLayout();
            this.tabBloco.SuspendLayout();
            this.tabPredio.SuspendLayout();
            this.tabApartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.label6.Size = new System.Drawing.Size(694, 50);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cadastro de Morador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pessoaJuridicaRb
            // 
            this.pessoaJuridicaRb.AutoSize = true;
            this.pessoaJuridicaRb.BackColor = System.Drawing.Color.Transparent;
            this.pessoaJuridicaRb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaJuridicaRb.Location = new System.Drawing.Point(175, 216);
            this.pessoaJuridicaRb.Name = "pessoaJuridicaRb";
            this.pessoaJuridicaRb.Size = new System.Drawing.Size(123, 24);
            this.pessoaJuridicaRb.TabIndex = 4;
            this.pessoaJuridicaRb.Text = "Pessoa Jurídica";
            this.pessoaJuridicaRb.UseVisualStyleBackColor = false;
            this.pessoaJuridicaRb.CheckedChanged += new System.EventHandler(this.pessoaJuridicaRb_CheckedChanged);
            // 
            // pessoaFisicaRb
            // 
            this.pessoaFisicaRb.AutoSize = true;
            this.pessoaFisicaRb.BackColor = System.Drawing.Color.Transparent;
            this.pessoaFisicaRb.Checked = true;
            this.pessoaFisicaRb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaFisicaRb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pessoaFisicaRb.Location = new System.Drawing.Point(14, 216);
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
            this.label5.Location = new System.Drawing.Point(46, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Escolha o tipo de morador:";
            // 
            // cpfRgPanel
            // 
            this.cpfRgPanel.Location = new System.Drawing.Point(14, 247);
            this.cpfRgPanel.Name = "cpfRgPanel";
            this.cpfRgPanel.Size = new System.Drawing.Size(284, 55);
            this.cpfRgPanel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 371);
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
            this.label3.Location = new System.Drawing.Point(14, 326);
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
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "RG:";
            // 
            // rgTbox
            // 
            this.rgTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTbox.Location = new System.Drawing.Point(52, 134);
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
            this.label1.Location = new System.Drawing.Point(14, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome:";
            // 
            // numeroestacionamentoNud
            // 
            this.numeroestacionamentoNud.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroestacionamentoNud.Location = new System.Drawing.Point(198, 369);
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
            this.datanascimentoDtp.Location = new System.Drawing.Point(151, 323);
            this.datanascimentoDtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datanascimentoDtp.Name = "datanascimentoDtp";
            this.datanascimentoDtp.Size = new System.Drawing.Size(147, 26);
            this.datanascimentoDtp.TabIndex = 6;
            // 
            // nomeTbox
            // 
            this.nomeTbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTbox.Location = new System.Drawing.Point(69, 92);
            this.nomeTbox.Name = "nomeTbox";
            this.nomeTbox.Size = new System.Drawing.Size(248, 26);
            this.nomeTbox.TabIndex = 1;
            // 
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(134, 415);
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
            this.pictureBox1.Location = new System.Drawing.Point(21, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // localizacaoGB
            // 
            this.localizacaoGB.Controls.Add(this.tabControl);
            this.localizacaoGB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.localizacaoGB.Location = new System.Drawing.Point(349, 90);
            this.localizacaoGB.Name = "localizacaoGB";
            this.localizacaoGB.Size = new System.Drawing.Size(326, 212);
            this.localizacaoGB.TabIndex = 56;
            this.localizacaoGB.TabStop = false;
            this.localizacaoGB.Text = "Localização";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCondominio);
            this.tabControl.Controls.Add(this.tabBloco);
            this.tabControl.Controls.Add(this.tabPredio);
            this.tabControl.Controls.Add(this.tabApartamento);
            this.tabControl.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tabControl.Location = new System.Drawing.Point(11, 33);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(302, 166);
            this.tabControl.TabIndex = 54;
            // 
            // tabCondominio
            // 
            this.tabCondominio.Controls.Add(this.condominioLB);
            this.tabCondominio.Location = new System.Drawing.Point(4, 29);
            this.tabCondominio.Name = "tabCondominio";
            this.tabCondominio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCondominio.Size = new System.Drawing.Size(294, 133);
            this.tabCondominio.TabIndex = 0;
            this.tabCondominio.Text = "Condomínio";
            this.tabCondominio.UseVisualStyleBackColor = true;
            // 
            // condominioLB
            // 
            this.condominioLB.FormattingEnabled = true;
            this.condominioLB.ItemHeight = 20;
            this.condominioLB.Location = new System.Drawing.Point(6, 6);
            this.condominioLB.Name = "condominioLB";
            this.condominioLB.Size = new System.Drawing.Size(282, 104);
            this.condominioLB.TabIndex = 0;
            // 
            // tabBloco
            // 
            this.tabBloco.Controls.Add(this.blocoLB);
            this.tabBloco.Location = new System.Drawing.Point(4, 29);
            this.tabBloco.Name = "tabBloco";
            this.tabBloco.Padding = new System.Windows.Forms.Padding(3);
            this.tabBloco.Size = new System.Drawing.Size(294, 133);
            this.tabBloco.TabIndex = 1;
            this.tabBloco.Text = "Bloco";
            this.tabBloco.UseVisualStyleBackColor = true;
            // 
            // blocoLB
            // 
            this.blocoLB.FormattingEnabled = true;
            this.blocoLB.ItemHeight = 20;
            this.blocoLB.Location = new System.Drawing.Point(6, 6);
            this.blocoLB.Name = "blocoLB";
            this.blocoLB.Size = new System.Drawing.Size(282, 104);
            this.blocoLB.TabIndex = 1;
            // 
            // tabPredio
            // 
            this.tabPredio.Controls.Add(this.predioLB);
            this.tabPredio.Location = new System.Drawing.Point(4, 29);
            this.tabPredio.Name = "tabPredio";
            this.tabPredio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPredio.Size = new System.Drawing.Size(294, 133);
            this.tabPredio.TabIndex = 2;
            this.tabPredio.Text = "Prédio";
            this.tabPredio.UseVisualStyleBackColor = true;
            // 
            // predioLB
            // 
            this.predioLB.FormattingEnabled = true;
            this.predioLB.ItemHeight = 20;
            this.predioLB.Location = new System.Drawing.Point(6, 6);
            this.predioLB.Name = "predioLB";
            this.predioLB.Size = new System.Drawing.Size(282, 104);
            this.predioLB.TabIndex = 57;
            // 
            // tabApartamento
            // 
            this.tabApartamento.Controls.Add(this.apartamentoLB);
            this.tabApartamento.Location = new System.Drawing.Point(4, 29);
            this.tabApartamento.Name = "tabApartamento";
            this.tabApartamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabApartamento.Size = new System.Drawing.Size(294, 133);
            this.tabApartamento.TabIndex = 3;
            this.tabApartamento.Text = "Apartamento";
            this.tabApartamento.UseVisualStyleBackColor = true;
            // 
            // apartamentoLB
            // 
            this.apartamentoLB.FormattingEnabled = true;
            this.apartamentoLB.ItemHeight = 20;
            this.apartamentoLB.Location = new System.Drawing.Point(6, 6);
            this.apartamentoLB.Name = "apartamentoLB";
            this.apartamentoLB.Size = new System.Drawing.Size(282, 104);
            this.apartamentoLB.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(21, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "É obrigatório preencher todos os campos";
            // 
            // Cadastro_MoradoresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.localizacaoGB);
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
            this.Controls.Add(this.CriarBtn);
            this.Name = "Cadastro_MoradoresUC";
            this.Size = new System.Drawing.Size(689, 458);
            ((System.ComponentModel.ISupportInitialize)(this.numeroestacionamentoNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.localizacaoGB.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabCondominio.ResumeLayout(false);
            this.tabBloco.ResumeLayout(false);
            this.tabPredio.ResumeLayout(false);
            this.tabApartamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.GroupBox localizacaoGB;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCondominio;
        private System.Windows.Forms.ListBox condominioLB;
        private System.Windows.Forms.TabPage tabBloco;
        private System.Windows.Forms.ListBox blocoLB;
        private System.Windows.Forms.TabPage tabPredio;
        private System.Windows.Forms.TabPage tabApartamento;
        private System.Windows.Forms.ListBox predioLB;
        private System.Windows.Forms.ListBox apartamentoLB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}
