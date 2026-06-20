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
    public partial class frmConsultarCategoriaInativa : Form
    {
        public frmConsultarCategoriaInativa()
        {
            InitializeComponent();
        }

        public DataTable CarregarCategoriaInativa()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT id, nome AS 'CATEGORIA', descricao AS 'DESCRIÇÃO' FROM tblcategoria WHERE (nome LIKE @filtro OR descricao LIKE @filtro) AND status_ativo = 'I'";

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

        private void frmConsultarCategoriaInativa_Load(object sender, EventArgs e)
        {
            CarregarCategoriaInativa();
        }

        private void reativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvConsultarCategorias.CurrentRow.Cells["id"].Value);
                Conexao conexao = new Conexao();
                string sql = "UPDATE tblcategoria SET status_ativo = 'A' WHERE id = @id";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Categoria restaurada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarCategoriaInativa();
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
