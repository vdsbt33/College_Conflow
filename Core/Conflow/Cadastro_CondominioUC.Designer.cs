﻿namespace Conflow
{
    partial class Cadastro_CondominioUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_CondominioUC));
            this.label6 = new System.Windows.Forms.Label();
            this.nomeDoCondominioTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enderecoGB = new System.Windows.Forms.GroupBox();
            this.localNumeroNud = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ruaTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bairroTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estadoCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custosGB = new System.Windows.Forms.GroupBox();
            this.custoMensalNud = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.telefoneTbox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localNumeroNud)).BeginInit();
            this.custosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custoMensalNud)).BeginInit();
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
            this.label6.Size = new System.Drawing.Size(356, 50);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cadastro de Condomínio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeDoCondominioTbox
            // 
            this.nomeDoCondominioTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.nomeDoCondominioTbox.Location = new System.Drawing.Point(74, 94);
            this.nomeDoCondominioTbox.Name = "nomeDoCondominioTbox";
            this.nomeDoCondominioTbox.Size = new System.Drawing.Size(221, 26);
            this.nomeDoCondominioTbox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome:";
            // 
            // enderecoGB
            // 
            this.enderecoGB.Controls.Add(this.localNumeroNud);
            this.enderecoGB.Controls.Add(this.label7);
            this.enderecoGB.Controls.Add(this.ruaTBox);
            this.enderecoGB.Controls.Add(this.label5);
            this.enderecoGB.Controls.Add(this.bairroTbox);
            this.enderecoGB.Controls.Add(this.label4);
            this.enderecoGB.Controls.Add(this.estadoCBox);
            this.enderecoGB.Controls.Add(this.label3);
            this.enderecoGB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoGB.Location = new System.Drawing.Point(14, 170);
            this.enderecoGB.Name = "enderecoGB";
            this.enderecoGB.Size = new System.Drawing.Size(326, 201);
            this.enderecoGB.TabIndex = 56;
            this.enderecoGB.TabStop = false;
            this.enderecoGB.Text = "Endereço";
            // 
            // localNumeroNud
            // 
            this.localNumeroNud.Location = new System.Drawing.Point(36, 159);
            this.localNumeroNud.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.localNumeroNud.Name = "localNumeroNud";
            this.localNumeroNud.Size = new System.Drawing.Size(70, 26);
            this.localNumeroNud.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nº";
            // 
            // ruaTBox
            // 
            this.ruaTBox.Location = new System.Drawing.Point(53, 118);
            this.ruaTBox.Name = "ruaTBox";
            this.ruaTBox.Size = new System.Drawing.Size(241, 26);
            this.ruaTBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rua:";
            // 
            // bairroTbox
            // 
            this.bairroTbox.Location = new System.Drawing.Point(65, 77);
            this.bairroTbox.Name = "bairroTbox";
            this.bairroTbox.Size = new System.Drawing.Size(217, 26);
            this.bairroTbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bairro:";
            // 
            // estadoCBox
            // 
            this.estadoCBox.FormattingEnabled = true;
            this.estadoCBox.Location = new System.Drawing.Point(72, 35);
            this.estadoCBox.Name = "estadoCBox";
            this.estadoCBox.Size = new System.Drawing.Size(169, 28);
            this.estadoCBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estado:";
            // 
            // custosGB
            // 
            this.custosGB.Controls.Add(this.custoMensalNud);
            this.custosGB.Controls.Add(this.label8);
            this.custosGB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custosGB.Location = new System.Drawing.Point(14, 394);
            this.custosGB.Name = "custosGB";
            this.custosGB.Size = new System.Drawing.Size(321, 73);
            this.custosGB.TabIndex = 57;
            this.custosGB.TabStop = false;
            this.custosGB.Text = "Custos";
            // 
            // custoMensalNud
            // 
            this.custoMensalNud.DecimalPlaces = 2;
            this.custoMensalNud.Location = new System.Drawing.Point(160, 31);
            this.custoMensalNud.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.custoMensalNud.Name = "custoMensalNud";
            this.custoMensalNud.Size = new System.Drawing.Size(136, 26);
            this.custoMensalNud.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Despesa mensal (R$):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "É obrigatório preencher todos os campos";
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
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarBtn.Location = new System.Drawing.Point(131, 478);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 61;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label10.Location = new System.Drawing.Point(14, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "Telefone:";
            // 
            // telefoneTbox
            // 
            this.telefoneTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.telefoneTbox.Location = new System.Drawing.Point(85, 134);
            this.telefoneTbox.Mask = "(00) 0000-0000";
            this.telefoneTbox.Name = "telefoneTbox";
            this.telefoneTbox.Size = new System.Drawing.Size(93, 26);
            this.telefoneTbox.TabIndex = 63;
            // 
            // Cadastro_CondominioUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.telefoneTbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CriarBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.custosGB);
            this.Controls.Add(this.enderecoGB);
            this.Controls.Add(this.nomeDoCondominioTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Cadastro_CondominioUC";
            this.Size = new System.Drawing.Size(356, 517);
            this.enderecoGB.ResumeLayout(false);
            this.enderecoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localNumeroNud)).EndInit();
            this.custosGB.ResumeLayout(false);
            this.custosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custoMensalNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeDoCondominioTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox enderecoGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estadoCBox;
        private System.Windows.Forms.TextBox bairroTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ruaTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown localNumeroNud;
        private System.Windows.Forms.GroupBox custosGB;
        private System.Windows.Forms.NumericUpDown custoMensalNud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox telefoneTbox;
    }
}
