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
    public partial class frmCadCategoria : Form
    {
        public frmCadCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            string sql = "INSERT INTO tblcategoria VALUES (@nome, @descricao)";

            using (SqlConnection con = conexao.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoria cadastrada com sucesso!");
                        txtNome.Clear();
                        txtDescricao.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar categoria: " + ex.Message);
                    }
                }
            }
        }
    }
}
