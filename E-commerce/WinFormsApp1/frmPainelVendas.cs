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
    public partial class frmPainelVendas : Form
    {
        List<ItemVenda> itens = new List<ItemVenda>();
        private DataRow ProdutoSelecionado;


        public frmPainelVendas()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            txtCodigoBarras.Clear();
            txtCodigoBarras.Focus();

            lblRetornoProduto.Text = "";
            lblRetornoCategoria.Text = "";
            lblRetornoCodigo.Text = "";
            lblRetornoPrecoUnitario.Text = "";
            lblRetornoEstoque.Text = "";

            ProdutoSelecionado = null;
        }

        private void AtualizarSubTotal()
        {
            decimal subtotal = itens.Sum(x => x.Total);

            lblSubTotalRecebido.Text = subtotal.ToString("C2");
            lblRetornoTotal.Text = subtotal.ToString("C2");


        }

        private void AtualizarGrid()
        {
            dgvItemVenda.DataSource = null;
            dgvItemVenda.DataSource = itens;

            lblRetornoQuantidade.Text = itens.Sum(x => x.Quantidade).ToString();

            AtualizarSubTotal();
        }

        private void AdicionarItem()
        {
            if (ProdutoSelecionado == null)
            {
                MessageBox.Show("Pesquise um produto antes de adicioná-lo à venda.", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemVenda itemExistente = itens.FirstOrDefault(x => x.Codigo.Trim() == ProdutoSelecionado["CÓDIGO"].ToString().Trim());

            if (itemExistente == null)
            {
                ItemVenda item = new ItemVenda();
                item.Codigo = ProdutoSelecionado["CÓDIGO"].ToString();
                item.Nome = ProdutoSelecionado["NOME"].ToString();
                item.Categoria = ProdutoSelecionado["CATEGORIA"].ToString();
                item.Preco = Convert.ToDecimal(ProdutoSelecionado["PREÇO"]);
                item.Quantidade = 1;

                lblRetornoQuantidade.Text = item.Quantidade.ToString();


                itens.Add(item);
                AtualizarGrid();
            }

            else
            {
                itemExistente.Quantidade++;
                lblRetornoQuantidade.Text = itemExistente.Quantidade.ToString();
                AtualizarGrid();
            }


        }

        public bool CarregarItem()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text))
                {

                    return false;
                }

                Conexao conexao = new Conexao();
                string sql = "SELECT p.ean AS 'CÓDIGO', p.nome AS 'NOME', c.nome AS 'CATEGORIA', p.descricao 'DESCRIÇÃO', p.marca AS 'MARCA', p.preco AS 'PREÇO', p.estoque as 'ESTOQUE' FROM tblproduto p INNER JOIN  tblcategoria c ON p.categoria_id = c.id WHERE (p.ean LIKE @filtro OR p.nome LIKE @filtro OR p.descricao LIKE @filtro OR p.preco LIKE @filtro OR p.estoque LIKE @filtro) AND p.status_ativo = 'A'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtCodigoBarras.Text + "%");


                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);



                        if (dt.Rows.Count > 0)
                        {
                            ProdutoSelecionado = dt.Rows[0];

                            lblRetornoProduto.Text = dt.Rows[0]["NOME"].ToString();
                            lblRetornoPrecoUnitario.Text = Convert.ToDecimal(dt.Rows[0]["PREÇO"]).ToString("C2");

                            lblRetornoCategoria.Text = dt.Rows[0]["CATEGORIA"].ToString();
                            lblRetornoCodigo.Text = dt.Rows[0]["CÓDIGO"].ToString();
                            lblRetornoEstoque.Text = dt.Rows[0]["ESTOQUE"].ToString();

                            return true;
                        }


                        ProdutoSelecionado = null;
                        return false;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar produto! ", "ERRO!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dgvItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPainelVendas_Load(object sender, EventArgs e)
        {
            txtCodigoBarras.Text = "Digite o código de barras";
            txtCodigoBarras.ForeColor = Color.Gray;


        }

        private void txtCodigoBarras_Enter(object sender, EventArgs e)
        {
            if (txtCodigoBarras.Text == "Digite o código de barras")
            {
                txtCodigoBarras.Text = "";
                txtCodigoBarras.ForeColor = Color.Black;
            }
        }

        private void txtCodigoBarras_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text))
            {
                txtCodigoBarras.Text = "";
                txtCodigoBarras.ForeColor = Color.Gray;
            }
        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CarregarItem())
                {
                    AdicionarItem();

                    txtCodigoBarras.Clear();
                    txtCodigoBarras.Focus();
                }
            }

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (CarregarItem())
            {
                AdicionarItem();

                txtCodigoBarras.Clear();
                txtCodigoBarras.Focus();
            }
        }

        private void btnCLientes_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes();
            frmConsultarClientes.ShowDialog();
        }

        private void btnProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultarProdutos frmConsultarProdutos = new frmConsultarProdutos();
            frmConsultarProdutos.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimparVenda_Click(object sender, EventArgs e)
        {
            itens.Clear();
            AtualizarGrid();
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            ItemVenda itemExistente = itens.FirstOrDefault(x => x.Codigo.Trim() == ProdutoSelecionado["CÓDIGO"].ToString().Trim());
            if (itemExistente != null)
            {
                itemExistente.Quantidade--;
                lblRetornoQuantidade.Text = itemExistente.Quantidade.ToString();

                if (itemExistente.Quantidade <= 0)
                {
                    itens.Remove(itemExistente);

                }
                AtualizarGrid();
            }

        }

        private void btnAdicionarNovaVenda_Click(object sender, EventArgs e)
        {
            itens.Clear();

            AtualizarGrid();
            LimparTela();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            itens.Clear();

            AtualizarGrid();
            LimparTela();
        }
    }
}
