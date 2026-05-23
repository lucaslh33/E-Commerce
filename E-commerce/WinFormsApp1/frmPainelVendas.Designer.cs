namespace Ecommerce
{
    partial class frmPainelVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            txtNovaVenda = new Label();
            panel1 = new Panel();
            panel8 = new Panel();
            label5 = new Label();
            lblEstoque = new Label();
            label4 = new Label();
            lblPrecoUnitario = new Label();
            label3 = new Label();
            label2 = new Label();
            lblCategoria = new Label();
            lblCodigo = new Label();
            label1 = new Label();
            lblProduto = new Label();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            panel6 = new Panel();
            btnCancelarItem = new Button();
            dataGridView1 = new DataGridView();
            lbItensVenda = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            lblAdicionarProdutoVenda = new Label();
            panel2 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            lblPdv = new Label();
            lblCarrinho = new Label();
            panel11 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnNovaVenda = new Button();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 50, 75);
            panel4.Controls.Add(txtNovaVenda);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(202, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(848, 54);
            panel4.TabIndex = 3;
            // 
            // txtNovaVenda
            // 
            txtNovaVenda.AutoSize = true;
            txtNovaVenda.BackColor = Color.Transparent;
            txtNovaVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNovaVenda.ForeColor = Color.White;
            txtNovaVenda.Location = new Point(13, 10);
            txtNovaVenda.Name = "txtNovaVenda";
            txtNovaVenda.Size = new Size(151, 32);
            txtNovaVenda.TabIndex = 0;
            txtNovaVenda.Text = "Nova Venda";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 231, 235);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(209, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 599);
            panel1.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label5);
            panel8.Controls.Add(lblEstoque);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(lblPrecoUnitario);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(lblCategoria);
            panel8.Controls.Add(lblCodigo);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(lblProduto);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(6, 70);
            panel8.Name = "panel8";
            panel8.Size = new Size(593, 121);
            panel8.TabIndex = 3;
            panel8.Paint += panel8_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(421, 89);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 12;
            label5.Text = "Código:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(420, 62);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(49, 15);
            lblEstoque.TabIndex = 11;
            lblEstoque.Text = "Estoque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(420, 33);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 10;
            label4.Text = "label";
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecoUnitario.Location = new Point(420, 9);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(81, 15);
            lblPrecoUnitario.TabIndex = 9;
            lblPrecoUnitario.Text = "Preço unitário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 89);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 62);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(157, 89);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(60, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categória:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(156, 62);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(48, 15);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "label";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(156, 9);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Produto";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(605, 197);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 289);
            panel7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(btnCancelarItem);
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(lbItensVenda);
            panel6.Location = new Point(7, 197);
            panel6.Name = "panel6";
            panel6.Size = new Size(593, 289);
            panel6.TabIndex = 2;
            // 
            // btnCancelarItem
            // 
            btnCancelarItem.BackColor = Color.Transparent;
            btnCancelarItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarItem.ForeColor = Color.Red;
            btnCancelarItem.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarItem.Location = new Point(12, 255);
            btnCancelarItem.Name = "btnCancelarItem";
            btnCancelarItem.Size = new Size(153, 23);
            btnCancelarItem.TabIndex = 2;
            btnCancelarItem.Text = "Cancelar item selecionado";
            btnCancelarItem.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(571, 219);
            dataGridView1.TabIndex = 1;
            // 
            // lbItensVenda
            // 
            lbItensVenda.AutoSize = true;
            lbItensVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbItensVenda.Location = new Point(12, 10);
            lbItensVenda.Name = "lbItensVenda";
            lbItensVenda.Size = new Size(98, 17);
            lbItensVenda.TabIndex = 0;
            lbItensVenda.Text = "Itens da venda";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(6, 492);
            panel5.Name = "panel5";
            panel5.Size = new Size(832, 93);
            panel5.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(lblAdicionarProdutoVenda);
            panel3.Location = new Point(6, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(593, 70);
            panel3.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 128, 0);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Snow;
            btnBuscar.Location = new Point(486, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar ";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 29);
            textBox1.TabIndex = 1;
            textBox1.Text = "Digite o código de barras ou nome do produto";
            // 
            // lblAdicionarProdutoVenda
            // 
            lblAdicionarProdutoVenda.AutoSize = true;
            lblAdicionarProdutoVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdicionarProdutoVenda.Location = new Point(12, 7);
            lblAdicionarProdutoVenda.Name = "lblAdicionarProdutoVenda";
            lblAdicionarProdutoVenda.Size = new Size(177, 17);
            lblAdicionarProdutoVenda.TabIndex = 0;
            lblAdicionarProdutoVenda.Text = "Adicionar produto à  venda";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(605, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 188);
            panel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(30, 41, 59);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(lblPdv);
            panel9.Controls.Add(lblCarrinho);
            panel9.ForeColor = Color.White;
            panel9.Location = new Point(0, 12);
            panel9.Name = "panel9";
            panel9.Size = new Size(209, 54);
            panel9.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.Location = new Point(3, 51);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 603);
            panel10.TabIndex = 7;
            // 
            // lblPdv
            // 
            lblPdv.AutoSize = true;
            lblPdv.BackColor = Color.Transparent;
            lblPdv.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPdv.ForeColor = Color.FromArgb(255, 128, 0);
            lblPdv.Location = new Point(48, 16);
            lblPdv.Name = "lblPdv";
            lblPdv.Size = new Size(162, 25);
            lblPdv.TabIndex = 1;
            lblPdv.Text = "Painel de Vendas";
            // 
            // lblCarrinho
            // 
            lblCarrinho.AutoSize = true;
            lblCarrinho.BackColor = Color.Transparent;
            lblCarrinho.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrinho.ForeColor = Color.FromArgb(255, 128, 0);
            lblCarrinho.Location = new Point(12, 10);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(48, 32);
            lblCarrinho.TabIndex = 0;
            lblCarrinho.Text = "\U0001f6d2";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(37, 50, 75);
            panel11.Controls.Add(button8);
            panel11.Controls.Add(button7);
            panel11.Controls.Add(button6);
            panel11.Controls.Add(button5);
            panel11.Controls.Add(button4);
            panel11.Controls.Add(button3);
            panel11.Controls.Add(button2);
            panel11.Controls.Add(btnNovaVenda);
            panel11.Location = new Point(0, 66);
            panel11.Name = "panel11";
            panel11.Size = new Size(210, 600);
            panel11.TabIndex = 7;
            // 
            // button8
            // 
            button8.Location = new Point(12, 537);
            button8.Name = "button8";
            button8.Size = new Size(162, 49);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 341);
            button7.Name = "button7";
            button7.Size = new Size(162, 49);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 286);
            button6.Name = "button6";
            button6.Size = new Size(162, 49);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 231);
            button5.Name = "button5";
            button5.Size = new Size(162, 49);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 176);
            button4.Name = "button4";
            button4.Size = new Size(162, 49);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 121);
            button3.Name = "button3";
            button3.Size = new Size(162, 49);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 66);
            button2.Name = "button2";
            button2.Size = new Size(162, 49);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovaVenda.ForeColor = Color.Black;
            btnNovaVenda.Location = new Point(12, 11);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(162, 49);
            btnNovaVenda.TabIndex = 0;
            btnNovaVenda.Text = "\U0001f6d2 Nova Venda";
            btnNovaVenda.UseVisualStyleBackColor = true;
            btnNovaVenda.Paint += panel8_Paint;
            btnNovaVenda.Enter += btnNovaVenda_Enter;
            btnNovaVenda.Leave += btnNovaVenda_Leave;
            // 
            // frmPainelVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 725);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Name = "frmPainelVendas";
            Text = "Painel de Vendas - Ecommerce";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel1;
        private Label txtNovaVenda;
        private Panel panel2;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel3;
        private TextBox textBox1;
        private Label lblAdicionarProdutoVenda;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Button btnBuscar;
        private Label lblCodigo;
        private Label label1;
        private Label lblProduto;
        private Label lblEstoque;
        private Label label4;
        private Label lblPrecoUnitario;
        private Label label3;
        private Label label2;
        private Label lblCategoria;
        private Label label5;
        private Label lbItensVenda;
        private Button btnCancelarItem;
        private DataGridView dataGridView1;
        private Panel panel9;
        private Label lblCarrinho;
        private Label lblPdv;
        private Panel panel10;
        private Panel panel11;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnNovaVenda;
    }
}