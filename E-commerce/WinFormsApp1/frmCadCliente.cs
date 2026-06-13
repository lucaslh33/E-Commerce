using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
            int clienteId = 0;
            string senha = txtSenha.Text;
            if (senha.Length < 6)
            {
                MessageBox.Show("A senha dever ter no mínimo 6 caracteres");
                return;
            }

            try
            {
                Conexao conexao = new Conexao();

                string sql = "INSERT INTO tblcliente (nome, cpf, datanascimento, email, celular, telefone, senha) OUTPUT INSERTED.id VALUES(@nome, @cpf, @datanascimento, @email, @celular, @telefone, @senha)";

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
                        clienteId = (int)cmd.ExecuteScalar();

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
                string sql = ("INSERT INTO tblendereco VALUES(@cliente_id,@rua,@numero,@complemento,@bairro,@cidade,@estado,@cep,@observacoes)");

                using (SqlConnection conn = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente_id", clienteId);
                        cmd.Parameters.AddWithValue("@rua", txtRua.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                        cmd.Parameters.AddWithValue("@cep", mskCep.Text);
                        cmd.Parameters.AddWithValue("@observacoes", txtObservacoes.Text);

                        cmd.ExecuteNonQuery();


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
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
