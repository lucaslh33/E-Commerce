using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Ecommerce
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show(
                    "Preencha e-mail e senha.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Conexao conexao = new Conexao();

            using (SqlConnection con = conexao.Conectar())
            {
                string sql = "SELECT senha FROM tblusuario WHERE email = @email AND status_ativo = 'A'";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null)
                    {
                        MessageBox.Show(
                            "E-mail ou senha inválidos.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    string hashSalvo = resultado.ToString();

                    if (BCrypt.Net.BCrypt.EnhancedVerify(senha, hashSalvo))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(
                            "E-mail ou senha inválidos.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\0'; 
            }
            else
            {
                txtSenha.PasswordChar = '*'; 
            }
        }
    }
}