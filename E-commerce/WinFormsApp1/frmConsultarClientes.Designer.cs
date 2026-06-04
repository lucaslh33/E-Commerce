namespace Ecommerce
{
    partial class frmConsultarClientes
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
            grbConsultarClientes = new GroupBox();
            dgvConsultaCliente = new DataGridView();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            contextMenu = new ContextMenuStrip(components);
            alterarToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            grbConsultarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaCliente).BeginInit();
            contextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // grbConsultarClientes
            // 
            grbConsultarClientes.Controls.Add(dgvConsultaCliente);
            grbConsultarClientes.Controls.Add(txtPesquisa);
            grbConsultarClientes.Controls.Add(lblPesquisa);
            grbConsultarClientes.Location = new Point(12, 12);
            grbConsultarClientes.Name = "grbConsultarClientes";
            grbConsultarClientes.Size = new Size(632, 500);
            grbConsultarClientes.TabIndex = 0;
            grbConsultarClientes.TabStop = false;
            grbConsultarClientes.Text = "Consultar Clientes";
            // 
            // dgvConsultaCliente
            // 
            dgvConsultaCliente.AllowUserToAddRows = false;
            dgvConsultaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaCliente.Location = new Point(6, 76);
            dgvConsultaCliente.MultiSelect = false;
            dgvConsultaCliente.Name = "dgvConsultaCliente";
            dgvConsultaCliente.ReadOnly = true;
            dgvConsultaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaCliente.Size = new Size(557, 418);
            dgvConsultaCliente.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 37);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(335, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(6, 19);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(138, 15);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Nome, CPF ou Telefone: ";
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { alterarToolStripMenuItem, deletarToolStripMenuItem });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.Size = new Size(112, 48);
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(111, 22);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(111, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            // 
            // frmConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 577);
            Controls.Add(grbConsultarClientes);
            Name = "frmConsultarClientes";
            Text = "frmConsultarClientes";
            Load += frmConsultarClientes_Load;
            grbConsultarClientes.ResumeLayout(false);
            grbConsultarClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaCliente).EndInit();
            contextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultarClientes;
        private Label lblPesquisa;
        private DataGridView dgvConsultaCliente;
        private TextBox txtPesquisa;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
    }
}