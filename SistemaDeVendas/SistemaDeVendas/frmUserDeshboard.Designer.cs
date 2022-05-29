namespace SistemaDeVendas
{
    partial class frmUserDeshboard
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
            this.pnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPrincipalUser = new System.Windows.Forms.MenuStrip();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoDeIntemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNoEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter.SuspendLayout();
            this.MenuPrincipalUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 433);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1002, 30);
            this.pnlFooter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido por nalinadolfo33@gmail.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MenuPrincipalUser
            // 
            this.MenuPrincipalUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.sTToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.devoluçãoDeIntemToolStripMenuItem});
            this.MenuPrincipalUser.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipalUser.Name = "MenuPrincipalUser";
            this.MenuPrincipalUser.Size = new System.Drawing.Size(1002, 24);
            this.MenuPrincipalUser.TabIndex = 3;
            this.MenuPrincipalUser.Text = "menuStrip1";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.vendasToolStripMenuItem.Text = "Vendas ";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque ";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // sTToolStripMenuItem
            // 
            this.sTToolStripMenuItem.Name = "sTToolStripMenuItem";
            this.sTToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sTToolStripMenuItem.Text = "S@T";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.caixaToolStripMenuItem.Text = "Caixa ";
            // 
            // devoluçãoDeIntemToolStripMenuItem
            // 
            this.devoluçãoDeIntemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCréditoToolStripMenuItem,
            this.adicionarNoEstoqueToolStripMenuItem});
            this.devoluçãoDeIntemToolStripMenuItem.Name = "devoluçãoDeIntemToolStripMenuItem";
            this.devoluçãoDeIntemToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.devoluçãoDeIntemToolStripMenuItem.Text = "Devolução de Itens";
            this.devoluçãoDeIntemToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoDeIntemToolStripMenuItem_Click);
            // 
            // abrirCréditoToolStripMenuItem
            // 
            this.abrirCréditoToolStripMenuItem.Name = "abrirCréditoToolStripMenuItem";
            this.abrirCréditoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirCréditoToolStripMenuItem.Text = "Abrir crédito";
            // 
            // adicionarNoEstoqueToolStripMenuItem
            // 
            this.adicionarNoEstoqueToolStripMenuItem.Name = "adicionarNoEstoqueToolStripMenuItem";
            this.adicionarNoEstoqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarNoEstoqueToolStripMenuItem.Text = "Voltar ao estoque";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // frmUserDeshboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 463);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.MenuPrincipalUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmUserDeshboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.MenuPrincipalUser.ResumeLayout(false);
            this.MenuPrincipalUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip MenuPrincipalUser;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoDeIntemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarNoEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
    }
}