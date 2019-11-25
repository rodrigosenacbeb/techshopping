namespace View
{
    partial class FrmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGerenciarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGerenciarProdutos});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // menuGerenciarProdutos
            // 
            this.menuGerenciarProdutos.Name = "menuGerenciarProdutos";
            this.menuGerenciarProdutos.Size = new System.Drawing.Size(269, 26);
            this.menuGerenciarProdutos.Text = "Gerenciamento de Produtos";
            this.menuGerenciarProdutos.Click += new System.EventHandler(this.menuGerenciarProdutos_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovimentarEstoque});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // menuMovimentarEstoque
            // 
            this.menuMovimentarEstoque.Name = "menuMovimentarEstoque";
            this.menuMovimentarEstoque.Size = new System.Drawing.Size(221, 26);
            this.menuMovimentarEstoque.Text = "Movimentar Estoque";
            this.menuMovimentarEstoque.Click += new System.EventHandler(this.menuMovimentarEstoque_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 662);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Tech Shopping ::: Tela Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGerenciarProdutos;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentarEstoque;
    }
}