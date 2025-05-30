namespace ControleFinanceiroApp
{
    partial class FormTransacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransacoes));
            lblConta = new Label();
            txtIdConta = new TextBox();
            lblCategoria = new Label();
            txtIdCategoria = new TextBox();
            lblTipo = new Label();
            cmbTipoTransacao = new ComboBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblData = new Label();
            dtpDataTransacao = new DateTimePicker();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            dataGridViewTransacoes = new DataGridView();
            btnAdicionarTransacao = new Button();
            btnRemoverTransacao = new Button();
            btnCarregarTransacoes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransacoes).BeginInit();
            SuspendLayout();
            // 
            // lblConta
            // 
            lblConta.AutoSize = true;
            lblConta.Location = new Point(12, 34);
            lblConta.Name = "lblConta";
            lblConta.Size = new Size(64, 15);
            lblConta.TabIndex = 0;
            lblConta.Text = "Conta (ID):";
            // 
            // txtIdConta
            // 
            txtIdConta.Location = new Point(82, 31);
            txtIdConta.Name = "txtIdConta";
            txtIdConta.Size = new Size(100, 23);
            txtIdConta.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 71);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(83, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria (ID):";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(101, 68);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(100, 23);
            txtIdCategoria.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(12, 104);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipoTransacao
            // 
            cmbTipoTransacao.FormattingEnabled = true;
            cmbTipoTransacao.Location = new Point(52, 101);
            cmbTipoTransacao.Name = "cmbTipoTransacao";
            cmbTipoTransacao.Size = new Size(121, 23);
            cmbTipoTransacao.TabIndex = 5;
            cmbTipoTransacao.SelectedIndexChanged += cmbTipoTransacao_SelectedIndexChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 138);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(54, 135);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 7;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 177);
            lblData.Name = "lblData";
            lblData.Size = new Size(34, 15);
            lblData.TabIndex = 8;
            lblData.Text = "Data:";
            // 
            // dtpDataTransacao
            // 
            dtpDataTransacao.Location = new Point(52, 171);
            dtpDataTransacao.Name = "dtpDataTransacao";
            dtpDataTransacao.Size = new Size(245, 23);
            dtpDataTransacao.TabIndex = 9;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 210);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 10;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(79, 207);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 11;
            // 
            // dataGridViewTransacoes
            // 
            dataGridViewTransacoes.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewTransacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransacoes.Location = new Point(21, 322);
            dataGridViewTransacoes.Name = "dataGridViewTransacoes";
            dataGridViewTransacoes.Size = new Size(604, 152);
            dataGridViewTransacoes.TabIndex = 12;
            // 
            // btnAdicionarTransacao
            // 
            btnAdicionarTransacao.Location = new Point(12, 264);
            btnAdicionarTransacao.Name = "btnAdicionarTransacao";
            btnAdicionarTransacao.Size = new Size(125, 23);
            btnAdicionarTransacao.TabIndex = 13;
            btnAdicionarTransacao.Text = "Adicionar Transação";
            btnAdicionarTransacao.UseVisualStyleBackColor = true;
            // 
            // btnRemoverTransacao
            // 
            btnRemoverTransacao.Location = new Point(167, 264);
            btnRemoverTransacao.Name = "btnRemoverTransacao";
            btnRemoverTransacao.Size = new Size(130, 23);
            btnRemoverTransacao.TabIndex = 14;
            btnRemoverTransacao.Text = "Remover Transação";
            btnRemoverTransacao.UseVisualStyleBackColor = true;
            // 
            // btnCarregarTransacoes
            // 
            btnCarregarTransacoes.Location = new Point(322, 264);
            btnCarregarTransacoes.Name = "btnCarregarTransacoes";
            btnCarregarTransacoes.Size = new Size(130, 23);
            btnCarregarTransacoes.TabIndex = 15;
            btnCarregarTransacoes.Text = "Carregar Transações";
            btnCarregarTransacoes.UseVisualStyleBackColor = true;
            // 
            // FormTransacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(649, 494);
            Controls.Add(btnCarregarTransacoes);
            Controls.Add(btnRemoverTransacao);
            Controls.Add(btnAdicionarTransacao);
            Controls.Add(dataGridViewTransacoes);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(dtpDataTransacao);
            Controls.Add(lblData);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(cmbTipoTransacao);
            Controls.Add(lblTipo);
            Controls.Add(txtIdCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtIdConta);
            Controls.Add(lblConta);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTransacoes";
            Text = "Transações";
            Load += FormTransacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConta;
        private TextBox txtIdConta;
        private Label lblCategoria;
        private TextBox txtIdCategoria;
        private Label lblTipo;
        private ComboBox cmbTipoTransacao;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblData;
        private DateTimePicker dtpDataTransacao;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private DataGridView dataGridViewTransacoes;
        private Button btnAdicionarTransacao;
        private Button btnRemoverTransacao;
        private Button btnCarregarTransacoes;
    }
}