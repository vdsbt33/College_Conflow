namespace Conflow
{
    partial class Conta_DesconectarUC
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
            this.DesconectarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DesconectarBtn
            // 
            this.DesconectarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DesconectarBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesconectarBtn.Location = new System.Drawing.Point(128, 47);
            this.DesconectarBtn.Name = "DesconectarBtn";
            this.DesconectarBtn.Size = new System.Drawing.Size(97, 29);
            this.DesconectarBtn.TabIndex = 63;
            this.DesconectarBtn.Text = "Desconectar";
            this.DesconectarBtn.UseVisualStyleBackColor = true;
            this.DesconectarBtn.Click += new System.EventHandler(this.DesconectarBtn_Click);
            // 
            // Conta_DesconectarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DesconectarBtn);
            this.Name = "Conta_DesconectarUC";
            this.Size = new System.Drawing.Size(357, 136);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DesconectarBtn;
    }
}
