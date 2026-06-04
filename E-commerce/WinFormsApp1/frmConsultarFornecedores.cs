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
    public partial class frmConsultarFornecedores : Form
    {
        public frmConsultarFornecedores()
        {
            InitializeComponent();
        }

        public DataTable CarregarFornecedor()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = ("SELECT id AS CÓDIGO, nome AS NOME, cnpj AS CNPJ FROM tblfornecedor WHERE nome LIKE @filtro OR nomefantasia LIKE @filtro");

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtPesquisa.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultaFornecedores.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar fornecedor! ", "ERRO!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarFornecedor();
        }

        private void frmConsultarFornecedores_Load(object sender, EventArgs e)
        {
            CarregarFornecedor();
        }
    }
}
