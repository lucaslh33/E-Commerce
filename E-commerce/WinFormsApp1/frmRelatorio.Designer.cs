namespace Ecommerce
{
    partial class frmRelatorio
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
            lblRelatorio = new Label();
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            lblDataInicial = new Label();
            lblDataFinal = new Label();
            btnGerarRelatorio = new Button();
            dgvRelatorioVendas = new DataGridView();
            lblTotalVendas = new Label();
            lblQuantidadePedidos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioVendas).BeginInit();
            SuspendLayout();
            // 
            // lblRelatorio
            // 
            lblRelatorio.AutoSize = true;
            lblRelatorio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRelatorio.Location = new Point(242, 24);
            lblRelatorio.Name = "lblRelatorio";
            lblRelatorio.Size = new Size(93, 25);
            lblRelatorio.TabIndex = 1;
            lblRelatorio.Text = "Relatório";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(86, 72);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(228, 23);
            dtpInicio.TabIndex = 7;
            // 
            // dtpFim
            // 
            dtpFim.Location = new Point(414, 72);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(200, 23);
            dtpFim.TabIndex = 8;
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(12, 78);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(68, 15);
            lblDataInicial.TabIndex = 9;
            lblDataInicial.Text = "Data Inicial:";
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(346, 78);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(62, 15);
            lblDataFinal.TabIndex = 10;
            lblDataFinal.Text = "Data Final:";
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(12, 101);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(105, 23);
            btnGerarRelatorio.TabIndex = 11;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // dgvRelatorioVendas
            // 
            dgvRelatorioVendas.AllowUserToAddRows = false;
            dgvRelatorioVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorioVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorioVendas.Location = new Point(12, 130);
            dgvRelatorioVendas.Name = "dgvRelatorioVendas";
            dgvRelatorioVendas.ReadOnly = true;
            dgvRelatorioVendas.Size = new Size(602, 461);
            dgvRelatorioVendas.TabIndex = 12;
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Location = new Point(12, 614);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(76, 15);
            lblTotalVendas.TabIndex = 13;
            lblTotalVendas.Text = "Total Vendas:";
            // 
            // lblQuantidadePedidos
            // 
            lblQuantidadePedidos.AutoSize = true;
            lblQuantidadePedidos.Location = new Point(483, 614);
            lblQuantidadePedidos.Name = "lblQuantidadePedidos";
            lblQuantidadePedidos.Size = new Size(117, 15);
            lblQuantidadePedidos.TabIndex = 14;
            lblQuantidadePedidos.Text = "Quantidade Pedidos:";
            // 
            // frmRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 674);
            Controls.Add(lblQuantidadePedidos);
            Controls.Add(lblTotalVendas);
            Controls.Add(dgvRelatorioVendas);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(lblDataFinal);
            Controls.Add(lblDataInicial);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Controls.Add(lblRelatorio);
            Name = "frmRelatorio";
            Text = "frmRelatorio";
            ((System.ComponentModel.ISupportInitialize)dgvRelatorioVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRelatorio;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label lblDataInicial;
        private Label lblDataFinal;
        private Button btnGerarRelatorio;
        private DataGridView dgvRelatorioVendas;
        private Label lblTotalVendas;
        private Label lblQuantidadePedidos;
    }
}