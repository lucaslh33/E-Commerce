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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelVendas));
            panel4 = new Panel();
            mskData = new MaskedTextBox();
            lblNomeOperador = new Label();
            lblReceberCaixa = new Label();
            lblOperador = new Label();
            lblCaixa = new Label();
            pcbUsuario = new PictureBox();
            txtNovaVenda = new Label();
            panel1 = new Panel();
            panel8 = new Panel();
            lblRetornoEstoque = new Label();
            lblRetornoCodigo = new Label();
            label5 = new Label();
            lblEstoque = new Label();
            lblRetornoPrecoUnitario = new Label();
            lblPrecoUnitario = new Label();
            lblRetornoCategoria = new Label();
            lblCategoria = new Label();
            lblRetornoProduto = new Label();
            lblProduto = new Label();
            pcbProduto = new PictureBox();
            panel7 = new Panel();
            lblRetornoTroco = new Label();
            txtValorRecebido = new TextBox();
            lblTroco = new Label();
            lblValorRecebido = new Label();
            btnBoleto = new Button();
            btnPix = new Button();
            btnCartao = new Button();
            btnDinheiro = new Button();
            lblFormaPagamento = new Label();
            panel6 = new Panel();
            lblRetornoQuantidade = new Label();
            lblQtdeItens = new Label();
            btnCancelarItem = new Button();
            dgvItemVenda = new DataGridView();
            lbItensVenda = new Label();
            panel5 = new Panel();
            btnFinalizarVenda = new Button();
            btnConsultarPreco = new Button();
            btnLimparVenda = new Button();
            btnAdicionarNovaVenda = new Button();
            panel3 = new Panel();
            btnAdicionarItem = new Button();
            txtCodigoBarras = new TextBox();
            lblAdicionarProdutoVenda = new Label();
            panel2 = new Panel();
            lblRetornoCliente = new Label();
            lblCliente = new Label();
            btnAplicarDesconto = new Button();
            rdbPorcentagem = new RadioButton();
            rdbValor = new RadioButton();
            txtDesconto = new TextBox();
            lblSubTotalRecebido = new Label();
            lblDesconto = new Label();
            lblRetornoTotal = new Label();
            lblTotal = new Label();
            lblSubTotal = new Label();
            lblResumoVenda = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            lblPdv = new Label();
            lblCarrinho = new Label();
            panel11 = new Panel();
            btnNovaVenda = new Button();
            btnSair = new Button();
            btnConfiguracoes = new Button();
            btnRelatorio = new Button();
            btnCaixa = new Button();
            btnProdutos = new Button();
            btnCLientes = new Button();
            btnConsultarVendas = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).BeginInit();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbProduto).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemVenda).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 50, 75);
            panel4.Controls.Add(mskData);
            panel4.Controls.Add(lblNomeOperador);
            panel4.Controls.Add(lblReceberCaixa);
            panel4.Controls.Add(lblOperador);
            panel4.Controls.Add(lblCaixa);
            panel4.Controls.Add(pcbUsuario);
            panel4.Controls.Add(txtNovaVenda);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(202, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(848, 54);
            panel4.TabIndex = 3;
            // 
            // mskData
            // 
            mskData.BackColor = Color.FromArgb(37, 50, 75);
            mskData.ForeColor = Color.White;
            mskData.Location = new Point(725, 16);
            mskData.Mask = "00/00/0000 90:00:00";
            mskData.Name = "mskData";
            mskData.Size = new Size(114, 23);
            mskData.TabIndex = 5;
            mskData.ValidatingType = typeof(DateTime);
            mskData.MaskInputRejected += mskData_MaskInputRejected;
            // 
            // lblNomeOperador
            // 
            lblNomeOperador.AutoSize = true;
            lblNomeOperador.Location = new Point(596, 27);
            lblNomeOperador.Name = "lblNomeOperador";
            lblNomeOperador.Size = new Size(0, 15);
            lblNomeOperador.TabIndex = 5;
            // 
            // lblReceberCaixa
            // 
            lblReceberCaixa.AutoSize = true;
            lblReceberCaixa.Location = new Point(576, 9);
            lblReceberCaixa.Name = "lblReceberCaixa";
            lblReceberCaixa.Size = new Size(0, 15);
            lblReceberCaixa.TabIndex = 4;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Location = new Point(536, 26);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(60, 15);
            lblOperador.TabIndex = 3;
            lblOperador.Text = "Operador:";
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.Location = new Point(536, 7);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(38, 15);
            lblCaixa.TabIndex = 2;
            lblCaixa.Text = "Caixa:";
            // 
            // pcbUsuario
            // 
            pcbUsuario.Image = (Image)resources.GetObject("pcbUsuario.Image");
            pcbUsuario.Location = new Point(678, 7);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(40, 44);
            pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuario.TabIndex = 1;
            pcbUsuario.TabStop = false;
            // 
            // txtNovaVenda
            // 
            txtNovaVenda.AutoSize = true;
            txtNovaVenda.BackColor = Color.Transparent;
            txtNovaVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNovaVenda.ForeColor = Color.White;
            txtNovaVenda.Location = new Point(51, 9);
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
            panel1.Size = new Size(841, 562);
            panel1.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblRetornoEstoque);
            panel8.Controls.Add(lblRetornoCodigo);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(lblEstoque);
            panel8.Controls.Add(lblRetornoPrecoUnitario);
            panel8.Controls.Add(lblPrecoUnitario);
            panel8.Controls.Add(lblRetornoCategoria);
            panel8.Controls.Add(lblCategoria);
            panel8.Controls.Add(lblRetornoProduto);
            panel8.Controls.Add(lblProduto);
            panel8.Controls.Add(pcbProduto);
            panel8.Location = new Point(6, 70);
            panel8.Name = "panel8";
            panel8.Size = new Size(593, 131);
            panel8.TabIndex = 3;
            // 
            // lblRetornoEstoque
            // 
            lblRetornoEstoque.AutoSize = true;
            lblRetornoEstoque.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRetornoEstoque.Location = new Point(472, 90);
            lblRetornoEstoque.Name = "lblRetornoEstoque";
            lblRetornoEstoque.Size = new Size(0, 15);
            lblRetornoEstoque.TabIndex = 14;
            // 
            // lblRetornoCodigo
            // 
            lblRetornoCodigo.AutoSize = true;
            lblRetornoCodigo.Location = new Point(210, 62);
            lblRetornoCodigo.Name = "lblRetornoCodigo";
            lblRetornoCodigo.Size = new Size(0, 15);
            lblRetornoCodigo.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(158, 62);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 12;
            label5.Text = "Código:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(420, 90);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(52, 15);
            lblEstoque.TabIndex = 11;
            lblEstoque.Text = "Estoque:";
            // 
            // lblRetornoPrecoUnitario
            // 
            lblRetornoPrecoUnitario.AutoSize = true;
            lblRetornoPrecoUnitario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetornoPrecoUnitario.ForeColor = Color.FromArgb(255, 128, 0);
            lblRetornoPrecoUnitario.Location = new Point(420, 33);
            lblRetornoPrecoUnitario.Name = "lblRetornoPrecoUnitario";
            lblRetornoPrecoUnitario.Size = new Size(0, 20);
            lblRetornoPrecoUnitario.TabIndex = 10;
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecoUnitario.Location = new Point(420, 9);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(84, 15);
            lblPrecoUnitario.TabIndex = 9;
            lblPrecoUnitario.Text = "Preço unitário:";
            // 
            // lblRetornoCategoria
            // 
            lblRetornoCategoria.AutoSize = true;
            lblRetornoCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetornoCategoria.Location = new Point(223, 89);
            lblRetornoCategoria.Name = "lblRetornoCategoria";
            lblRetornoCategoria.Size = new Size(0, 15);
            lblRetornoCategoria.TabIndex = 8;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(158, 90);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(60, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categória:";
            // 
            // lblRetornoProduto
            // 
            lblRetornoProduto.AutoSize = true;
            lblRetornoProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetornoProduto.Location = new Point(156, 33);
            lblRetornoProduto.Name = "lblRetornoProduto";
            lblRetornoProduto.Size = new Size(0, 20);
            lblRetornoProduto.TabIndex = 4;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(158, 9);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(53, 15);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Produto:";
            // 
            // pcbProduto
            // 
            pcbProduto.Location = new Point(12, 9);
            pcbProduto.Name = "pcbProduto";
            pcbProduto.Size = new Size(128, 104);
            pcbProduto.TabIndex = 0;
            pcbProduto.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lblRetornoTroco);
            panel7.Controls.Add(txtValorRecebido);
            panel7.Controls.Add(lblTroco);
            panel7.Controls.Add(lblValorRecebido);
            panel7.Controls.Add(btnBoleto);
            panel7.Controls.Add(btnPix);
            panel7.Controls.Add(btnCartao);
            panel7.Controls.Add(btnDinheiro);
            panel7.Controls.Add(lblFormaPagamento);
            panel7.Location = new Point(605, 207);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 279);
            panel7.TabIndex = 1;
            // 
            // lblRetornoTroco
            // 
            lblRetornoTroco.AutoSize = true;
            lblRetornoTroco.ForeColor = Color.FromArgb(0, 192, 0);
            lblRetornoTroco.Location = new Point(172, 199);
            lblRetornoTroco.Name = "lblRetornoTroco";
            lblRetornoTroco.Size = new Size(0, 15);
            lblRetornoTroco.TabIndex = 20;
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Location = new Point(142, 159);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.Size = new Size(68, 23);
            txtValorRecebido.TabIndex = 19;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Location = new Point(9, 199);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(40, 15);
            lblTroco.TabIndex = 13;
            lblTroco.Text = "Troco:";
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.Location = new Point(9, 162);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(85, 15);
            lblValorRecebido.TabIndex = 12;
            lblValorRecebido.Text = "Valor recebido:";
            // 
            // btnBoleto
            // 
            btnBoleto.Location = new Point(113, 90);
            btnBoleto.Name = "btnBoleto";
            btnBoleto.Size = new Size(97, 49);
            btnBoleto.TabIndex = 11;
            btnBoleto.Text = "\U0001f9fe Boleto";
            btnBoleto.UseVisualStyleBackColor = true;
            btnBoleto.Click += btnBoleto_Click;
            // 
            // btnPix
            // 
            btnPix.Location = new Point(9, 90);
            btnPix.Name = "btnPix";
            btnPix.Size = new Size(97, 49);
            btnPix.TabIndex = 10;
            btnPix.Text = "❖ PIX";
            btnPix.UseVisualStyleBackColor = true;
            btnPix.Click += btnPix_Click;
            // 
            // btnCartao
            // 
            btnCartao.Location = new Point(112, 33);
            btnCartao.Name = "btnCartao";
            btnCartao.Size = new Size(97, 49);
            btnCartao.TabIndex = 9;
            btnCartao.Text = "💳 Cartão";
            btnCartao.UseVisualStyleBackColor = true;
            btnCartao.Click += btnCartao_Click;
            // 
            // btnDinheiro
            // 
            btnDinheiro.Location = new Point(9, 33);
            btnDinheiro.Name = "btnDinheiro";
            btnDinheiro.Size = new Size(97, 49);
            btnDinheiro.TabIndex = 8;
            btnDinheiro.Text = "💵 Dinheiro";
            btnDinheiro.UseVisualStyleBackColor = true;
            btnDinheiro.Click += btnDinheiro_Click;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPagamento.Location = new Point(9, 10);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(140, 17);
            lblFormaPagamento.TabIndex = 2;
            lblFormaPagamento.Text = "Forma de pagamento";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblRetornoQuantidade);
            panel6.Controls.Add(lblQtdeItens);
            panel6.Controls.Add(btnCancelarItem);
            panel6.Controls.Add(dgvItemVenda);
            panel6.Controls.Add(lbItensVenda);
            panel6.Location = new Point(7, 207);
            panel6.Name = "panel6";
            panel6.Size = new Size(593, 279);
            panel6.TabIndex = 2;
            // 
            // lblRetornoQuantidade
            // 
            lblRetornoQuantidade.AutoSize = true;
            lblRetornoQuantidade.Location = new Point(560, 259);
            lblRetornoQuantidade.Name = "lblRetornoQuantidade";
            lblRetornoQuantidade.Size = new Size(0, 15);
            lblRetornoQuantidade.TabIndex = 4;
            // 
            // lblQtdeItens
            // 
            lblQtdeItens.AutoSize = true;
            lblQtdeItens.Location = new Point(438, 259);
            lblQtdeItens.Name = "lblQtdeItens";
            lblQtdeItens.Size = new Size(116, 15);
            lblQtdeItens.TabIndex = 3;
            lblQtdeItens.Text = "Quantidade de itens:";
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
            btnCancelarItem.Click += btnCancelarItem_Click;
            // 
            // dgvItemVenda
            // 
            dgvItemVenda.AllowUserToAddRows = false;
            dgvItemVenda.AllowUserToDeleteRows = false;
            dgvItemVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItemVenda.BackgroundColor = Color.White;
            dgvItemVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemVenda.Location = new Point(12, 30);
            dgvItemVenda.Name = "dgvItemVenda";
            dgvItemVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemVenda.Size = new Size(571, 219);
            dgvItemVenda.TabIndex = 1;
            dgvItemVenda.CellContentClick += dgvItemVenda_CellContentClick;
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
            panel5.Controls.Add(btnFinalizarVenda);
            panel5.Controls.Add(btnConsultarPreco);
            panel5.Controls.Add(btnLimparVenda);
            panel5.Controls.Add(btnAdicionarNovaVenda);
            panel5.Location = new Point(6, 492);
            panel5.Name = "panel5";
            panel5.Size = new Size(832, 70);
            panel5.TabIndex = 1;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.FromArgb(0, 192, 0);
            btnFinalizarVenda.Location = new Point(623, 14);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(185, 42);
            btnFinalizarVenda.TabIndex = 3;
            btnFinalizarVenda.Text = "✅ Finalizar venda";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // btnConsultarPreco
            // 
            btnConsultarPreco.Location = new Point(421, 14);
            btnConsultarPreco.Name = "btnConsultarPreco";
            btnConsultarPreco.Size = new Size(185, 42);
            btnConsultarPreco.TabIndex = 2;
            btnConsultarPreco.Text = "🔍 Consultar preço";
            btnConsultarPreco.UseVisualStyleBackColor = true;
            // 
            // btnLimparVenda
            // 
            btnLimparVenda.Location = new Point(223, 14);
            btnLimparVenda.Name = "btnLimparVenda";
            btnLimparVenda.Size = new Size(185, 42);
            btnLimparVenda.TabIndex = 1;
            btnLimparVenda.Text = "🗑️ Limpar venda";
            btnLimparVenda.UseVisualStyleBackColor = true;
            btnLimparVenda.Click += btnLimparVenda_Click;
            // 
            // btnAdicionarNovaVenda
            // 
            btnAdicionarNovaVenda.BackColor = Color.FromArgb(255, 128, 0);
            btnAdicionarNovaVenda.ForeColor = Color.White;
            btnAdicionarNovaVenda.Location = new Point(25, 14);
            btnAdicionarNovaVenda.Name = "btnAdicionarNovaVenda";
            btnAdicionarNovaVenda.Size = new Size(185, 42);
            btnAdicionarNovaVenda.TabIndex = 0;
            btnAdicionarNovaVenda.Text = "➕ Nova venda";
            btnAdicionarNovaVenda.UseVisualStyleBackColor = false;
            btnAdicionarNovaVenda.Click += btnAdicionarNovaVenda_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnAdicionarItem);
            panel3.Controls.Add(txtCodigoBarras);
            panel3.Controls.Add(lblAdicionarProdutoVenda);
            panel3.Location = new Point(6, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(593, 70);
            panel3.TabIndex = 1;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = Color.FromArgb(255, 128, 0);
            btnAdicionarItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarItem.ForeColor = Color.Snow;
            btnAdicionarItem.Location = new Point(486, 27);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(97, 29);
            btnAdicionarItem.TabIndex = 2;
            btnAdicionarItem.Text = "Adicionar Item";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigoBarras.ForeColor = SystemColors.ScrollBar;
            txtCodigoBarras.Location = new Point(12, 27);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(456, 29);
            txtCodigoBarras.TabIndex = 1;
            txtCodigoBarras.TextChanged += txtCodigoBarras_TextChanged;
            txtCodigoBarras.Enter += txtCodigoBarras_Enter;
            txtCodigoBarras.KeyDown += txtCodigoBarras_KeyDown;
            txtCodigoBarras.Leave += txtCodigoBarras_Leave;
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
            panel2.Controls.Add(lblRetornoCliente);
            panel2.Controls.Add(lblCliente);
            panel2.Controls.Add(btnAplicarDesconto);
            panel2.Controls.Add(rdbPorcentagem);
            panel2.Controls.Add(rdbValor);
            panel2.Controls.Add(txtDesconto);
            panel2.Controls.Add(lblSubTotalRecebido);
            panel2.Controls.Add(lblDesconto);
            panel2.Controls.Add(lblRetornoTotal);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblSubTotal);
            panel2.Controls.Add(lblResumoVenda);
            panel2.Location = new Point(605, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 198);
            panel2.TabIndex = 0;
            // 
            // lblRetornoCliente
            // 
            lblRetornoCliente.AutoSize = true;
            lblRetornoCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetornoCliente.Location = new Point(50, 35);
            lblRetornoCliente.Name = "lblRetornoCliente";
            lblRetornoCliente.Size = new Size(0, 15);
            lblRetornoCliente.TabIndex = 23;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(9, 34);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(46, 15);
            lblCliente.TabIndex = 22;
            lblCliente.Text = "Cliente:";
            // 
            // btnAplicarDesconto
            // 
            btnAplicarDesconto.Location = new Point(50, 139);
            btnAplicarDesconto.Name = "btnAplicarDesconto";
            btnAplicarDesconto.Size = new Size(126, 23);
            btnAplicarDesconto.TabIndex = 21;
            btnAplicarDesconto.Text = "Aplicar desconto";
            btnAplicarDesconto.UseVisualStyleBackColor = true;
            btnAplicarDesconto.Click += btnAplicarDesconto_Click;
            // 
            // rdbPorcentagem
            // 
            rdbPorcentagem.AutoSize = true;
            rdbPorcentagem.Location = new Point(88, 112);
            rdbPorcentagem.Name = "rdbPorcentagem";
            rdbPorcentagem.Size = new Size(109, 19);
            rdbPorcentagem.TabIndex = 20;
            rdbPorcentagem.TabStop = true;
            rdbPorcentagem.Text = "Porcentagem %";
            rdbPorcentagem.UseVisualStyleBackColor = true;
            // 
            // rdbValor
            // 
            rdbValor.AutoSize = true;
            rdbValor.Location = new Point(15, 110);
            rdbValor.Name = "rdbValor";
            rdbValor.Size = new Size(67, 19);
            rdbValor.TabIndex = 19;
            rdbValor.TabStop = true;
            rdbValor.Text = "Valor R$";
            rdbValor.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(87, 76);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(68, 23);
            txtDesconto.TabIndex = 18;
            // 
            // lblSubTotalRecebido
            // 
            lblSubTotalRecebido.AutoSize = true;
            lblSubTotalRecebido.Location = new Point(176, 53);
            lblSubTotalRecebido.Name = "lblSubTotalRecebido";
            lblSubTotalRecebido.Size = new Size(0, 15);
            lblSubTotalRecebido.TabIndex = 16;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconto.Location = new Point(9, 79);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(58, 15);
            lblDesconto.TabIndex = 15;
            lblDesconto.Text = "Desconto";
            // 
            // lblRetornoTotal
            // 
            lblRetornoTotal.AutoSize = true;
            lblRetornoTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetornoTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblRetornoTotal.Location = new Point(121, 171);
            lblRetornoTotal.Name = "lblRetornoTotal";
            lblRetornoTotal.Size = new Size(0, 20);
            lblRetornoTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(9, 172);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 20);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "TOTAL";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(7, 53);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(54, 15);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "SubTotal";
            // 
            // lblResumoVenda
            // 
            lblResumoVenda.AutoSize = true;
            lblResumoVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumoVenda.Location = new Point(46, 7);
            lblResumoVenda.Name = "lblResumoVenda";
            lblResumoVenda.Size = new Size(118, 17);
            lblResumoVenda.TabIndex = 1;
            lblResumoVenda.Text = "Resumo da Venda";
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
            panel9.Size = new Size(210, 54);
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
            lblPdv.Location = new Point(41, 16);
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
            lblCarrinho.Location = new Point(3, 10);
            lblCarrinho.Name = "lblCarrinho";
            lblCarrinho.Size = new Size(48, 32);
            lblCarrinho.TabIndex = 0;
            lblCarrinho.Text = "\U0001f6d2";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(37, 50, 75);
            panel11.Controls.Add(btnNovaVenda);
            panel11.Controls.Add(btnSair);
            panel11.Controls.Add(btnConfiguracoes);
            panel11.Controls.Add(btnRelatorio);
            panel11.Controls.Add(btnCaixa);
            panel11.Controls.Add(btnProdutos);
            panel11.Controls.Add(btnCLientes);
            panel11.Controls.Add(btnConsultarVendas);
            panel11.Location = new Point(0, 66);
            panel11.Name = "panel11";
            panel11.Size = new Size(210, 563);
            panel11.TabIndex = 7;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovaVenda.Location = new Point(12, 11);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(162, 49);
            btnNovaVenda.TabIndex = 8;
            btnNovaVenda.Text = "\U0001f6d2 Nova Venda";
            btnNovaVenda.UseVisualStyleBackColor = true;
            btnNovaVenda.Click += btnNovaVenda_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(12, 483);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(162, 49);
            btnSair.TabIndex = 7;
            btnSair.Text = "🚪 Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracoes.Location = new Point(12, 341);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Size = new Size(162, 49);
            btnConfiguracoes.TabIndex = 6;
            btnConfiguracoes.Text = "⚙️ Configurações";
            btnConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(12, 286);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(162, 49);
            btnRelatorio.TabIndex = 5;
            btnRelatorio.Text = "📈 Relatórios";
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            btnCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaixa.Location = new Point(12, 231);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(162, 49);
            btnCaixa.TabIndex = 4;
            btnCaixa.Text = "🏧 Caixa";
            btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            btnProdutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdutos.Location = new Point(12, 176);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(162, 49);
            btnProdutos.TabIndex = 3;
            btnProdutos.Text = "🛍️ Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.MouseClick += btnProdutos_MouseClick;
            // 
            // btnCLientes
            // 
            btnCLientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCLientes.Location = new Point(12, 121);
            btnCLientes.Name = "btnCLientes";
            btnCLientes.Size = new Size(162, 49);
            btnCLientes.TabIndex = 2;
            btnCLientes.Text = "👥 Clientes";
            btnCLientes.UseVisualStyleBackColor = true;
            btnCLientes.Click += btnCLientes_Click;
            // 
            // btnConsultarVendas
            // 
            btnConsultarVendas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarVendas.Location = new Point(12, 66);
            btnConsultarVendas.Name = "btnConsultarVendas";
            btnConsultarVendas.Size = new Size(162, 49);
            btnConsultarVendas.TabIndex = 1;
            btnConsultarVendas.Text = "🔍 Consultar Venda";
            btnConsultarVendas.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmPainelVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 631);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Name = "frmPainelVendas";
            Text = "Painel de Vendas - Ecommerce";
            Load += frmPainelVendas_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbProduto).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemVenda).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private TextBox txtCodigoBarras;
        private Label lblAdicionarProdutoVenda;
        private Panel panel8;
        private PictureBox pcbProduto;
        private Button btnAdicionarItem;
        private Label lblRetornoProduto;
        private Label lblProduto;
        private Label lblEstoque;
        private Label lblRetornoPrecoUnitario;
        private Label lblPrecoUnitario;
        private Label lblRetornoCategoria;
        private Label lblCategoria;
        private Label label5;
        private Label lbItensVenda;
        private Button btnCancelarItem;
        private DataGridView dgvItemVenda;
        private Panel panel9;
        private Label lblCarrinho;
        private Label lblPdv;
        private Panel panel10;
        private Panel panel11;
        private Button btnSair;
        private Button btnConfiguracoes;
        private Button btnRelatorio;
        private Button btnCaixa;
        private Button btnProdutos;
        private Button btnCLientes;
        private Button btnConsultarVendas;
        private Label lblRetornoQuantidade;
        private Label lblQtdeItens;
        private Label lblDesconto;
        private Label lblRetornoTotal;
        private Label lblTotal;
        private Label lblSubTotal;
        private Label lblResumoVenda;
        private Label lblTroco;
        private Label lblValorRecebido;
        private Button btnBoleto;
        private Button btnPix;
        private Button btnCartao;
        private Button btnDinheiro;
        private Label lblFormaPagamento;
        private Label lblSubTotalRecebido;
        private TextBox txtValorRecebido;
        private Button btnFinalizarVenda;
        private Button btnConsultarPreco;
        private Button btnLimparVenda;
        private Button btnAdicionarNovaVenda;
        private TextBox txtDesconto;
        private Label lblRetornoTroco;
        private Label lblCaixa;
        private PictureBox pcbUsuario;
        private Label lblNomeOperador;
        private Label lblReceberCaixa;
        private Label lblOperador;
        private MaskedTextBox mskData;
        private Button btnNovaVenda;
        private Label lblRetornoEstoque;
        private Label lblRetornoCodigo;
        private GroupBox groupBox1;
        private RadioButton rdbPorcentagem;
        private RadioButton rdbValor;
        private Button btnAplicarDesconto;
        private Label lblCliente;
        private Label lblRetornoCliente;
        private System.Windows.Forms.Timer timer1;
    }
}