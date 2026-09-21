using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
                string sql = "SELECT id AS 'ID', ean AS 'CÓDIGO', nome AS 'NOME', descricao AS 'DESCRIÇÂO', marca AS 'MARCA', estoque AS 'ESTOQUE', imagem1 AS 'IMAGEM1' FROM tblproduto WHERE (ean LIKE @filtro OR nome LIKE @filtro OR descricao LIKE @filtro or estoque LIKE @filtro) AND status_ativo = 'A'";

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

            if (dgvConsultarProduto.Columns.Contains("ID"))
                dgvConsultarProduto.Columns["ID"].Visible = false;

            if (dgvConsultarProduto.Columns.Contains("IMAGEM1"))
                dgvConsultarProduto.Columns["IMAGEM1"].Visible = false;

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarProduto();

        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dgvConsultarProduto.CurrentRow.Cells["ID"].Value);

                DialogResult result = MessageBox.Show($"Tem certeza que deseja remover o produto: {dgvConsultarProduto.CurrentRow.Cells["NOME"].Value}", "Confirmação de remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();
                    string sql = "UPDATE tblproduto SET status_ativo = 'I' WHERE id = @id";

                    using (SqlConnection con = conexao.Conectar())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            CarregarProduto();
                        }
                    }
                    MessageBox.Show("Produto removido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover produto " + ex.Message);
            }
        }

        private void dgvConsultarProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultarProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsultarProduto.CurrentRow == null) return;

            object valorImagem = dgvConsultarProduto.CurrentRow.Cells["IMAGEM1"].Value;

            if (valorImagem == null || valorImagem == DBNull.Value)
            {
                picProduto.Image = null;
                return;
            }

            string nomeArquivo = valorImagem.ToString();
            string caminhoCompleto = Path.Combine(Application.StartupPath, "Imagens", "Produtos", nomeArquivo);

            if (File.Exists(caminhoCompleto))
                picProduto.Image = Image.FromFile(caminhoCompleto);
            else
                picProduto.Image = null;
        }
    }
}
