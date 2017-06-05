namespace Conflow
{
    partial class ConfigurarUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.temaCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tema visual:";
            // 
            // temaCB
            // 
            this.temaCB.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.temaCB.FormattingEnabled = true;
            this.temaCB.Items.AddRange(new object[] {
            "Claro",
            "Escuro"});
            this.temaCB.Location = new System.Drawing.Point(139, 13);
            this.temaCB.Name = "temaCB";
            this.temaCB.Size = new System.Drawing.Size(147, 28);
            this.temaCB.TabIndex = 49;
            // 
            // ConfigurarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.temaCB);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurarUC";
            this.Size = new System.Drawing.Size(323, 308);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox temaCB;
    }
}
