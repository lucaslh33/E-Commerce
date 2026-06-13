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
    public partial class frmConsultarProdutos : Form
    {
        public frmConsultarProdutos()
        {
            InitializeComponent();
        }

        public DataTable CarregarProduto()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT id AS 'CÓDIGO', nome AS 'NOME', descricao AS 'DESCRIÇÂO', marca AS 'MARCA' FROM tblproduto WHERE id LIKE @filtro OR nome LIKE @filtro OR descricao LIKE @filtro";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtPesquisa.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarProduto.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar produto! ", "ERRO!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void frmConsultarProdutos_Load(object sender, EventArgs e)
        {
            CarregarProduto();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarProduto();
        }
    }
}
