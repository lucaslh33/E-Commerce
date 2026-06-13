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
    public partial class frmCadFornecedor : Form
    {
        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "INSERT INTO tblfornecedor VALUES (@nome, @nomefantasia, @cnpj, @email, @telefone, @celular, @cep, @rua, @numero, @bairro, @cidade, @estado, @observacoes,@status_ativo)";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@nomefantasia", txtNomeFantasia.Text);
                        cmd.Parameters.AddWithValue("@cnpj", mskCNPJ.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                        cmd.Parameters.AddWithValue("@celular", mskCelular.Text);
                        cmd.Parameters.AddWithValue("@cep", mskCEP.Text);
                        cmd.Parameters.AddWithValue("@rua", txtRua.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                        cmd.Parameters.AddWithValue("@observacoes", txtObservacoes.Text);
                        cmd.Parameters.AddWithValue("@status_ativo", "A");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Clear();
                        txtNomeFantasia.Clear();
                        txtEmail.Clear();
                        mskTelefone.Clear();
                        mskCelular.Clear();
                        mskCEP.Clear();
                        txtRua.Clear();
                        txtNumero.Clear();
                        txtBairro.Clear();
                        txtCidade.Clear();
                        cmbEstado.SelectedIndex = -1;
                        txtObservacoes.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
