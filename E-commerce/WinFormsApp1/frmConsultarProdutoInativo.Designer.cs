namespace Ecommerce
{
    partial class frmConsultarProdutoInativo
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
            components = new System.ComponentModel.Container();
            grbConsultarProdutos = new GroupBox();
            dgvConsultarProduto = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            grbConsultarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProduto).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbConsultarProdutos
            // 
            grbConsultarProdutos.Controls.Add(dgvConsultarProduto);
            grbConsultarProdutos.Controls.Add(txtPesquisa);
            grbConsultarProdutos.Controls.Add(lblPesquisa);
            grbConsultarProdutos.Location = new Point(12, 12);
            grbConsultarProdutos.Name = "grbConsultarProdutos";
            grbConsultarProdutos.Size = new Size(579, 500);
            grbConsultarProdutos.TabIndex = 2;
            grbConsultarProdutos.TabStop = false;
            grbConsultarProdutos.Text = "Consultar Produtos Inativos: ";
            // 
            // dgvConsultarProduto
            // 
            dgvConsultarProduto.AllowUserToAddRows = false;
            dgvConsultarProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarProduto.ContextMenuStrip = contextMenuStrip1;
            dgvConsultarProduto.Location = new Point(6, 76);
            dgvConsultarProduto.Name = "dgvConsultarProduto";
            dgvConsultarProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarProduto.Size = new Size(557, 418);
            dgvConsultarProduto.TabIndex = 2;
            dgvConsultarProduto.CellContentClick += dgvConsultarProduto_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(124, 26);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(123, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 37);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(305, 23);
            txtPesquisa.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(6, 19);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(162, 15);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Nome do produto, SKU, EAN:";
            // 
            // frmConsultarProdutoInativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 527);
            Controls.Add(grbConsultarProdutos);
            Name = "frmConsultarProdutoInativo";
            Text = "frmConsultarProdutoInativo";
            Load += frmConsultarProdutoInativo_Load;
            grbConsultarProdutos.ResumeLayout(false);
            grbConsultarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProduto).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultarProdutos;
        private DataGridView dgvConsultarProduto;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}