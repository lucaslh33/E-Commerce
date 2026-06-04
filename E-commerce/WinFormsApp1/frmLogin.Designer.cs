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
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            lnkRecuperarSenha = new LinkLabel();
            lnkSuporte = new LinkLabel();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(342, 77);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(112, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "E-mail ou Telefone: ";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(342, 136);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha: ";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(347, 97);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(222, 23);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(347, 154);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(222, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(394, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lnkRecuperarSenha
            // 
            lnkRecuperarSenha.AutoSize = true;
            lnkRecuperarSenha.Location = new Point(394, 283);
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
            btnCadastrar.Location = new Point(394, 240);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastre-se";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 320);
            Controls.Add(btnCadastrar);
            Controls.Add(lnkSuporte);
            Controls.Add(lnkRecuperarSenha);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnLogin;
        private LinkLabel lnkRecuperarSenha;
        private LinkLabel lnkSuporte;
        private Button btnCadastrar;
    }
}