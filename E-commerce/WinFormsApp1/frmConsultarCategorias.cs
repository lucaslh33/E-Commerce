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
                string sql = "SELECT id, nome AS 'CATEGORIA', descricao AS 'DESCRIÇÃO' FROM tblcategoria WHERE (nome LIKE @filtro OR descricao LIKE @filtro) AND status_ativo = 'A'";

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

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvConsultarCategorias.CurrentRow.Cells["id"].Value);
                Conexao conexao = new Conexao();
                string sql = "UPDATE tblcategoria SET status_ativo = 'I' WHERE id = @id";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("id",id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Categoria deletada!");
                        CarregarCategoria();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
