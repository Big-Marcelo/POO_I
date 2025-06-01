namespace ControleFinanceiroApp
{
    partial class FormContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContas));
            label1 = new Label();
            txtIdUsuarioConta = new TextBox();
            label2 = new Label();
            cmbTipoConta = new ComboBox();
            label3 = new Label();
            txtBanco = new TextBox();
            label4 = new Label();
            txtNumero = new TextBox();
            btnAdicionarConta = new Button();
            btnRemoverConta = new Button();
            btnCarregarContas = new Button();
            dataGridViewContas = new DataGridView();
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário (ID):";
            // 
            // txtIdUsuarioConta
            // 
            txtIdUsuarioConta.Location = new Point(111, 24);
            txtIdUsuarioConta.Name = "txtIdUsuarioConta";
            txtIdUsuarioConta.Size = new Size(100, 23);
            txtIdUsuarioConta.TabIndex = 1;
            txtIdUsuarioConta.TextChanged += txtIdUsuarioConta_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(33, 56);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo:";
            // 
            // cmbTipoConta
            // 
            cmbTipoConta.FormattingEnabled = true;
            cmbTipoConta.Items.AddRange(new object[] { "corrente", "poupanca", "cartao" });
            cmbTipoConta.Location = new Point(73, 53);
            cmbTipoConta.Name = "cmbTipoConta";
            cmbTipoConta.Size = new Size(121, 23);
            cmbTipoConta.TabIndex = 3;
            cmbTipoConta.SelectedIndexChanged += cmbTipoConta_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 85);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Banco:";
            // 
            // txtBanco
            // 
            txtBanco.Location = new Point(82, 82);
            txtBanco.Name = "txtBanco";
            txtBanco.Size = new Size(100, 23);
            txtBanco.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 114);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(93, 111);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 7;
            // 
            // btnAdicionarConta
            // 
            btnAdicionarConta.Location = new Point(304, 23);
            btnAdicionarConta.Name = "btnAdicionarConta";
            btnAdicionarConta.Size = new Size(122, 23);
            btnAdicionarConta.TabIndex = 8;
            btnAdicionarConta.Text = "Adicionar Conta";
            btnAdicionarConta.UseVisualStyleBackColor = true;
            btnAdicionarConta.Click += btnAdicionarConta_Click;
            // 
            // btnRemoverConta
            // 
            btnRemoverConta.Location = new Point(304, 73);
            btnRemoverConta.Name = "btnRemoverConta";
            btnRemoverConta.Size = new Size(122, 23);
            btnRemoverConta.TabIndex = 9;
            btnRemoverConta.Text = "Remover Conta";
            btnRemoverConta.UseVisualStyleBackColor = true;
            btnRemoverConta.Click += btnRemoverConta_Click;
            // 
            // btnCarregarContas
            // 
            btnCarregarContas.Location = new Point(304, 125);
            btnCarregarContas.Name = "btnCarregarContas";
            btnCarregarContas.Size = new Size(122, 23);
            btnCarregarContas.TabIndex = 10;
            btnCarregarContas.Text = "Carregar Contas";
            btnCarregarContas.UseVisualStyleBackColor = true;
            btnCarregarContas.Click += btnCarregarContas_Click;
            // 
            // dataGridViewContas
            // 
            dataGridViewContas.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewContas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContas.GridColor = SystemColors.ScrollBar;
            dataGridViewContas.Location = new Point(33, 186);
            dataGridViewContas.Name = "dataGridViewContas";
            dataGridViewContas.Size = new Size(444, 203);
            dataGridViewContas.TabIndex = 11;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(33, 146);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(39, 15);
            lblSaldo.TabIndex = 12;
            lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(78, 140);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 13;
            txtSaldo.TextChanged += txtSaldo_TextChanged;
            // 
            // FormContas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(507, 412);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(dataGridViewContas);
            Controls.Add(btnCarregarContas);
            Controls.Add(btnRemoverConta);
            Controls.Add(btnAdicionarConta);
            Controls.Add(txtNumero);
            Controls.Add(label4);
            Controls.Add(txtBanco);
            Controls.Add(label3);
            Controls.Add(cmbTipoConta);
            Controls.Add(label2);
            Controls.Add(txtIdUsuarioConta);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormContas";
            Text = "Contas";
            Load += FormContas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdUsuarioConta;
        private Label label2;
        private ComboBox cmbTipoConta;
        private Label label3;
        private TextBox txtBanco;
        private Label label4;
        private TextBox txtNumero;
        private Button btnAdicionarConta;
        private Button btnRemoverConta;
        private Button btnCarregarContas;
        private DataGridView dataGridViewContas;
        private Label lblSaldo;
        private TextBox txtSaldo;
    }
}