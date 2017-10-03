namespace Conflow
{
    partial class AvisosUC
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
            this.avisoTbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // avisoTbox
            // 
            this.avisoTbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avisoTbox.BackColor = System.Drawing.SystemColors.Menu;
            this.avisoTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avisoTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoTbox.Location = new System.Drawing.Point(3, 3);
            this.avisoTbox.Name = "avisoTbox";
            this.avisoTbox.Size = new System.Drawing.Size(516, 325);
            this.avisoTbox.TabIndex = 0;
            this.avisoTbox.Text = "Sistema de Gerenciamento de Condomínio Conflow\n\nAvisos:\nNenhum aviso.";
            // 
            // AvisosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.avisoTbox);
            this.Name = "AvisosUC";
            this.Size = new System.Drawing.Size(525, 341);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox avisoTbox;
    }
}
