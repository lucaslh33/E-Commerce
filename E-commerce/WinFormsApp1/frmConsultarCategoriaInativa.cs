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
                string idCategoria = Convert.ToString(dgvConsultarCategorias.CurrentRow.Cells["CATEGORIA"].Value);

                DialogResult result = MessageBox.Show($"Tem certeza que deseja restaurar a categoria: {dgvConsultarCategorias.CurrentRow.Cells["CATEGORIA"].Value}", "Confirmação de restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();
                    string sql = "UPDATE tblcliente SET status_categoria = 'A' WHERE id_categoria = @id";

                    using (SqlConnection con = conexao.Conectar())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", idCategoria);
                            cmd.ExecuteNonQuery();
                            CarregarCategoriaInativa();
                        }
                    }
                    MessageBox.Show("Categoria restaurada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar categoria " + ex.Message);
            }
        }
    }
}
