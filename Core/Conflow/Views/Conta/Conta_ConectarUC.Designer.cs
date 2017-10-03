namespace Conflow
{
    partial class Conta_ConectarUC
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
            this.usernameTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTbox = new System.Windows.Forms.MaskedTextBox();
            this.ConectarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTbox
            // 
            this.usernameTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.usernameTbox.Location = new System.Drawing.Point(139, 13);
            this.usernameTbox.Name = "usernameTbox";
            this.usernameTbox.Size = new System.Drawing.Size(172, 26);
            this.usernameTbox.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nome de Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(82, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Senha:";
            // 
            // passwordTbox
            // 
            this.passwordTbox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.passwordTbox.Location = new System.Drawing.Point(139, 56);
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.PasswordChar = '*';
            this.passwordTbox.Size = new System.Drawing.Size(172, 26);
            this.passwordTbox.TabIndex = 50;
            this.passwordTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTbox_KeyDown);
            // 
            // ConectarBtn
            // 
            this.ConectarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarBtn.Location = new System.Drawing.Point(130, 98);
            this.ConectarBtn.Name = "ConectarBtn";
            this.ConectarBtn.Size = new System.Drawing.Size(97, 29);
            this.ConectarBtn.TabIndex = 62;
            this.ConectarBtn.Text = "Conectar";
            this.ConectarBtn.UseVisualStyleBackColor = true;
            this.ConectarBtn.Click += new System.EventHandler(this.ConectarBtn_Click);
            // 
            // Conta_ConectarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConectarBtn);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTbox);
            this.Controls.Add(this.label1);
            this.Name = "Conta_ConectarUC";
            this.Size = new System.Drawing.Size(357, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox passwordTbox;
        private System.Windows.Forms.Button ConectarBtn;
    }
}
