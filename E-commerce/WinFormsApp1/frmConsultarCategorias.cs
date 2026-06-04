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
    public partial class frmConsultarCategorias : Form
    {
        public frmConsultarCategorias()
        {
            InitializeComponent();
        }

        public DataTable CarregarCategoria()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT nome AS 'CATEGORIA', descricao AS 'DESCRIÇÃO' FROM tblcategoria WHERE nome LIKE @filtro OR id LIKE @filtro OR descricao LIKE @filtro";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtPesquisa.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarCategorias.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar categoria! ", "ERRO!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void frmConsultarCategorias_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarCategoria();
        }
    }
}
