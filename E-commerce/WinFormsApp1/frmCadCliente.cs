using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "INSERT INTO tblcliente VALUES(@nome, @cpf, @datanascimento, @email, @celular, @telefone, @senha)";

                using (SqlConnection conn = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cpf", mskCPF.Text);
                        cmd.Parameters.AddWithValue("@datanascimento", mskDtNascimento.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@celular", mskCelular.Text);
                        cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                        cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Clear();
                        mskCPF.Clear();
                        mskDtNascimento.Clear();
                        txtEmail.Clear();
                        mskCelular.Clear();
                        mskTelefone.Clear();
                        txtSenha.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Conexao conexao = new Conexao();
                string sql = ("INSERT INTO tblendereco VALUES(@rua,@numero,@complemento,@bairro,@cidade,@estado,@cep,@observacoes)");

                using (SqlConnection conn = conexao.Conectar())
                {
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@rua", txtRua.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                        cmd.Parameters.AddWithValue(@"cep",mskCep.Text);
                        cmd.Parameters.AddWithValue("@observacoes", txtObservacoes.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Endereço cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtRua.Clear();
                        txtNumero.Clear();
                        txtComplemento.Clear();
                        txtBairro.Clear();
                        txtCidade.Clear();
                        mskCep.Clear();
                        txtObservacoes.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar endereço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
