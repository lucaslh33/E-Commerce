namespace Ecommerce
{
    partial class frmCadFornecedor
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
            grbInformacao = new GroupBox();
            cmbEstado = new ComboBox();
            txtObservacoes = new TextBox();
            txtCidade = new TextBox();
            lblNumero = new Label();
            lblRua = new Label();
            lblObservacoes = new Label();
            lblEstado = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            mskCelular = new MaskedTextBox();
            mskTelefone = new MaskedTextBox();
            mskCNPJ = new MaskedTextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtCEP = new TextBox();
            txtEmail = new TextBox();
            txtNomeFantasia = new TextBox();
            txtNome = new TextBox();
            lblCelular = new Label();
            lblCep = new Label();
            lblTelefone = new Label();
            lblEMAIL = new Label();
            lblNomeFantasia = new Label();
            lblCNPJ = new Label();
            lblNome = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            grbInformacao.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacao
            // 
            grbInformacao.Controls.Add(cmbEstado);
            grbInformacao.Controls.Add(txtObservacoes);
            grbInformacao.Controls.Add(txtCidade);
            grbInformacao.Controls.Add(lblNumero);
            grbInformacao.Controls.Add(lblRua);
            grbInformacao.Controls.Add(lblObservacoes);
            grbInformacao.Controls.Add(lblEstado);
            grbInformacao.Controls.Add(lblCidade);
            grbInformacao.Controls.Add(lblBairro);
            grbInformacao.Controls.Add(mskCelular);
            grbInformacao.Controls.Add(mskTelefone);
            grbInformacao.Controls.Add(mskCNPJ);
            grbInformacao.Controls.Add(txtBairro);
            grbInformacao.Controls.Add(txtNumero);
            grbInformacao.Controls.Add(txtRua);
            grbInformacao.Controls.Add(txtCEP);
            grbInformacao.Controls.Add(txtEmail);
            grbInformacao.Controls.Add(txtNomeFantasia);
            grbInformacao.Controls.Add(txtNome);
            grbInformacao.Controls.Add(lblCelular);
            grbInformacao.Controls.Add(lblCep);
            grbInformacao.Controls.Add(lblTelefone);
            grbInformacao.Controls.Add(lblEMAIL);
            grbInformacao.Controls.Add(lblNomeFantasia);
            grbInformacao.Controls.Add(lblCNPJ);
            grbInformacao.Controls.Add(lblNome);
            grbInformacao.Location = new Point(12, 12);
            grbInformacao.Name = "grbInformacao";
            grbInformacao.Size = new Size(690, 384);
            grbInformacao.TabIndex = 0;
            grbInformacao.TabStop = false;
            grbInformacao.Text = "Informações fornecedor: ";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(248, 212);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 26;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(11, 272);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(358, 88);
            txtObservacoes.TabIndex = 25;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(11, 212);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(220, 23);
            txtCidade.TabIndex = 23;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(248, 138);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 22;
            lblNumero.Text = "Número: ";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(11, 138);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(33, 15);
            lblRua.TabIndex = 21;
            lblRua.Text = "Rua: ";
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(11, 254);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(80, 15);
            lblObservacoes.TabIndex = 20;
            lblObservacoes.Text = "Observações: ";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(248, 194);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(48, 15);
            lblEstado.TabIndex = 19;
            lblEstado.Text = "Estado: ";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(11, 194);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(50, 15);
            lblCidade.TabIndex = 18;
            lblCidade.Text = "Cidade: ";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(337, 138);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(44, 15);
            lblBairro.TabIndex = 17;
            lblBairro.Text = "Bairro: ";
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(337, 97);
            mskCelular.Mask = "(00) 00000-0000";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(79, 23);
            mskCelular.TabIndex = 16;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(248, 97);
            mskTelefone.Mask = "(00) 0000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(74, 23);
            mskTelefone.TabIndex = 15;
            // 
            // mskCNPJ
            // 
            mskCNPJ.Location = new Point(477, 39);
            mskCNPJ.Mask = "00.000.000/0000-00";
            mskCNPJ.Name = "mskCNPJ";
            mskCNPJ.Size = new Size(96, 23);
            mskCNPJ.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(337, 156);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(236, 23);
            txtBairro.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(248, 156);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(74, 23);
            txtNumero.TabIndex = 12;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(11, 156);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(220, 23);
            txtRua.TabIndex = 11;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(430, 97);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(143, 23);
            txtCEP.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(11, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Location = new Point(248, 39);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(216, 23);
            txtNomeFantasia.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(11, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(220, 23);
            txtNome.TabIndex = 7;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(336, 79);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(50, 15);
            lblCelular.TabIndex = 6;
            lblCelular.Text = "Celular: ";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(430, 79);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 15);
            lblCep.TabIndex = 5;
            lblCep.Text = "CEP: ";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(248, 79);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(58, 15);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone: ";
            // 
            // lblEMAIL
            // 
            lblEMAIL.AutoSize = true;
            lblEMAIL.Location = new Point(11, 79);
            lblEMAIL.Name = "lblEMAIL";
            lblEMAIL.Size = new Size(52, 15);
            lblEMAIL.TabIndex = 3;
            lblEMAIL.Text = "E-MAIL: ";
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.Location = new Point(248, 19);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(90, 15);
            lblNomeFantasia.TabIndex = 2;
            lblNomeFantasia.Text = "Nome fantasia: ";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(477, 19);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(40, 15);
            lblCNPJ.TabIndex = 1;
            lblCNPJ.Text = "CNPJ: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome: ";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(597, 402);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 36);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(grbInformacao);
            Name = "frmCadFornecedor";
            Text = "frmCadFornecedor";
            grbInformacao.ResumeLayout(false);
            grbInformacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacao;
        private Label lblCelular;
        private Label lblCep;
        private Label lblTelefone;
        private Label lblEMAIL;
        private Label lblNomeFantasia;
        private Label lblCNPJ;
        private Label lblNome;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtCEP;
        private TextBox txtEmail;
        private TextBox txtNomeFantasia;
        private TextBox txtNome;
        private MaskedTextBox mskCNPJ;
        private MaskedTextBox mskCelular;
        private MaskedTextBox mskTelefone;
        private Label lblNumero;
        private Label lblRua;
        private Label lblObservacoes;
        private Label lblEstado;
        private Label lblCidade;
        private Label lblBairro;
        private ComboBox cmbEstado;
        private TextBox txtObservacoes;
        private TextBox txtCidade;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}