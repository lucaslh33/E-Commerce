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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
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
    }
}
