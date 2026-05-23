namespace Ecommerce
{
    partial class frmPrincipal
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
            msMenuPrincipal = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastroClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroFornecedorToolStripMenuItem = new ToolStripMenuItem();
            cadastroProdutoToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            feedebackToolStripMenuItem = new ToolStripMenuItem();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            msMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            msMenuPrincipal.AllowItemReorder = true;
            msMenuPrincipal.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, consultarToolStripMenuItem, relatóriosToolStripMenuItem, vendasToolStripMenuItem, feedebackToolStripMenuItem });
            msMenuPrincipal.Location = new Point(0, 0);
            msMenuPrincipal.Name = "msMenuPrincipal";
            msMenuPrincipal.Size = new Size(800, 24);
            msMenuPrincipal.TabIndex = 0;
            msMenuPrincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroClienteToolStripMenuItem, cadastroFornecedorToolStripMenuItem, cadastroProdutoToolStripMenuItem, categoriaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            cadastroClienteToolStripMenuItem.Size = new Size(145, 22);
            cadastroClienteToolStripMenuItem.Text = "Clientes";
            cadastroClienteToolStripMenuItem.Click += cadastroClienteToolStripMenuItem_Click;
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            cadastroFornecedorToolStripMenuItem.Size = new Size(145, 22);
            cadastroFornecedorToolStripMenuItem.Text = "Fornecedores";
            cadastroFornecedorToolStripMenuItem.Click += cadastroFornecedorToolStripMenuItem_Click;
            // 
            // cadastroProdutoToolStripMenuItem
            // 
            cadastroProdutoToolStripMenuItem.Name = "cadastroProdutoToolStripMenuItem";
            cadastroProdutoToolStripMenuItem.Size = new Size(145, 22);
            cadastroProdutoToolStripMenuItem.Text = "Produtos";
            cadastroProdutoToolStripMenuItem.Click += cadastroProdutoToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(145, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, fornecedoresToolStripMenuItem, produtosToolStripMenuItem, categoriasToolStripMenuItem });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(70, 20);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(145, 22);
            toolStripMenuItem1.Text = "Clientes";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(145, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDVToolStripMenuItem });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(56, 20);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // feedebackToolStripMenuItem
            // 
            feedebackToolStripMenuItem.Name = "feedebackToolStripMenuItem";
            feedebackToolStripMenuItem.Size = new Size(75, 20);
            feedebackToolStripMenuItem.Text = "Feedeback";
            // 
            // pDVToolStripMenuItem
            // 
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            pDVToolStripMenuItem.Size = new Size(180, 22);
            pDVToolStripMenuItem.Text = "PDV";
            pDVToolStripMenuItem.Click += pDVToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msMenuPrincipal);
            MainMenuStrip = msMenuPrincipal;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            msMenuPrincipal.ResumeLayout(false);
            msMenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMenuPrincipal;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private ToolStripMenuItem cadastroProdutoToolStripMenuItem;
        private ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem feedebackToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
    }
}