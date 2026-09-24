using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Ecommerce
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void GerarRelatorioPeriodo()
        {
            Conexao conexao = new Conexao();
            string sql = @"SELECT
                                p.id AS 'Pedido',
                                c.nome AS 'Cliente',
                                p.data_pedido AS 'Data',
                                p.subtotal AS 'Subtotal',
                                p.desconto AS 'Desconto',
                                p.total AS 'Total',
                                fp.descricao AS 'Pagamento'
                            FROM tblpedido p
                            INNER JOIN tblcliente c ON p.cliente_id = c.id
                            LEFT JOIN tblformapagamento fp ON p.forma_pagamento_id = fp.id
                            WHERE p.data_pedido BETWEEN @dataInicio AND @dataFim
                            ORDER BY p.data_pedido DESC";

            try
            {
                using (SqlConnection con = conexao.Conectar())
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@dataInicio", dtpInicio.Value.Date);
                    cmd.Parameters.AddWithValue("@dataFim", dtpFim.Value.Date.AddDays(1).AddSeconds(-1));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRelatorioVendas.DataSource = dt;

                    decimal totalVendas = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        totalVendas += Convert.ToDecimal(row["Total"]);
                    }

                    lblTotalVendas.Text = "Total: " + totalVendas.ToString("C2");
                    lblQuantidadePedidos.Text = "Pedido: " + dt.Rows.Count;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório" + ex.Message, ("Erro"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarRelatorioProdutosMaisVendidos()
        {
            Conexao conexao = new Conexao();
            string sql = @"SELECT
                            p.nome AS 'Produto',
                            p.ean AS 'Código',
                            SUM(ip.quantidade) AS 'Qtd Vendida',
                            SUM(ip.quantidade * ip.preco) AS 'Receita Total'
                           FROM tblitempedido ip
                           INNER JOIN tblproduto p ON ip.produto_id = p.id
                           INNER JOIN tblpedido ped ON ip.pedido_id = ped.id
                           WHERE ped.data_pedido BETWEEN @dataInicio AND @dataFim
                           GROUP BY p.nome, p.ean
                           ORDER BY SUM (ip.quantidade) DESC";

            try
            {
                using(SqlConnection con = conexao.Conectar())
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@dataInicio", dtpInicio.Value.Date);
                    cmd.Parameters.AddWithValue("@dataFim", dtpFim.Value.Date.AddDays(1).AddSeconds(-1));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRelatorioVendas.DataSource = dt;

                    int totalUnidades = dt.AsEnumerable().Sum(r => Convert.ToInt32(r["Qtd Vendida"]));
                    lblTotalVendas.Text = "Total de Unidades: " + totalUnidades;
                    lblQuantidadePedidos.Text = "Produtos diferentes: " + dt.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                
        }

        private void GerarRelatorioFormaPagamento()
        {
            Conexao conexao = new Conexao();
            string sql = @"SELECT 
                            fp.descricao AS 'Forma de Pagamento', 
                            COUNT(p.id) AS 'Qtd Pedidos', 
                            SUM(p.total) AS 'Total recebido'
                           FROM tblpedido p
                           LEFT JOIN tblformapagamento fp ON p.forma_pagamento_id = fp.id
                           WHERE p.data_pedido BETWEEN @dataInicio AND @dataFim
                           GROUP BY fp.descricao
                           ORDER By SUM(p.total) DESC";

            try
            {
                using(SqlConnection con = conexao.Conectar())
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@dataInicio", dtpInicio.Value.Date);
                    cmd.Parameters.AddWithValue("@dataFim", dtpFim.Value.Date.AddDays(1).AddSeconds(-1));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRelatorioVendas.DataSource = dt;

                    decimal totalGeral = dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["Total Recebido"]));
                    lblTotalVendas.Text = "Total Geral: " + totalGeral.ToString("C2");
                    lblQuantidadePedidos.Text = "Formas de pagamento: " + dt.Rows.Count; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao gerar relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarRelatorioEstoqueBaixo()
        {
            Conexao conexao = new Conexao();
            string sql = @"SELECT 
                        nome AS 'Produto',
                        ean AS 'Código',
                        estoque AS 'Estoque Atual'
                    FROM tblproduto
                    WHERE estoque <= 10 AND status_ativo = 'A'
                    ORDER BY estoque ASC";

            try
            {
                using (SqlConnection con = conexao.Conectar())
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvRelatorioVendas.DataSource = dt;

                    lblTotalVendas.Text = "Produtos críticos: " + dt.Rows.Count;
                    lblQuantidadePedidos.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            switch (cmbTipoRelatorio.SelectedItem?.ToString())
            {
                case "Vendas por Período":
                    GerarRelatorioPeriodo();
                    break;

                case "Produtos Mais Vendidos":
                    GerarRelatorioProdutosMaisVendidos();
                    break;

                case "Vendas por Forma de Pagamento":
                    GerarRelatorioFormaPagamento();
                    break;

                case "Estoque Baixo":
                    GerarRelatorioEstoqueBaixo();
                    break;
            }
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            cmbTipoRelatorio.Items.Add("Vendas por Período");
            cmbTipoRelatorio.Items.Add("Produtos Mais Vendidos");
            cmbTipoRelatorio.Items.Add("Vendas por Forma de Pagamento");
            cmbTipoRelatorio.Items.Add("Estoque Baixo");

            cmbTipoRelatorio.SelectedIndex = 0;
        }

        private void cmbTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool precisaDeData = cmbTipoRelatorio.SelectedItem?.ToString() != "Estoque Baixo";

            dtpInicio.Visible = precisaDeData;
            dtpFim.Visible = precisaDeData;
            lblDataInicial.Visible = precisaDeData;
            lblDataFinal.Visible = precisaDeData;
        }
    }
}
