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
            grbConsultaFornecedores = new GroupBox();
            dgvConsultaFornecedores = new DataGridView();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            grbConsultaFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaFornecedores).BeginInit();
            SuspendLayout();
            // 
            // grbConsultaFornecedores
            // 
            grbConsultaFornecedores.Controls.Add(dgvConsultaFornecedores);
            grbConsultaFornecedores.Controls.Add(txtPesquisa);
            grbConsultaFornecedores.Controls.Add(lblPesquisa);
            grbConsultaFornecedores.Location = new Point(12, 12);
            grbConsultaFornecedores.Name = "grbConsultaFornecedores";
            grbConsultaFornecedores.Size = new Size(632, 500);
            grbConsultaFornecedores.TabIndex = 1;
            grbConsultaFornecedores.TabStop = false;
            grbConsultaFornecedores.Text = "Consultar Fornecedores";
            // 
            // dgvConsultaFornecedores
            // 
            dgvConsultaFornecedores.AllowUserToAddRows = false;
            dgvConsultaFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultaFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // frmConsultarFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 534);
            Controls.Add(grbConsultaFornecedores);
            Name = "frmConsultarFornecedores";
            Text = "frmConsultarFornecedores";
            Load += frmConsultarFornecedores_Load;
            grbConsultaFornecedores.ResumeLayout(false);
            grbConsultaFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaFornecedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultaFornecedores;
        private DataGridView dgvConsultaFornecedores;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
    }
}