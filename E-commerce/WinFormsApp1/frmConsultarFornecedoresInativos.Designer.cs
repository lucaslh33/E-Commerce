namespace Ecommerce
{
    partial class frmConsultarFornecedoresInativos
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
            grbConsultaFornecedores = new GroupBox();
            dgvConsultarFornecedores = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            grbConsultaFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarFornecedores).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbConsultaFornecedores
            // 
            grbConsultaFornecedores.Controls.Add(dgvConsultarFornecedores);
            grbConsultaFornecedores.Controls.Add(txtPesquisa);
            grbConsultaFornecedores.Controls.Add(lblPesquisa);
            grbConsultaFornecedores.Location = new Point(12, 12);
            grbConsultaFornecedores.Name = "grbConsultaFornecedores";
            grbConsultaFornecedores.Size = new Size(580, 500);
            grbConsultaFornecedores.TabIndex = 2;
            grbConsultaFornecedores.TabStop = false;
            grbConsultaFornecedores.Text = "Consultar Fornecedores Inativos";
            // 
            // dgvConsultarFornecedores
            // 
            dgvConsultarFornecedores.AllowUserToAddRows = false;
            dgvConsultarFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarFornecedores.ContextMenuStrip = contextMenuStrip1;
            dgvConsultarFornecedores.Location = new Point(6, 66);
            dgvConsultarFornecedores.MultiSelect = false;
            dgvConsultarFornecedores.Name = "dgvConsultarFornecedores";
            dgvConsultarFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarFornecedores.Size = new Size(557, 418);
            dgvConsultarFornecedores.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(180, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 37);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(351, 23);
            txtPesquisa.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(6, 19);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(146, 15);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Nome, CNPJ, Razão social:";
            // 
            // frmConsultarFornecedoresInativos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 523);
            Controls.Add(grbConsultaFornecedores);
            Name = "frmConsultarFornecedoresInativos";
            Text = "frmConsultarFornecedoresInativos";
            Load += frmConsultarFornecedoresInativos_Load;
            grbConsultaFornecedores.ResumeLayout(false);
            grbConsultaFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarFornecedores).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultaFornecedores;
        private DataGridView dgvConsultarFornecedores;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem restaurarToolStripMenuItem;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
    }
}