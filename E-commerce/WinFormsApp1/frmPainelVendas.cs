using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class frmPainelVendas : Form
    {
        public frmPainelVendas()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovaVenda_Enter(object sender, EventArgs e)
        {
            btnNovaVenda.BackColor = Color.FromArgb(245, 158, 11);
        }

        private void btnNovaVenda_Leave(object sender, EventArgs e)
        {
            btnNovaVenda.BackColor = Color.FromArgb(30, 41, 59);
        }
    }
}
