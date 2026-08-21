namespace Ecommerce
{
    partial class frmCartao
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblRetornoValorCompra = new Label();
            rdbCredito = new RadioButton();
            rdbDebito = new RadioButton();
            mskNumero = new MaskedTextBox();
            txtNome = new TextBox();
            mskValidade = new MaskedTextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            mskCVV = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 0;
            label1.Text = "Pagamento com Cartão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 47);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Número do cartão:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome do titular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Validade :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 305);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Valor da compra:";
            // 
            // lblRetornoValorCompra
            // 
            lblRetornoValorCompra.AutoSize = true;
            lblRetornoValorCompra.Location = new Point(12, 334);
            lblRetornoValorCompra.Name = "lblRetornoValorCompra";
            lblRetornoValorCompra.Size = new Size(0, 15);
            lblRetornoValorCompra.TabIndex = 5;
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Location = new Point(12, 246);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(64, 19);
            rdbCredito.TabIndex = 6;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Crédito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbDebito
            // 
            rdbDebito.AutoSize = true;
            rdbDebito.Location = new Point(12, 271);
            rdbDebito.Name = "rdbDebito";
            rdbDebito.Size = new Size(60, 19);
            rdbDebito.TabIndex = 7;
            rdbDebito.TabStop = true;
            rdbDebito.Text = "Débito";
            rdbDebito.UseVisualStyleBackColor = true;
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(16, 65);
            mskNumero.Mask = "0000 0000 0000 0000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(206, 23);
            mskNumero.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(16, 119);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(206, 23);
            txtNome.TabIndex = 9;
            // 
            // mskValidade
            // 
            mskValidade.Location = new Point(16, 172);
            mskValidade.Mask = "00/00";
            mskValidade.Name = "mskValidade";
            mskValidade.Size = new Size(53, 23);
            mskValidade.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(31, 361);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(144, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 198);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 13;
            label6.Text = "CVV:";
            // 
            // mskCVV
            // 
            mskCVV.Location = new Point(16, 217);
            mskCVV.Mask = "000";
            mskCVV.Name = "mskCVV";
            mskCVV.Size = new Size(53, 23);
            mskCVV.TabIndex = 14;
            mskCVV.ValidatingType = typeof(int);
            // 
            // frmCartao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 396);
            Controls.Add(mskCVV);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(mskValidade);
            Controls.Add(txtNome);
            Controls.Add(mskNumero);
            Controls.Add(rdbDebito);
            Controls.Add(rdbCredito);
            Controls.Add(lblRetornoValorCompra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCartao";
            Text = "frmCartao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblRetornoValorCompra;
        private RadioButton rdbCredito;
        private RadioButton rdbDebito;
        private MaskedTextBox mskNumero;
        private TextBox txtNome;
        private MaskedTextBox mskValidade;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label6;
        private MaskedTextBox mskCVV;
    }
}