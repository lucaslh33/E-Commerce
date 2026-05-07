namespace Ecommerce
{
    partial class frmCadCliente
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
            grbInformacoesEndereco = new GroupBox();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtEstado = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            lblEstado = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            lblNumero = new Label();
            lblRua = new Label();
            mskCep = new MaskedTextBox();
            btnCadastrar = new Button();
            lblCep = new Label();
            grbinformacoescliente = new GroupBox();
            lblCelular = new Label();
            mskCelular = new MaskedTextBox();
            mskTelefone = new MaskedTextBox();
            mskDtNascimento = new MaskedTextBox();
            txtEmail = new TextBox();
            lblDtNascimento = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            lblEmail = new Label();
            lblCPF = new Label();
            mskCPF = new MaskedTextBox();
            grbAcesso = new GroupBox();
            lblSenha = new Label();
            lblConfirmarsenha = new Label();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            btnCancelar = new Button();
            grbInformacoesEndereco.SuspendLayout();
            grbinformacoescliente.SuspendLayout();
            grbAcesso.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoesEndereco
            // 
            grbInformacoesEndereco.Controls.Add(txtObservacoes);
            grbInformacoesEndereco.Controls.Add(lblObservacoes);
            grbInformacoesEndereco.Controls.Add(txtComplemento);
            grbInformacoesEndereco.Controls.Add(lblComplemento);
            grbInformacoesEndereco.Controls.Add(txtEstado);
            grbInformacoesEndereco.Controls.Add(txtCidade);
            grbInformacoesEndereco.Controls.Add(txtBairro);
            grbInformacoesEndereco.Controls.Add(txtNumero);
            grbInformacoesEndereco.Controls.Add(txtRua);
            grbInformacoesEndereco.Controls.Add(lblEstado);
            grbInformacoesEndereco.Controls.Add(lblCidade);
            grbInformacoesEndereco.Controls.Add(lblBairro);
            grbInformacoesEndereco.Controls.Add(lblNumero);
            grbInformacoesEndereco.Controls.Add(lblRua);
            grbInformacoesEndereco.Controls.Add(mskCep);
            grbInformacoesEndereco.Controls.Add(lblCep);
            grbInformacoesEndereco.Location = new Point(12, 139);
            grbInformacoesEndereco.Name = "grbInformacoesEndereco";
            grbInformacoesEndereco.Size = new Size(653, 299);
            grbInformacoesEndereco.TabIndex = 13;
            grbInformacoesEndereco.TabStop = false;
            grbInformacoesEndereco.Text = "Informações endereço:";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(6, 150);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(452, 127);
            txtObservacoes.TabIndex = 21;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(6, 132);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(80, 15);
            lblObservacoes.TabIndex = 20;
            lblObservacoes.Text = "Observações: ";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(6, 97);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(227, 23);
            txtComplemento.TabIndex = 19;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(6, 79);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(90, 15);
            lblComplemento.TabIndex = 18;
            lblComplemento.Text = "Complemento: ";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(358, 97);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 17;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(239, 97);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 16;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(448, 41);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(158, 23);
            txtBairro.TabIndex = 15;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(358, 41);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(57, 23);
            txtNumero.TabIndex = 14;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(93, 41);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(245, 23);
            txtRua.TabIndex = 13;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(358, 79);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(48, 15);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado: ";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(239, 79);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(50, 15);
            lblCidade.TabIndex = 11;
            lblCidade.Text = "Cidade: ";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(448, 23);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(44, 15);
            lblBairro.TabIndex = 10;
            lblBairro.Text = "Bairro: ";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(358, 23);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 9;
            lblNumero.Text = "Número: ";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(93, 23);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(33, 15);
            lblRua.TabIndex = 8;
            lblRua.Text = "Rua: ";
            // 
            // mskCep
            // 
            mskCep.Location = new Point(6, 41);
            mskCep.Mask = "14404-249";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(70, 23);
            mskCep.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(590, 557);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(6, 23);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 5;
            lblCep.Text = "CEP:";
            // 
            // grbinformacoescliente
            // 
            grbinformacoescliente.Controls.Add(lblCelular);
            grbinformacoescliente.Controls.Add(mskCelular);
            grbinformacoescliente.Controls.Add(mskTelefone);
            grbinformacoescliente.Controls.Add(mskDtNascimento);
            grbinformacoescliente.Controls.Add(txtEmail);
            grbinformacoescliente.Controls.Add(lblDtNascimento);
            grbinformacoescliente.Controls.Add(lblNome);
            grbinformacoescliente.Controls.Add(lblTelefone);
            grbinformacoescliente.Controls.Add(txtNome);
            grbinformacoescliente.Controls.Add(lblEmail);
            grbinformacoescliente.Controls.Add(lblCPF);
            grbinformacoescliente.Controls.Add(mskCPF);
            grbinformacoescliente.Location = new Point(12, 12);
            grbinformacoescliente.Name = "grbinformacoescliente";
            grbinformacoescliente.Size = new Size(653, 121);
            grbinformacoescliente.TabIndex = 12;
            grbinformacoescliente.TabStop = false;
            grbinformacoescliente.Text = "Informações Cliente:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(392, 74);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 13;
            lblCelular.Text = "Celular:";
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(392, 92);
            mskCelular.Mask = "(16)99219-4670";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(100, 23);
            mskCelular.TabIndex = 12;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(267, 92);
            mskTelefone.Mask = "3701-9471";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(86, 23);
            mskTelefone.TabIndex = 11;
            // 
            // mskDtNascimento
            // 
            mskDtNascimento.Location = new Point(392, 37);
            mskDtNascimento.Mask = "00/00/0000";
            mskDtNascimento.Name = "mskDtNascimento";
            mskDtNascimento.Size = new Size(100, 23);
            mskDtNascimento.TabIndex = 6;
            mskDtNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblDtNascimento
            // 
            lblDtNascimento.AutoSize = true;
            lblDtNascimento.Location = new Point(392, 22);
            lblDtNascimento.Name = "lblDtNascimento";
            lblDtNascimento.Size = new Size(112, 15);
            lblDtNascimento.TabIndex = 4;
            lblDtNascimento.Text = "Data de nascimento";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(187, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Por favor insira o nome completo:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(267, 76);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 23);
            txtNome.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 76);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-MAIL:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(267, 19);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(86, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "Informe o CPF:";
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(267, 37);
            mskCPF.Mask = "111.111.111-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(100, 23);
            mskCPF.TabIndex = 3;
            // 
            // grbAcesso
            // 
            grbAcesso.Controls.Add(txtConfirmarSenha);
            grbAcesso.Controls.Add(txtSenha);
            grbAcesso.Controls.Add(lblConfirmarsenha);
            grbAcesso.Controls.Add(lblSenha);
            grbAcesso.Location = new Point(12, 444);
            grbAcesso.Name = "grbAcesso";
            grbAcesso.Size = new Size(458, 92);
            grbAcesso.TabIndex = 14;
            grbAcesso.TabStop = false;
            grbAcesso.Text = "Acesso: ";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(14, 20);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 15);
            lblSenha.TabIndex = 0;
            lblSenha.Text = "Senha: ";
            // 
            // lblConfirmarsenha
            // 
            lblConfirmarsenha.AutoSize = true;
            lblConfirmarsenha.Location = new Point(231, 20);
            lblConfirmarsenha.Name = "lblConfirmarsenha";
            lblConfirmarsenha.Size = new Size(101, 15);
            lblConfirmarsenha.TabIndex = 1;
            lblConfirmarsenha.Text = "Confirmar senha: ";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(14, 38);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(179, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(231, 38);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(179, 23);
            txtConfirmarSenha.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 557);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 592);
            Controls.Add(btnCancelar);
            Controls.Add(grbAcesso);
            Controls.Add(grbInformacoesEndereco);
            Controls.Add(grbinformacoescliente);
            Controls.Add(btnCadastrar);
            Name = "frmCadCliente";
            Text = "frmCadCliente";
            Load += frmCadastroCliente_Load;
            grbInformacoesEndereco.ResumeLayout(false);
            grbInformacoesEndereco.PerformLayout();
            grbinformacoescliente.ResumeLayout(false);
            grbinformacoescliente.PerformLayout();
            grbAcesso.ResumeLayout(false);
            grbAcesso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesEndereco;
        private TextBox txtObservacoes;
        private Label lblObservacoes;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtEstado;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtRua;
        private Label lblEstado;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblNumero;
        private Label lblRua;
        private MaskedTextBox mskCep;
        private Button btnCadastrar;
        private Label lblCep;
        private GroupBox grbinformacoescliente;
        private Label lblCelular;
        private MaskedTextBox mskCelular;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskDtNascimento;
        private TextBox txtEmail;
        private Label lblDtNascimento;
        private Label lblNome;
        private Label lblTelefone;
        private TextBox txtNome;
        private Label lblEmail;
        private Label lblCPF;
        private MaskedTextBox mskCPF;
        private GroupBox grbAcesso;
        private TextBox txtConfirmarSenha;
        private TextBox txtSenha;
        private Label lblConfirmarsenha;
        private Label lblSenha;
        private Button btnCancelar;
    }
}