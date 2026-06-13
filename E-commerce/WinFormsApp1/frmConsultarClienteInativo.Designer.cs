namespace Ecommerce
{
    partial class frmConsultarClienteInativo
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
            dgvConsultarClientes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            grbConsultarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbConsultarClientes
            // 
            grbConsultarClientes.Controls.Add(dgvConsultarClientes);
            grbConsultarClientes.Controls.Add(txtPesquisa);
            grbConsultarClientes.Controls.Add(lblPesquisa);
            grbConsultarClientes.Location = new Point(12, 12);
            grbConsultarClientes.Name = "grbConsultarClientes";
            grbConsultarClientes.Size = new Size(577, 500);
            grbConsultarClientes.TabIndex = 3;
            grbConsultarClientes.TabStop = false;
            grbConsultarClientes.Text = "Consultar clientes inativos:";
            // 
            // dgvConsultarClientes
            // 
            dgvConsultarClientes.AllowUserToAddRows = false;
            dgvConsultarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarClientes.BorderStyle = BorderStyle.None;
            dgvConsultarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarClientes.ContextMenuStrip = contextMenuStrip1;
            dgvConsultarClientes.Location = new Point(6, 66);
            dgvConsultarClientes.Name = "dgvConsultarClientes";
            dgvConsultarClientes.ScrollBars = ScrollBars.None;
            dgvConsultarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarClientes.Size = new Size(557, 418);
            dgvConsultarClientes.TabIndex = 2;
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
            txtPesquisa.Size = new Size(305, 23);
            txtPesquisa.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(6, 19);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(100, 15);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Nome, Descrição:";
            // 
            // frmConsultarClienteInativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 521);
            Controls.Add(grbConsultarClientes);
            Name = "frmConsultarClienteInativo";
            Text = "frmConsultarClienteInativo";
            Load += frmConsultarClienteInativo_Load;
            grbConsultarClientes.ResumeLayout(false);
            grbConsultarClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultarClientes;
        private DataGridView dgvConsultarClientes;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem restaurarToolStripMenuItem;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
    }
}