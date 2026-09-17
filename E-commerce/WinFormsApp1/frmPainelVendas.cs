using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

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



        private void AdicionarItensPedido()
        {

        }
        

        private bool SalvarVenda()
        {

            Conexao conexao = new Conexao();

            using (SqlConnection con = conexao.Conectar())
            {
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {

                        int enderecoId;
                        string sqlEndereco = "SELECT TOP 1 id FROM tblendereco WHERE cliente_id = @cliente_id ORDER BY id DESC";

                        using (SqlCommand cmdEndereco = new SqlCommand(sqlEndereco, con, transaction))
                        {
                            cmdEndereco.Parameters.AddWithValue("@cliente_id", clienteId);

                            object resultado = cmdEndereco.ExecuteScalar();


                            if (resultado == null)
                            {
                                MessageBox.Show("Este cliente não possui endereço cadastrado. Cadastre um endereço antes de finalizar a venda.",
                                    "Endereço não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return false;
                            }

                            enderecoId = Convert.ToInt32(resultado);

                            

                        }

                        string sqlPedido = @"INSERT INTO tblpedido (cliente_id, data_pedido, subtotal, desconto, total, endereco_id, forma_pagamento_id, status) 
                                           OUTPUT INSERTED.id VALUES (@cliente_id, @data_pedido, @subtotal, @desconto, @total, @endereco_id, @forma_pagamento_id, 'Concluído');";

                        int pedidoId;


                        using (SqlCommand cmdPedido = new SqlCommand(sqlPedido, con, transaction))
                        {
                            decimal subtotal = itens.Sum(x => x.Total);
                            cmdPedido.Parameters.AddWithValue("@cliente_id", (object)clienteId ?? DBNull.Value);
                            cmdPedido.Parameters.AddWithValue("@data_pedido", DateTime.Now);
                            cmdPedido.Parameters.AddWithValue("@subtotal", subtotal);
                            cmdPedido.Parameters.AddWithValue("@desconto", descontoAplicado);
                            cmdPedido.Parameters.AddWithValue("@total", ObterTotalVenda());
                            cmdPedido.Parameters.AddWithValue("@endereco_id", enderecoId);
                            cmdPedido.Parameters.AddWithValue("@forma_pagamento_id", formaPagamento.Value);
                            

                            pedidoId = Convert.ToInt32(cmdPedido.ExecuteScalar());
                        }

                        string sqlItem = @"INSERT INTO tblitempedido (pedido_id, produto_id, quantidade, preco)
                                           VALUES (@pedido_id, @produto_id, @quantidade, @preco);";

                        foreach (var item in itens)
                        {
                            using (SqlCommand cmdItem = new SqlCommand(sqlItem, con, transaction))
                            {
                                cmdItem.Parameters.AddWithValue("@pedido_id", pedidoId);
                                cmdItem.Parameters.AddWithValue("@produto_id", item.IdProduto);
                                cmdItem.Parameters.AddWithValue("@quantidade", item.Quantidade);
                                cmdItem.Parameters.AddWithValue("@preco", item.Preco);


                                cmdItem.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return true;

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao gravar pedido no banco de dados: " + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        private void ConcluirVenda()
        {
            try
            {

                if (itens.Count == 0)
                {
                    MessageBox.Show("Adicione pelo menos um item à venda.", "Venda vazia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clienteId == null)
                {
                    MessageBox.Show("Selecione um cliente antes de finalizar a venda.", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (formaPagamento == null)
                {
                    MessageBox.Show("Selecione uma forma de pagamento.", "Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal total = ObterTotalVenda();


                if (formaPagamento == 5)
                {
                    if (string.IsNullOrWhiteSpace(txtValorRecebido.Text) || !decimal.TryParse(txtValorRecebido.Text, out decimal valorRecebido))
                    {
                        MessageBox.Show("Informe um valor válido recebido em dinheiro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtValorRecebido.Focus();
                        return;
                    }

                    if (valorRecebido < total)
                    {
                        MessageBox.Show("Valor recebido é insuficiente.", "Erro no pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (!SalvarVenda()) return;


                    decimal troco = valorRecebido - total;
                    lblRetornoTroco.Text = troco.ToString("C2");
                    MessageBox.Show($"Venda concluída! Troco a retornar: {troco:C2}", "Venda Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (!SalvarVenda()) return;

                    lblRetornoTroco.Text = "R$ 0,00";
                    MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                itens.Clear();
                AtualizarGrid();
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar pagamento: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal descontoAplicado = 0;

        private void AplicarDesconto()
        {
            decimal total = itens.Sum(x => x.Total);

            try
            {

                if (string.IsNullOrWhiteSpace(txtDesconto.Text))
                {
                    MessageBox.Show("Informe o desconto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtDesconto.Text, out decimal valor))
                {
                    MessageBox.Show("Digite um valor numérico válido.");
                    txtDesconto.Focus();
                    txtDesconto.SelectAll();
                    return;
                }

                if (rdbPorcentagem.Checked)
                {
                    descontoAplicado = total * (valor / 100m);
                }

                else if (rdbValor.Checked)
                {
                    descontoAplicado = valor;
                }

                else
                {
                    MessageBox.Show("Selecione o tipo de desconto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (descontoAplicado > total)
                {
                    MessageBox.Show("O desconto não pode ser maior que o valor total da venda.", "Erro ao aplicar o desconto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar o desconto", "Erro! " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalFinal = total - descontoAplicado;
            lblRetornoTotal.Text = totalFinal.ToString("C2");

        }

        private decimal ObterTotalVenda()
        {
            decimal subtotal = itens.Sum(x => x.Total);

            return subtotal - descontoAplicado;
        }

        private void LimparTela()
        {
            txtCodigoBarras.Clear();
            txtCodigoBarras.Focus();
            txtDesconto.Clear();
            txtValorRecebido.Clear();


            lblRetornoProduto.Text = "";
            lblRetornoCategoria.Text = "";
            lblRetornoCodigo.Text = "";
            lblRetornoPrecoUnitario.Text = "";
            lblRetornoEstoque.Text = "";
            lblRetornoTroco.Text = "";
            lblRetornoTotal.Text = "0,00";
            lblSubTotalRecebido.Text = "0,00";
            lblRetornoQuantidade.Text = "0";
            lblRetornoCliente.Text = "";

            ProdutoSelecionado = null;

            descontoAplicado = 0;
            formaPagamento = null;

            rdbPorcentagem.Checked = false;
            rdbValor.Checked = false;

            btnPix.BackColor = SystemColors.Control;
            btnCartao.BackColor = SystemColors.Control;
            btnBoleto.BackColor = SystemColors.Control;
            btnDinheiro.BackColor = SystemColors.Control;
        }

        private void AtualizarSubTotal()
        {
            decimal subtotal = itens.Sum(x => x.Total);

            lblSubTotalRecebido.Text = subtotal.ToString("C2");
            lblRetornoTotal.Text = ObterTotalVenda().ToString("C2");


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
                item.IdProduto = Convert.ToInt32(ProdutoSelecionado["ID_PRODUTO"]);
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
                string sql = "SELECT p.id AS 'ID_PRODUTO', p.ean AS 'CÓDIGO', p.nome AS 'NOME', c.nome AS 'CATEGORIA', p.descricao 'DESCRIÇÃO', p.marca AS 'MARCA', p.preco AS 'PREÇO', p.estoque as 'ESTOQUE' FROM tblproduto p INNER JOIN  tblcategoria c ON p.categoria_id = c.id WHERE (p.id LIKE @filtro OR p.ean LIKE @filtro OR p.nome LIKE @filtro OR p.descricao LIKE @filtro OR p.preco LIKE @filtro OR p.estoque LIKE @filtro) AND p.status_ativo = 'A'";

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

            mskData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Interval = 1000;
            timer1.Start();





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
        private int? clienteId = null;
        private string? nomeCliente = null;
        private void btnCLientes_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes();
            if (frmConsultarClientes.ShowDialog() == DialogResult.OK)
            {
                clienteId = frmConsultarClientes.ClienteSelecionadoId;
                nomeCliente = frmConsultarClientes.ClienteSelecionadoNome;
                lblRetornoCliente.Text = nomeCliente;
                CarregarEnderecos();
            }
        }

        private int? enderecoId =null;
        private void CarregarEnderecos()
        {
            cmbEndereco.Items.Clear();

            string sql = @"SELECT id, rua, numero, bairro, cidade, estado, cep FROM tblendereco WHERE cliente_id = @cliente_id ORDER BY id DESC";

            Conexao conexao = new Conexao();

            using (SqlConnection con = conexao.Conectar())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@cliente_id", clienteId);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbEndereco.Items.Add(new
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Endereco = $"{reader["rua"]},{reader["numero"]} - {reader["bairro"]} - {reader["cidade"]}/{reader["estado"]} - CEP: {reader["cep"]}"
                        });
                    }
                }
            }
            cmbEndereco.DisplayMember = "Endereco";
            cmbEndereco.ValueMember = "id";
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

            if (dgvItemVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item.");
                return;
            }

            string codigo = dgvItemVenda.SelectedRows[0].Cells["Codigo"].Value.ToString();
            ItemVenda itemExistente = itens.FirstOrDefault(x => x.Codigo == codigo);

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

        private void SelecionarPagamento(Button botao)
        {
            btnPix.BackColor = SystemColors.Control;
            btnCartao.BackColor = SystemColors.Control;
            btnDinheiro.BackColor = SystemColors.Control;
            btnBoleto.BackColor = SystemColors.Control;

            botao.BackColor = Color.LightGreen;
            botao.Focus();
        }

        private int? formaPagamento = null;
        private void btnPix_Click(object sender, EventArgs e)
        {
            formaPagamento = 1;//☑️
            SelecionarPagamento(btnPix);
        }

        private void btnCartao_Click(object sender, EventArgs e)
        {
            ObterTotalVenda();
            frmCartao frmCartao = new frmCartao(ObterTotalVenda());

            if (frmCartao.ShowDialog() == DialogResult.OK)
            {
                PagamentoCartao pagamento = frmCartao.Pagamento;

                formaPagamento = 2;

                SelecionarPagamento(btnCartao);
            }
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            formaPagamento = 4;
            SelecionarPagamento(btnBoleto);
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            formaPagamento = 5; //☑️
            SelecionarPagamento(btnDinheiro);

        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {

            ConcluirVenda();
        }

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            AplicarDesconto();
        }

        private void mskData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mskData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {

        }

        private void cmbEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
