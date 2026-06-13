namespace Ecommerce
{
    partial class frmConsultarCategoriaInativa
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
            grbConsultarCategorias = new GroupBox();
            dgvConsultarCategorias = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            reativarToolStripMenuItem = new ToolStripMenuItem();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            grbConsultarCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCategorias).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbConsultarCategorias
            // 
            grbConsultarCategorias.Controls.Add(dgvConsultarCategorias);
            grbConsultarCategorias.Controls.Add(txtPesquisa);
            grbConsultarCategorias.Controls.Add(lblPesquisa);
            grbConsultarCategorias.Location = new Point(12, 12);
            grbConsultarCategorias.Name = "grbConsultarCategorias";
            grbConsultarCategorias.Size = new Size(577, 500);
            grbConsultarCategorias.TabIndex = 2;
            grbConsultarCategorias.TabStop = false;
            grbConsultarCategorias.Text = "Consultar categorias inativas:";
            // 
            // dgvConsultarCategorias
            // 
            dgvConsultarCategorias.AllowUserToAddRows = false;
            dgvConsultarCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarCategorias.BorderStyle = BorderStyle.None;
            dgvConsultarCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarCategorias.ContextMenuStrip = contextMenuStrip1;
            dgvConsultarCategorias.Location = new Point(6, 76);
            dgvConsultarCategorias.Name = "dgvConsultarCategorias";
            dgvConsultarCategorias.ScrollBars = ScrollBars.None;
            dgvConsultarCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarCategorias.Size = new Size(557, 418);
            dgvConsultarCategorias.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { reativarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // reativarToolStripMenuItem
            // 
            reativarToolStripMenuItem.Name = "reativarToolStripMenuItem";
            reativarToolStripMenuItem.Size = new Size(180, 22);
            reativarToolStripMenuItem.Text = "Restaurar";
            reativarToolStripMenuItem.Click += reativarToolStripMenuItem_Click;
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
            // frmConsultarCategoriaInativa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 533);
            Controls.Add(grbConsultarCategorias);
            Name = "frmConsultarCategoriaInativa";
            Text = "frmConsultarCategoriaInativa";
            Load += frmConsultarCategoriaInativa_Load;
            grbConsultarCategorias.ResumeLayout(false);
            grbConsultarCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCategorias).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultarCategorias;
        private DataGridView dgvConsultarCategorias;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem reativarToolStripMenuItem;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
    }
}