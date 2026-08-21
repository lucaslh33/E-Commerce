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
    public partial class frmConsultarClientes : Form
    {
        public frmConsultarClientes()
        {
            InitializeComponent();
        }



        public DataTable CarregarCliente()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = ("SELECT tblcliente.id AS CÓDIGO, nome AS NOME, rua AS RUA, email AS EMAIL FROM tblcliente INNER JOIN tblendereco ON tblcliente.id = tblendereco.cliente_id WHERE (tblcliente.id LIKE @filtro OR nome LIKE @filtro OR rua LIKE @filtro OR email LIKE @filtro) AND status_ativo = 'A' ");

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtPesquisa.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultaCliente.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar cliente! ", "ERRO!" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void menuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string idCliente = Convert.ToString(dgvConsultaCliente.CurrentRow.Cells["CÓDIGO"].Value);

                DialogResult result = MessageBox.Show($"Tem certeza que deseja remover o cliente: {dgvConsultaCliente.CurrentRow.Cells["NOME"].Value}", "Confirmação de remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();
                    string sql = "UPDATE tblcliente SET status_ativo = 'I' WHERE id = @id";

                    using (SqlConnection con = conexao.Conectar())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", idCliente);
                            cmd.ExecuteNonQuery();
                            CarregarCliente();
                        }
                    }
                    MessageBox.Show("Cliente removido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover cliente " + ex.Message);
            }
        }

        private void dgvConsultaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int? ClienteSelecionadoId { get; private set; }
        public string? ClienteSelecionadoNome { get; private set; }
        private void dgvConsultaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            ClienteSelecionadoId = Convert.ToInt32(
                dgvConsultaCliente.Rows[e.RowIndex].Cells["CÓDIGO"].Value);
            ClienteSelecionadoNome = Convert.ToString(dgvConsultaCliente.Rows[e.RowIndex].Cells["NOME"].Value);




            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
