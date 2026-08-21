using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class frmCartao : Form
    {
        public PagamentoCartao Pagamento { get; private set; }
        
        public frmCartao(decimal valorCompra)
        {
            InitializeComponent();

            lblRetornoValorCompra.Text = valorCompra.ToString("C2");
        }
            

        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!mskNumero.MaskCompleted)
            {
                MessageBox.Show("Informe o número do cartão.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o Nome do títular do cartão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mskCVV.MaskCompleted)
            {
                MessageBox.Show("Informe o CVV.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!mskValidade.MaskCompleted)
            {
                MessageBox.Show("Informe a Validade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdbCredito.Checked && !rdbDebito.Checked)
            {
                MessageBox.Show("Selecione Crédito ou Débito.");
                return;
            }

            

            Pagamento = new PagamentoCartao
            {
                NumeroCartao = mskNumero.Text,
                NomeTitular = txtNome.Text,
                Validade = mskValidade.Text,
                Cvv = mskCVV.Text,
                Tipo = rdbCredito.Checked ? TipoCartao.Credito : TipoCartao.Debito
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
