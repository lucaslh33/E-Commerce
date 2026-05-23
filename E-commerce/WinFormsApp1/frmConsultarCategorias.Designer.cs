namespace Ecommerce
{
    partial class frmConsultarCategorias
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
            grbConsultarCategorias = new GroupBox();
            dgvConsultarCategorias = new DataGridView();
            txtPesquisa = new TextBox();
            lblPesquisa = new Label();
            grbConsultarCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCategorias).BeginInit();
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
            grbConsultarCategorias.TabIndex = 1;
            grbConsultarCategorias.TabStop = false;
            grbConsultarCategorias.Text = "Consultar categorias:";
            // 
            // dgvConsultarCategorias
            // 
            dgvConsultarCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarCategorias.Location = new Point(6, 76);
            dgvConsultarCategorias.Name = "dgvConsultarCategorias";
            dgvConsultarCategorias.Size = new Size(557, 418);
            dgvConsultarCategorias.TabIndex = 2;
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
            // frmConsultarCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 532);
            Controls.Add(grbConsultarCategorias);
            Name = "frmConsultarCategorias";
            Text = "frmConsultarCategorias";
            grbConsultarCategorias.ResumeLayout(false);
            grbConsultarCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbConsultarCategorias;
        private DataGridView dgvConsultarCategorias;
        private TextBox txtPesquisa;
        private Label lblPesquisa;
    }
}