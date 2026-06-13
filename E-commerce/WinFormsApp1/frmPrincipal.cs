using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProduto frmCadProduto = new frmCadProduto();
            frmCadProduto.ShowDialog();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente frmCadCliente = new frmCadCliente();
            frmCadCliente.ShowDialog();
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor frmCadFornecedor = new frmCadFornecedor();
            frmCadFornecedor.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCategoria frmCadCategoria = new frmCadCategoria();
            frmCadCategoria.ShowDialog();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelVendas frmPainelVendas = new frmPainelVendas();
            frmPainelVendas.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCategorias frmConsultarCategorias = new frmConsultarCategorias();
            frmConsultarCategorias.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes();
            frmConsultarClientes.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedores frmConsultarFornecedores = new frmConsultarFornecedores();
            frmConsultarFornecedores.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos frmConsultarProdutos = new frmConsultarProdutos();
            frmConsultarProdutos.ShowDialog();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarCategoriaInativa frmConsultarCategoriaInativa = new frmConsultarCategoriaInativa();
            frmConsultarCategoriaInativa.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarClienteInativo frmConsultarClienteInativo = new frmConsultarClienteInativo();
            frmConsultarClienteInativo.ShowDialog();
        }
    }
}
