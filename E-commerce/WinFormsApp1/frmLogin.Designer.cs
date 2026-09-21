namespace Ecommerce
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pcbLogin = new PictureBox();
            lblLogin = new Label();
            lblSenha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            lnkRecuperarSenha = new LinkLabel();
            lnkSuporte = new LinkLabel();
            btnCadastrar = new Button();
            chkMostrarSenha = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogin).BeginInit();
            SuspendLayout();
            // 
            // pcbLogin
            // 
            pcbLogin.Image = (Image)resources.GetObject("pcbLogin.Image");
            pcbLogin.Location = new Point(42, 38);
            pcbLogin.Name = "pcbLogin";
            pcbLogin.Size = new Size(225, 225);
            pcbLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            pcbLogin.TabIndex = 0;
            pcbLogin.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(323, 78);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(112, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "E-mail ou Telefone: ";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(323, 137);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(323, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(323, 155);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(222, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(373, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Enter;
            // 
            // lnkRecuperarSenha
            // 
            lnkRecuperarSenha.AutoSize = true;
            lnkRecuperarSenha.Location = new Point(373, 283);
            lnkRecuperarSenha.Name = "lnkRecuperarSenha";
            lnkRecuperarSenha.Size = new Size(118, 15);
            lnkRecuperarSenha.TabIndex = 6;
            lnkRecuperarSenha.TabStop = true;
            lnkRecuperarSenha.Text = "Esqueci minha senha";
            // 
            // lnkSuporte
            // 
            lnkSuporte.AutoSize = true;
            lnkSuporte.Location = new Point(42, 283);
            lnkSuporte.Name = "lnkSuporte";
            lnkSuporte.Size = new Size(48, 15);
            lnkSuporte.TabIndex = 7;
            lnkSuporte.TabStop = true;
            lnkSuporte.Text = "Suporte";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(373, 240);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Location = new Point(551, 157);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(102, 19);
            chkMostrarSenha.TabIndex = 9;
            chkMostrarSenha.Text = "Mostrar Senha";
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 320);
            Controls.Add(chkMostrarSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(lnkSuporte);
            Controls.Add(lnkRecuperarSenha);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(pcbLogin);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogin;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnLogin;
        private LinkLabel lnkRecuperarSenha;
        private LinkLabel lnkSuporte;
        private Button btnCadastrar;
        private CheckBox chkMostrarSenha;
    }
}