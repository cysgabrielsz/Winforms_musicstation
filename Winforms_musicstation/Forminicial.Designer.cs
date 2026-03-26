namespace Winforms_musicstation
{
    partial class Forminicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forminicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pESSOASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionalCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATALOGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPERACIONALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicosPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locacoesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fINANCEIROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tansacoesPagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasPagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENSAGENSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagensToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pESSOASToolStripMenuItem,
            this.cATALOGOToolStripMenuItem,
            this.oPERACIONALToolStripMenuItem,
            this.fINANCEIROToolStripMenuItem,
            this.mENSAGENSToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pESSOASToolStripMenuItem
            // 
            this.pESSOASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.profissionaisToolStripMenuItem,
            this.profissionalCargoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.adminstradoresToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.pESSOASToolStripMenuItem.Name = "pESSOASToolStripMenuItem";
            this.pESSOASToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pESSOASToolStripMenuItem.Text = "PESSOAS";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // profissionaisToolStripMenuItem
            // 
            this.profissionaisToolStripMenuItem.Name = "profissionaisToolStripMenuItem";
            this.profissionaisToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.profissionaisToolStripMenuItem.Text = "Profissionais";
            this.profissionaisToolStripMenuItem.Click += new System.EventHandler(this.profissionaisToolStripMenuItem_Click);
            // 
            // profissionalCargoToolStripMenuItem
            // 
            this.profissionalCargoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profissionalCargoToolStripMenuItem.Name = "profissionalCargoToolStripMenuItem";
            this.profissionalCargoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.profissionalCargoToolStripMenuItem.Text = "Profissional cargo";
            this.profissionalCargoToolStripMenuItem.Click += new System.EventHandler(this.profissionalCargoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // adminstradoresToolStripMenuItem
            // 
            this.adminstradoresToolStripMenuItem.Name = "adminstradoresToolStripMenuItem";
            this.adminstradoresToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.adminstradoresToolStripMenuItem.Text = "Adminstradores";
            this.adminstradoresToolStripMenuItem.Click += new System.EventHandler(this.adminstradoresToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // cATALOGOToolStripMenuItem
            // 
            this.cATALOGOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentosToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.cATALOGOToolStripMenuItem.Name = "cATALOGOToolStripMenuItem";
            this.cATALOGOToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cATALOGOToolStripMenuItem.Text = "CATALOGO";
            // 
            // instrumentosToolStripMenuItem
            // 
            this.instrumentosToolStripMenuItem.Name = "instrumentosToolStripMenuItem";
            this.instrumentosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.instrumentosToolStripMenuItem.Text = "Instrumentos";
            this.instrumentosToolStripMenuItem.Click += new System.EventHandler(this.instrumentosToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // oPERACIONALToolStripMenuItem
            // 
            this.oPERACIONALToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.servicosPedidosToolStripMenuItem,
            this.locacoesToolStripMenuItem,
            this.locacoesToolStripMenuItem1});
            this.oPERACIONALToolStripMenuItem.Name = "oPERACIONALToolStripMenuItem";
            this.oPERACIONALToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.oPERACIONALToolStripMenuItem.Text = "OPERACIONAL";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // servicosPedidosToolStripMenuItem
            // 
            this.servicosPedidosToolStripMenuItem.Name = "servicosPedidosToolStripMenuItem";
            this.servicosPedidosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.servicosPedidosToolStripMenuItem.Text = "Servicos pedidos";
            this.servicosPedidosToolStripMenuItem.Click += new System.EventHandler(this.servicosPedidosToolStripMenuItem_Click);
            // 
            // locacoesToolStripMenuItem
            // 
            this.locacoesToolStripMenuItem.Name = "locacoesToolStripMenuItem";
            this.locacoesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.locacoesToolStripMenuItem.Text = "Locacoes ";
            this.locacoesToolStripMenuItem.Click += new System.EventHandler(this.locacoesToolStripMenuItem_Click);
            // 
            // locacoesToolStripMenuItem1
            // 
            this.locacoesToolStripMenuItem1.Name = "locacoesToolStripMenuItem1";
            this.locacoesToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.locacoesToolStripMenuItem1.Text = "Locacoes itens";
            this.locacoesToolStripMenuItem1.Click += new System.EventHandler(this.locacoesToolStripMenuItem1_Click);
            // 
            // fINANCEIROToolStripMenuItem
            // 
            this.fINANCEIROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem,
            this.tansacoesPagamentosToolStripMenuItem,
            this.formasPagamentosToolStripMenuItem});
            this.fINANCEIROToolStripMenuItem.Name = "fINANCEIROToolStripMenuItem";
            this.fINANCEIROToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.fINANCEIROToolStripMenuItem.Text = "FINANCEIRO";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pToolStripMenuItem.Text = "Pagamentos";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // tansacoesPagamentosToolStripMenuItem
            // 
            this.tansacoesPagamentosToolStripMenuItem.Name = "tansacoesPagamentosToolStripMenuItem";
            this.tansacoesPagamentosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tansacoesPagamentosToolStripMenuItem.Text = "Tansacoes pagamentos";
            this.tansacoesPagamentosToolStripMenuItem.Click += new System.EventHandler(this.tansacoesPagamentosToolStripMenuItem_Click);
            // 
            // formasPagamentosToolStripMenuItem
            // 
            this.formasPagamentosToolStripMenuItem.Name = "formasPagamentosToolStripMenuItem";
            this.formasPagamentosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.formasPagamentosToolStripMenuItem.Text = "Formas pagamentos";
            this.formasPagamentosToolStripMenuItem.Click += new System.EventHandler(this.formasPagamentosToolStripMenuItem_Click);
            // 
            // mENSAGENSToolStripMenuItem
            // 
            this.mENSAGENSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatsToolStripMenuItem,
            this.mensagensToolStripMenuItem1,
            this.notificacoesToolStripMenuItem,
            this.avaliacoesToolStripMenuItem});
            this.mENSAGENSToolStripMenuItem.Name = "mENSAGENSToolStripMenuItem";
            this.mENSAGENSToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.mENSAGENSToolStripMenuItem.Text = "MENSAGENS";
            // 
            // chatsToolStripMenuItem
            // 
            this.chatsToolStripMenuItem.Name = "chatsToolStripMenuItem";
            this.chatsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.chatsToolStripMenuItem.Text = "Chats";
            this.chatsToolStripMenuItem.Click += new System.EventHandler(this.chatsToolStripMenuItem_Click);
            // 
            // mensagensToolStripMenuItem1
            // 
            this.mensagensToolStripMenuItem1.Name = "mensagensToolStripMenuItem1";
            this.mensagensToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.mensagensToolStripMenuItem1.Text = "Mensagens";
            this.mensagensToolStripMenuItem1.Click += new System.EventHandler(this.mensagensToolStripMenuItem1_Click);
            // 
            // notificacoesToolStripMenuItem
            // 
            this.notificacoesToolStripMenuItem.Name = "notificacoesToolStripMenuItem";
            this.notificacoesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.notificacoesToolStripMenuItem.Text = "Notificacoes";
            this.notificacoesToolStripMenuItem.Click += new System.EventHandler(this.notificacoesToolStripMenuItem_Click);
            // 
            // avaliacoesToolStripMenuItem
            // 
            this.avaliacoesToolStripMenuItem.Name = "avaliacoesToolStripMenuItem";
            this.avaliacoesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.avaliacoesToolStripMenuItem.Text = "Avaliacoes";
            this.avaliacoesToolStripMenuItem.Click += new System.EventHandler(this.avaliacoesToolStripMenuItem_Click);
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Forminicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Forminicial";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pESSOASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPERACIONALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profissionaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profissionalCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINANCEIROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENSAGENSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminstradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicosPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locacoesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tansacoesPagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasPagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagensToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notificacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliacoesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
    }
}

