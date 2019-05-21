namespace Conflow.Views.Cadastro
{
    partial class Cadastro_UsuarioUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_UsuarioUC));
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senhaTbox = new System.Windows.Forms.MaskedTextBox();
            this.exibirSenhaCbox = new System.Windows.Forms.CheckBox();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prioridadeCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "É obrigatório preencher todos os campos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(47, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 50);
            this.label6.TabIndex = 63;
            this.label6.Text = "Cadastro de Usuário";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(18, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nome de Usuário:";
            // 
            // nomeTbox
            // 
            this.nomeTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.nomeTbox.Location = new System.Drawing.Point(142, 98);
            this.nomeTbox.Name = "nomeTbox";
            this.nomeTbox.Size = new System.Drawing.Size(235, 26);
            this.nomeTbox.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(85, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Senha:";
            // 
            // senhaTbox
            // 
            this.senhaTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.senhaTbox.Location = new System.Drawing.Point(142, 134);
            this.senhaTbox.Name = "senhaTbox";
            this.senhaTbox.PasswordChar = '*';
            this.senhaTbox.Size = new System.Drawing.Size(235, 26);
            this.senhaTbox.TabIndex = 69;
            // 
            // exibirSenhaCbox
            // 
            this.exibirSenhaCbox.AutoSize = true;
            this.exibirSenhaCbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.exibirSenhaCbox.Location = new System.Drawing.Point(275, 166);
            this.exibirSenhaCbox.Name = "exibirSenhaCbox";
            this.exibirSenhaCbox.Size = new System.Drawing.Size(102, 24);
            this.exibirSenhaCbox.TabIndex = 70;
            this.exibirSenhaCbox.Text = "Exibir senha";
            this.exibirSenhaCbox.UseVisualStyleBackColor = true;
            this.exibirSenhaCbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CriarBtn
            // 
            this.CriarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.CriarBtn.Location = new System.Drawing.Point(157, 279);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(97, 29);
            this.CriarBtn.TabIndex = 71;
            this.CriarBtn.Text = "Cadastrar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prioridadeCombobox);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.groupBox1.Location = new System.Drawing.Point(22, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 63);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nível de Permissão";
            // 
            // prioridadeCombobox
            // 
            this.prioridadeCombobox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.prioridadeCombobox.FormattingEnabled = true;
            this.prioridadeCombobox.Items.AddRange(new object[] {
            "Usuário",
            "Funcionário",
            "Administrador"});
            this.prioridadeCombobox.Location = new System.Drawing.Point(15, 22);
            this.prioridadeCombobox.Name = "prioridadeCombobox";
            this.prioridadeCombobox.Size = new System.Drawing.Size(193, 28);
            this.prioridadeCombobox.TabIndex = 0;
            // 
            // Cadastro_UsuarioUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CriarBtn);
            this.Controls.Add(this.exibirSenhaCbox);
            this.Controls.Add(this.senhaTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Name = "Cadastro_UsuarioUC";
            this.Size = new System.Drawing.Size(394, 320);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox senhaTbox;
        private System.Windows.Forms.CheckBox exibirSenhaCbox;
        private System.Windows.Forms.Button CriarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox prioridadeCombobox;
    }
}
