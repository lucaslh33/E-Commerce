namespace Ecommerce
{
    partial class frmConsultarFornecedores
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
            dgvConsultaFornecedores = new DataGridView();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            grbConsultaFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaFornecedores).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbConsultaFornecedores
            // 
            grbConsultaFornecedores.Controls.Add(dgvConsultaFornecedores);
            grbConsultaFornecedores.Controls.Add(txtPesquisa);
            grbConsultaFornecedores.Controls.Add(lblPesquisa);
            grbConsultaFornecedores.Location = new Point(12, 12);
            grbConsultaFornecedores.Name = "grbConsultaFornecedores";
            grbConsultaFornecedores.Size = new Size(580, 500);
            grbConsultaFornecedores.TabIndex = 1;
            grbConsultaFornecedores.TabStop = false;
            grbConsultaFornecedores.Text = "Consultar Fornecedores";
            // 
            // dgvConsultaFornecedores
            // 
            dgvConsultaFornecedores.AllowUserToAddRows = false;
            dgvConsultaFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultaFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaFornecedores.ContextMenuStrip = contextMenuStrip1;
            dgvConsultaFornecedores.Location = new Point(6, 66);
            dgvConsultaFornecedores.MultiSelect = false;
            dgvConsultaFornecedores.Name = "dgvConsultaFornecedores";
            dgvConsultaFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaFornecedores.Size = new Size(557, 418);
            dgvConsultaFornecedores.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 37);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(351, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, removerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(180, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(180, 22);
            removerToolStripMenuItem.Text = "Remover";
            removerToolStripMenuItem.Click += removerToolStripMenuItem_Click;
            // 
            // frmConsultarFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 534);
            Controls.Add(grbConsultaFornecedores);
            Name = "frmConsultarFornecedores";
            Text = "frmConsultarFornecedores";
            Load += frmConsultarFornecedores_Load;
            grbConsultaFornecedores.ResumeLayout(false);
            grbConsultaFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaFornecedores).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultaFornecedores;
        private DataGridView dgvConsultaFornecedores;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
    }
}