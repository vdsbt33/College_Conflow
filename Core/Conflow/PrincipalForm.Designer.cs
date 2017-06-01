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
            this.AvisosBtn = new System.Windows.Forms.Button();
            this.iconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.ConectarBtn = new System.Windows.Forms.Button();
            this.PesquisarBtn = new System.Windows.Forms.Button();
            this.CadastrarBtn = new System.Windows.Forms.Button();
            this.ConfigurarBtn = new System.Windows.Forms.Button();
            this.AjudaBtn = new System.Windows.Forms.Button();
            this.SairBtn = new System.Windows.Forms.Button();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.SoftwareTitleLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cursorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TopPictureBox = new System.Windows.Forms.PictureBox();
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
            this.flowLayoutPanel.Size = new System.Drawing.Size(116, 490);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // AvisosBtn
            // 
            this.AvisosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AvisosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvisosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AvisosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisosBtn.ImageKey = "icon_Avisos.png";
            this.AvisosBtn.ImageList = this.iconsImageList;
            this.AvisosBtn.Location = new System.Drawing.Point(3, 3);
            this.AvisosBtn.Name = "AvisosBtn";
            this.AvisosBtn.Size = new System.Drawing.Size(110, 60);
            this.AvisosBtn.TabIndex = 0;
            this.AvisosBtn.Text = "&Avisos";
            this.AvisosBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AvisosBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cursorToolTip.SetToolTip(this.AvisosBtn, "Exibe os avisos definidos pelo administrador do sistema.");
            this.AvisosBtn.UseVisualStyleBackColor = true;
            // 
            // iconsImageList
            // 
            this.iconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsImageList.ImageStream")));
            this.iconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsImageList.Images.SetKeyName(0, "icon_Avisos.png");
            this.iconsImageList.Images.SetKeyName(1, "icon_Conectar.png");
            this.iconsImageList.Images.SetKeyName(2, "icon_Pesquisar.png");
            this.iconsImageList.Images.SetKeyName(3, "icon_Cadastrar.png");
            this.iconsImageList.Images.SetKeyName(4, "icon_Configurar.png");
            this.iconsImageList.Images.SetKeyName(5, "icon_Ajuda.png");
            this.iconsImageList.Images.SetKeyName(6, "icon_Sair.png");
            this.iconsImageList.Images.SetKeyName(7, "icon_Imprimir.png");
            // 
            // ConectarBtn
            // 
            this.ConectarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConectarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConectarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConectarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarBtn.ImageKey = "icon_Conectar.png";
            this.ConectarBtn.ImageList = this.iconsImageList;
            this.ConectarBtn.Location = new System.Drawing.Point(3, 69);
            this.ConectarBtn.Name = "ConectarBtn";
            this.ConectarBtn.Size = new System.Drawing.Size(110, 60);
            this.ConectarBtn.TabIndex = 1;
            this.ConectarBtn.Text = "&Conectar";
            this.ConectarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConectarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cursorToolTip.SetToolTip(this.ConectarBtn, "Conecta-se a uma conta usando o nome de usuário e senha.\r\nCaso já esteja conectad" +
        "o, é possível desconectar-se dela.");
            this.ConectarBtn.UseVisualStyleBackColor = true;
            // 
            // PesquisarBtn
            // 
            this.PesquisarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PesquisarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesquisarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PesquisarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarBtn.ImageKey = "icon_Pesquisar.png";
            this.PesquisarBtn.ImageList = this.iconsImageList;
            this.PesquisarBtn.Location = new System.Drawing.Point(3, 135);
            this.PesquisarBtn.Name = "PesquisarBtn";
            this.PesquisarBtn.Size = new System.Drawing.Size(110, 60);
            this.PesquisarBtn.TabIndex = 2;
            this.PesquisarBtn.Text = "&Pesquisar";
            this.PesquisarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PesquisarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cursorToolTip.SetToolTip(this.PesquisarBtn, "Encontra um morador usando os critérios de busca.\r\nAlém de visualizar os dados, é" +
        " possível fazer mudanças.");
            this.PesquisarBtn.UseVisualStyleBackColor = true;
            this.PesquisarBtn.Click += new System.EventHandler(this.PesquisarBtn_Click);
            // 
            // CadastrarBtn
            // 
            this.CadastrarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CadastrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadastrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadastrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarBtn.ImageKey = "icon_Cadastrar.png";
            this.CadastrarBtn.ImageList = this.iconsImageList;
            this.CadastrarBtn.Location = new System.Drawing.Point(3, 201);
            this.CadastrarBtn.Name = "CadastrarBtn";
            this.CadastrarBtn.Size = new System.Drawing.Size(110, 60);
            this.CadastrarBtn.TabIndex = 3;
            this.CadastrarBtn.Text = "Ca&dastrar";
            this.CadastrarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CadastrarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cursorToolTip.SetToolTip(this.CadastrarBtn, "Cadastra novos moradores no sistema com os dados inseridos.\r\n");
            this.CadastrarBtn.UseVisualStyleBackColor = true;
            this.CadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // ConfigurarBtn
            // 
            this.ConfigurarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConfigurarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfigurarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfigurarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigurarBtn.ImageKey = "icon_Configurar.png";
            this.ConfigurarBtn.ImageList = this.iconsImageList;
            this.ConfigurarBtn.Location = new System.Drawing.Point(3, 267);
            this.ConfigurarBtn.Name = "ConfigurarBtn";
            this.ConfigurarBtn.Size = new System.Drawing.Size(110, 60);
            this.ConfigurarBtn.TabIndex = 4;
            this.ConfigurarBtn.Text = "Con&figurar";
            this.ConfigurarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConfigurarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cursorToolTip.SetToolTip(this.ConfigurarBtn, "Alterar opções como idioma.");
            this.ConfigurarBtn.UseVisualStyleBackColor = true;
            // 
            // AjudaBtn
            // 
            this.AjudaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AjudaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AjudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AjudaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjudaBtn.ImageKey = "icon_Ajuda.png";
            this.AjudaBtn.ImageList = this.iconsImageList;
            this.AjudaBtn.Location = new System.Drawing.Point(3, 333);
            this.AjudaBtn.Name = "AjudaBtn";
            this.AjudaBtn.Size = new System.Drawing.Size(110, 60);
            this.AjudaBtn.TabIndex = 5;
            this.AjudaBtn.Text = "A&juda";
            this.AjudaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AjudaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cursorToolTip.SetToolTip(this.AjudaBtn, "Alterar opções como idioma.");
            this.AjudaBtn.UseVisualStyleBackColor = true;
            // 
            // SairBtn
            // 
            this.SairBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SairBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairBtn.ImageKey = "icon_Sair.png";
            this.SairBtn.ImageList = this.iconsImageList;
            this.SairBtn.Location = new System.Drawing.Point(3, 399);
            this.SairBtn.Name = "SairBtn";
            this.SairBtn.Size = new System.Drawing.Size(110, 60);
            this.SairBtn.TabIndex = 6;
            this.SairBtn.Text = "&Sair";
            this.SairBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SairBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cursorToolTip.SetToolTip(this.SairBtn, "Alterar opções como idioma.");
            this.SairBtn.UseVisualStyleBackColor = true;
            this.SairBtn.Click += new System.EventHandler(this.SairBtn_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormPanel.Location = new System.Drawing.Point(134, 117);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(816, 490);
            this.FormPanel.TabIndex = 2;
            // 
            // SoftwareTitleLabel
            // 
            this.SoftwareTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SoftwareTitleLabel.AutoSize = true;
            this.SoftwareTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SoftwareTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareTitleLabel.Location = new System.Drawing.Point(404, 66);
            this.SoftwareTitleLabel.Name = "SoftwareTitleLabel";
            this.SoftwareTitleLabel.Size = new System.Drawing.Size(160, 42);
            this.SoftwareTitleLabel.TabIndex = 3;
            this.SoftwareTitleLabel.Text = "Conflow";
            this.SoftwareTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
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
            this.TopPictureBox.Size = new System.Drawing.Size(774, 99);
            this.TopPictureBox.TabIndex = 1;
            this.TopPictureBox.TabStop = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 642);
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
        private System.Windows.Forms.ImageList iconsImageList;
    }
}

