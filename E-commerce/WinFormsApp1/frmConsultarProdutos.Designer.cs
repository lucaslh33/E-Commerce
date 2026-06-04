namespace Ecommerce
{
    partial class frmConsultarProdutos
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
            grbConsultarProdutos = new GroupBox();
            dgvConsultarProduto = new DataGridView();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            grbConsultarProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProduto).BeginInit();
            SuspendLayout();
            // 
            // grbConsultarProdutos
            // 
            grbConsultarProdutos.Controls.Add(dgvConsultarProduto);
            grbConsultarProdutos.Controls.Add(txtPesquisa);
            grbConsultarProdutos.Controls.Add(lblPesquisa);
            grbConsultarProdutos.Location = new Point(12, 12);
            grbConsultarProdutos.Name = "grbConsultarProdutos";
            grbConsultarProdutos.Size = new Size(632, 500);
            grbConsultarProdutos.TabIndex = 1;
            grbConsultarProdutos.TabStop = false;
            grbConsultarProdutos.Text = "Consultar Produtos: ";
            // 
            // dgvConsultarProduto
            // 
            dgvConsultarProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarProduto.Location = new Point(6, 76);
            dgvConsultarProduto.Name = "dgvConsultarProduto";
            dgvConsultarProduto.Size = new Size(557, 418);
            dgvConsultarProduto.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 37);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(305, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
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
            // frmConsultarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 569);
            Controls.Add(grbConsultarProdutos);
            Name = "frmConsultarProdutos";
            Text = "frmConsultarProdutos";
            Load += frmConsultarProdutos_Load;
            grbConsultarProdutos.ResumeLayout(false);
            grbConsultarProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultarProdutos;
        private DataGridView dgvConsultarProduto;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
    }
}