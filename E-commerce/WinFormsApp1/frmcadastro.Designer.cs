namespace WinFormsApp1
{
    partial class Frmcadastrocliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCPF = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            btnCadastrar = new Button();
            grbinformacoescliente = new GroupBox();
            lblCelular = new Label();
            mskCelular = new MaskedTextBox();
            mskTelefone = new MaskedTextBox();
            mskDtNascimento = new MaskedTextBox();
            txtEmail = new TextBox();
            lblDtNascimento = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblCep = new Label();
            mskCep = new MaskedTextBox();
            grbInformacoesEndereco = new GroupBox();
            lblRua = new Label();
            lblNumero = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblObservacoes = new Label();
            txtObservacoes = new TextBox();
            grbinformacoescliente.SuspendLayout();
            grbInformacoesEndereco.SuspendLayout();
            SuspendLayout();
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
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(267, 19);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(86, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "Informe o CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 23);
            txtNome.TabIndex = 2;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(267, 37);
            mskCPF.Mask = "111.111.111-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(100, 23);
            mskCPF.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(572, 270);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
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
            grbinformacoescliente.TabIndex = 5;
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
            mskCelular.MaskInputRejected += maskedTextBox2_MaskInputRejected;
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
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(267, 76);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone:";
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
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(6, 23);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 5;
            lblCep.Text = "CEP:";
            // 
            // mskCep
            // 
            mskCep.Location = new Point(6, 41);
            mskCep.Mask = "14404-249";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(70, 23);
            mskCep.TabIndex = 7;
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
            grbInformacoesEndereco.Controls.Add(btnCadastrar);
            grbInformacoesEndereco.Controls.Add(lblCep);
            grbInformacoesEndereco.Location = new Point(12, 139);
            grbInformacoesEndereco.Name = "grbInformacoesEndereco";
            grbInformacoesEndereco.Size = new Size(653, 299);
            grbInformacoesEndereco.TabIndex = 11;
            grbInformacoesEndereco.TabStop = false;
            grbInformacoesEndereco.Text = "Informações endereço:";
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
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(358, 23);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 9;
            lblNumero.Text = "Número: ";
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
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(239, 79);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(50, 15);
            lblCidade.TabIndex = 11;
            lblCidade.Text = "Cidade: ";
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
            // txtRua
            // 
            txtRua.Location = new Point(93, 41);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(245, 23);
            txtRua.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(358, 41);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(57, 23);
            txtNumero.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(448, 41);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(158, 23);
            txtBairro.TabIndex = 15;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(239, 97);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 16;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(358, 97);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 17;
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
            // txtComplemento
            // 
            txtComplemento.Location = new Point(6, 97);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(227, 23);
            txtComplemento.TabIndex = 19;
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
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(6, 150);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(452, 127);
            txtObservacoes.TabIndex = 21;
            // 
            // Frmcadastrocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(grbInformacoesEndereco);
            Controls.Add(grbinformacoescliente);
            Name = "Frmcadastrocliente";
            Text = "Cadastro cliente - Ecommerce";
            grbinformacoescliente.ResumeLayout(false);
            grbinformacoescliente.PerformLayout();
            grbInformacoesEndereco.ResumeLayout(false);
            grbInformacoesEndereco.PerformLayout();
            ResumeLayout(false);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblNome;
        private Label lblCPF;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private Button btnCadastrar;
        private GroupBox grbinformacoescliente;
        private MaskedTextBox mskDtNascimento;
        private Label lblCep;
        private Label lblDtNascimento;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtEmail;
        private MaskedTextBox mskCep;
        private GroupBox grbInformacoesEndereco;
        private Label lblCelular;
        private MaskedTextBox mskCelular;
        private MaskedTextBox mskTelefone;
        private Label lblBairro;
        private Label lblNumero;
        private Label lblRua;
        private Label lblEstado;
        private Label lblCidade;
        private Label lblComplemento;
        private TextBox txtEstado;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtRua;
        private Label lblObservacoes;
        private TextBox txtComplemento;
        private TextBox txtObservacoes;
    }
}
