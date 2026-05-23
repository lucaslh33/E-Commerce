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
    }
}
