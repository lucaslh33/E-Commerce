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
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }
        public DataTable CarregarFornecedor()
        {
            Conexao conexao = new Conexao();

            string sql = "SELECT id, nomefantasia FROM tblfornecedor";

            using (SqlConnection con = conexao.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "INSERT INTO tblproduto VALUES (@nome,@preco,@estoque,@peso,@altura,@largura,@comprimento,@descricao,@marca,@ean,@sku,@fornecedor_id,@categoria_id,@imagem1,@imagem2,@imagem3)";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@preco", numPreco.Value);
                        cmd.Parameters.AddWithValue("@estoque", numEstoque.Value);
                        cmd.Parameters.AddWithValue("@peso", numPeso.Value);
                        cmd.Parameters.AddWithValue("@altura", numAltura.Value);
                        cmd.Parameters.AddWithValue("@largura", numLargura.Value);
                        cmd.Parameters.AddWithValue("@comprimento", numComprimento.Value);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@ean", txtEAN.Text);
                        cmd.Parameters.AddWithValue("@sku", txtSKU.Text);
                        cmd.Parameters.AddWithValue("@fornecedor_id", cmbFornecedor.SelectedValue);
                        cmd.Parameters.AddWithValue("@categoria_id", cmbCategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@imagem1", "");
                        cmd.Parameters.AddWithValue("@imagem2", "");
                        cmd.Parameters.AddWithValue("@imagem3", "");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Clear();
                        numPreco.Value = 0;
                        numEstoque.Value = 0;
                        numPeso.Value = 0;
                        numAltura.Value = 0;
                        numLargura.Value = 0;
                        numComprimento.Value = 0;
                        txtDescricao.Clear();
                        txtMarca.Clear();
                        txtEAN.Clear();
                        txtSKU.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmCadProduto_Load_1(object sender, EventArgs e)
        {
            DataTable dt = CarregarFornecedor();
            cmbFornecedor.DataSource = dt;
            cmbFornecedor.DisplayMember = "nomefantasia";
            cmbFornecedor.ValueMember = "id";
        }
    }
}
