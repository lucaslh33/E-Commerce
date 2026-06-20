using System.Data;
using Microsoft.Data.SqlClient;

namespace Ecommerce
{
    public partial class frmConsultarProdutoInativo : Form
    {
        public frmConsultarProdutoInativo()
        {
            InitializeComponent();
        }

        public DataTable CarregarProduto()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT id AS 'CÓDIGO', nome AS 'NOME', descricao AS 'DESCRIÇÂO', marca AS 'MARCA' FROM tblproduto WHERE (id LIKE @filtro OR nome LIKE @filtro OR descricao LIKE @filtro) AND status_ativo = 'I'";

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

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dgvConsultarProduto.CurrentRow.Cells["CÓDIGO"].Value);

                DialogResult result = MessageBox.Show($"Tem certeza que deseja restaurar o produto: {dgvConsultarProduto.CurrentRow.Cells["NOME"].Value}", "Confirmação de restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();
                    string sql = "UPDATE tblproduto SET status_ativo = 'A' WHERE id = @id";

                    using (SqlConnection con = conexao.Conectar())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            CarregarProduto();
                        }
                    }
                    MessageBox.Show("Produto restaurado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar produto " + ex.Message);
            }
        }

        private void dgvConsultarProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultarProdutoInativo_Load(object sender, EventArgs e)
        {
            CarregarProduto();
        }
    }
}
