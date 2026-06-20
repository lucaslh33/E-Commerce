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
    public partial class frmConsultarFornecedoresInativos : Form
    {
        public frmConsultarFornecedoresInativos()
        {
            InitializeComponent();
        }

        public DataTable CarregarFornecedor()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = ("SELECT id AS CÓDIGO, nome AS NOME, cnpj AS CNPJ FROM tblfornecedor WHERE (nome LIKE @filtro OR nomefantasia LIKE @filtro) AND status_ativo ='I'");

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtPesquisa.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarFornecedores.DataSource = dt;
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

        private void frmConsultarFornecedoresInativos_Load(object sender, EventArgs e)
        {
            CarregarFornecedor();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dgvConsultarFornecedores.CurrentRow.Cells["CÓDIGO"].Value);

                DialogResult result = MessageBox.Show($"Tem certeza que deseja restaurar o fornecedor: {dgvConsultarFornecedores.CurrentRow.Cells["NOME"].Value}", "Confirmação de restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();
                    string sql = "UPDATE tblfornecedor SET status_ativo = 'A' WHERE id = @id";

                    using (SqlConnection con = conexao.Conectar())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            CarregarFornecedor();
                        }
                    }
                    MessageBox.Show("Fornecedor restaurado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar fornecedor " + ex.Message);
            }
        }
    }
}
