namespace Conflow
{
    partial class PrincipalForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SoftwareTitleLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cursorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TopPictureBox = new System.Windows.Forms.PictureBox();
            this.AvisosBtn = new System.Windows.Forms.Button();
            this.ConectarBtn = new System.Windows.Forms.Button();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.CadastrarBtn = new System.Windows.Forms.Button();
            this.ConfigurarBtn = new System.Windows.Forms.Button();
            this.AjudaBtn = new System.Windows.Forms.Button();
            this.SairBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Controls.Add(this.AvisosBtn);
            this.flowLayoutPanel.Controls.Add(this.ConectarBtn);
            this.flowLayoutPanel.Controls.Add(this.PesquisarBtn);
            this.flowLayoutPanel.Controls.Add(this.CadastrarBtn);
            this.flowLayoutPanel.Controls.Add(this.ConfigurarBtn);
            this.flowLayoutPanel.Controls.Add(this.AjudaBtn);
            this.flowLayoutPanel.Controls.Add(this.SairBtn);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 117);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(163, 328);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormPanel.Location = new System.Drawing.Point(183, 117);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(445, 328);
            this.FormPanel.TabIndex = 2;
            // 
            // SoftwareTitleLabel
            // 
            this.SoftwareTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SoftwareTitleLabel.AutoSize = true;
            this.SoftwareTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SoftwareTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareTitleLabel.Location = new System.Drawing.Point(243, 66);
            this.SoftwareTitleLabel.Name = "SoftwareTitleLabel";
            this.SoftwareTitleLabel.Size = new System.Drawing.Size(160, 42);
            this.SoftwareTitleLabel.TabIndex = 3;
            this.SoftwareTitleLabel.Text = "Conflow";
            this.SoftwareTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cursorToolTip
            // 
            this.cursorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.cursorToolTip.ToolTipTitle = "Dica:";
            // 
            // TopPictureBox
            // 
            this.TopPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TopPictureBox.Image")));
            this.TopPictureBox.Location = new System.Drawing.Point(92, 9);
            this.TopPictureBox.Name = "TopPictureBox";
            this.TopPictureBox.Size = new System.Drawing.Size(452, 99);
            this.TopPictureBox.TabIndex = 1;
            this.TopPictureBox.TabStop = false;
            // 
            // AvisosBtn
            // 
            this.AvisosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AvisosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisosBtn.Image = ((System.Drawing.Image)(resources.GetObject("AvisosBtn.Image")));
            this.AvisosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvisosBtn.Location = new System.Drawing.Point(3, 3);
            this.AvisosBtn.Name = "AvisosBtn";
            this.AvisosBtn.Size = new System.Drawing.Size(157, 35);
            this.AvisosBtn.TabIndex = 0;
            this.AvisosBtn.Text = "&Avisos";
            this.AvisosBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cursorToolTip.SetToolTip(this.AvisosBtn, "Exibe os avisos definidos pelo administrador do sistema.");
            this.AvisosBtn.UseVisualStyleBackColor = true;
            // 
            // ConectarBtn
            // 
            this.ConectarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConectarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConectarBtn.Image")));
            this.ConectarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConectarBtn.Location = new System.Drawing.Point(3, 44);
            this.ConectarBtn.Name = "ConectarBtn";
            this.ConectarBtn.Size = new System.Drawing.Size(157, 35);
            this.ConectarBtn.TabIndex = 1;
            this.ConectarBtn.Text = "&Conectar";
            this.ConectarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cursorToolTip.SetToolTip(this.ConectarBtn, "Conecta-se a uma conta usando o nome de usuário e senha.\r\nCaso já esteja conectad" +
        "o, é possível desconectar-se dela.");
            this.ConectarBtn.UseVisualStyleBackColor = true;
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PesquisarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarBtn.Image = ((System.Drawing.Image)(resources.GetObject("PesquisarBtn.Image")));
            this.PesquisarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PesquisarBtn.Location = new System.Drawing.Point(3, 85);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(157, 35);
            this.PesquisarBtn.TabIndex = 2;
            this.PesquisarBtn.Text = "&Pesquisar";
            this.PesquisarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cursorToolTip.SetToolTip(this.PesquisarBtn, "Encontra um morador usando os critérios de busca.\r\nAlém de visualizar os dados, é" +
        " possível fazer mudanças.");
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            // 
            // CadastrarBtn
            // 
            this.CadastrarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CadastrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CadastrarBtn.Image")));
            this.CadastrarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadastrarBtn.Location = new System.Drawing.Point(3, 126);
            this.CadastrarBtn.Name = "CadastrarBtn";
            this.CadastrarBtn.Size = new System.Drawing.Size(157, 35);
            this.CadastrarBtn.TabIndex = 3;
            this.CadastrarBtn.Text = "Ca&dastrar";
            this.CadastrarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cursorToolTip.SetToolTip(this.CadastrarBtn, "Cadastra novos moradores no sistema com os dados inseridos.\r\n");
            this.CadastrarBtn.UseVisualStyleBackColor = true;
            this.CadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // ConfigurarBtn
            // 
            this.ConfigurarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConfigurarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigurarBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConfigurarBtn.Image")));
            this.ConfigurarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigurarBtn.Location = new System.Drawing.Point(3, 167);
            this.ConfigurarBtn.Name = "ConfigurarBtn";
            this.ConfigurarBtn.Size = new System.Drawing.Size(157, 35);
            this.ConfigurarBtn.TabIndex = 4;
            this.ConfigurarBtn.Text = "Con&figurar";
            this.ConfigurarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cursorToolTip.SetToolTip(this.ConfigurarBtn, "Alterar opções como idioma.");
            this.ConfigurarBtn.UseVisualStyleBackColor = true;
            // 
            // AjudaBtn
            // 
            this.AjudaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AjudaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjudaBtn.Image = ((System.Drawing.Image)(resources.GetObject("AjudaBtn.Image")));
            this.AjudaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjudaBtn.Location = new System.Drawing.Point(3, 208);
            this.AjudaBtn.Name = "AjudaBtn";
            this.AjudaBtn.Size = new System.Drawing.Size(157, 35);
            this.AjudaBtn.TabIndex = 5;
            this.AjudaBtn.Text = "A&juda";
            this.AjudaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cursorToolTip.SetToolTip(this.AjudaBtn, "Alterar opções como idioma.");
            this.AjudaBtn.UseVisualStyleBackColor = true;
            // 
            // SairBtn
            // 
            this.SairBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SairBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBtn.Image = ((System.Drawing.Image)(resources.GetObject("SairBtn.Image")));
            this.SairBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SairBtn.Location = new System.Drawing.Point(3, 249);
            this.SairBtn.Name = "SairBtn";
            this.SairBtn.Size = new System.Drawing.Size(157, 35);
            this.SairBtn.TabIndex = 6;
            this.SairBtn.Text = "&Sair";
            this.SairBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cursorToolTip.SetToolTip(this.SairBtn, "Alterar opções como idioma.");
            this.SairBtn.UseVisualStyleBackColor = true;
            this.SairBtn.Click += new System.EventHandler(this.SairBtn_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SoftwareTitleLabel);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.TopPictureBox);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.Text = "PrincipalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox TopPictureBox;
        private System.Windows.Forms.Button ConectarBtn;
        private System.Windows.Forms.Button PesquisarBtn;
        private System.Windows.Forms.Button AvisosBtn;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label SoftwareTitleLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip cursorToolTip;
        private System.Windows.Forms.Button CadastrarBtn;
        private System.Windows.Forms.Button ConfigurarBtn;
        private System.Windows.Forms.Button AjudaBtn;
        private System.Windows.Forms.Button SairBtn;
    }
}

