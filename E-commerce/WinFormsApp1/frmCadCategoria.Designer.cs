namespace Ecommerce
{
    partial class frmCadCategoria
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
            grbInformacoes = new GroupBox();
            lblNome = new Label();
            lblDescricaoCategoria = new Label();
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            btnCadastrar = new Button();
            grbInformacoes.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoes
            // 
            grbInformacoes.Controls.Add(txtDescricao);
            grbInformacoes.Controls.Add(txtNome);
            grbInformacoes.Controls.Add(lblDescricaoCategoria);
            grbInformacoes.Controls.Add(lblNome);
            grbInformacoes.Location = new Point(12, 12);
            grbInformacoes.Name = "grbInformacoes";
            grbInformacoes.Size = new Size(441, 169);
            grbInformacoes.TabIndex = 0;
            grbInformacoes.TabStop = false;
            grbInformacoes.Text = "Informações da Categoria: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(19, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(114, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome da categoria: ";
            // 
            // lblDescricaoCategoria
            // 
            lblDescricaoCategoria.AutoSize = true;
            lblDescricaoCategoria.Location = new Point(19, 64);
            lblDescricaoCategoria.Name = "lblDescricaoCategoria";
            lblDescricaoCategoria.Size = new Size(116, 15);
            lblDescricaoCategoria.TabIndex = 1;
            lblDescricaoCategoria.Text = "Descrição categoria: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 23);
            txtNome.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(19, 82);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(326, 81);
            txtDescricao.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(378, 187);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // frmCadCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 220);
            Controls.Add(btnCadastrar);
            Controls.Add(grbInformacoes);
            Name = "frmCadCategoria";
            Text = "frmCadCategoria";
            grbInformacoes.ResumeLayout(false);
            grbInformacoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoes;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private Label lblDescricaoCategoria;
        private Label lblNome;
        private Button btnCadastrar;
    }
}