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
    public partial class frmConsultarClienteInativo : Form
    {
        public frmConsultarClienteInativo()
        {
            InitializeComponent();
        }

        public DataTable CarregarClienteInativo()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = ("SELECT tblcliente.id AS CÓDIGO, nome AS NOME, rua AS RUA, email AS EMAIL FROM tblcliente INNER JOIN tblendereco ON tblcliente.id = tblendereco.cliente_id WHERE (nome LIKE @filtro OR rua LIKE @filtro OR email LIKE @filtro) AND status_ativo = 'I' ");

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtPesquisa.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarClientes.DataSource = dt;
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

        private void frmConsultarClienteInativo_Load(object sender, EventArgs e)
        {
            CarregarClienteInativo();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string idCLiente = Convert.ToString(dgvConsultarClientes.CurrentRow.Cells["CÓDIGO"].Value);

                DialogResult result = MessageBox.Show($"Tem certeza que deseja restaurar o cliente: {dgvConsultarClientes.CurrentRow.Cells["NOME"].Value}", "Confirmação de restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Conexao conexao = new Conexao();
                    string sql = "UPDATE tblcliente SET status_ativo = 'A' WHERE id = @id";

                    using (SqlConnection con = conexao.Conectar())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@id", idCLiente);
                            cmd.ExecuteNonQuery();
                            CarregarClienteInativo();
                        }
                    }
                    MessageBox.Show("Cliente restaurado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar cliente " + ex.Message);
            }
        }
    }
}
