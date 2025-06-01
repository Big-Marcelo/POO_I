namespace ControleFinanceiroApp
{
    partial class FormMetasFinanceiras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMetasFinanceiras));
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            dtpLimite = new DateTimePicker();
            lblDescricao = new Label();
            lblValor = new Label();
            lblDataLimite = new Label();
            lblUsuarioId = new Label();
            txtUsuarioId = new TextBox();
            dgvMetas = new DataGridView();
            btnSalvar = new Button();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMetas).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(125, 66);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(126, 106);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 1;
            // 
            // dtpLimite
            // 
            dtpLimite.Location = new Point(88, 147);
            dtpLimite.Name = "dtpLimite";
            dtpLimite.Size = new Size(250, 23);
            dtpLimite.TabIndex = 2;
            dtpLimite.ValueChanged += dtpLimite_ValueChanged;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 69);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(107, 15);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição da Meta:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 109);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(108, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor Objetivo (R$):";
            // 
            // lblDataLimite
            // 
            lblDataLimite.AutoSize = true;
            lblDataLimite.Location = new Point(12, 153);
            lblDataLimite.Name = "lblDataLimite";
            lblDataLimite.Size = new Size(70, 15);
            lblDataLimite.TabIndex = 5;
            lblDataLimite.Text = "Data Limite:";
            // 
            // lblUsuarioId
            // 
            lblUsuarioId.AutoSize = true;
            lblUsuarioId.Location = new Point(12, 25);
            lblUsuarioId.Name = "lblUsuarioId";
            lblUsuarioId.Size = new Size(81, 15);
            lblUsuarioId.TabIndex = 6;
            lblUsuarioId.Text = "ID do Usuário:";
            // 
            // txtUsuarioId
            // 
            txtUsuarioId.Location = new Point(99, 22);
            txtUsuarioId.Name = "txtUsuarioId";
            txtUsuarioId.Size = new Size(100, 23);
            txtUsuarioId.TabIndex = 7;
            // 
            // dgvMetas
            // 
            dgvMetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMetas.Location = new Point(24, 253);
            dgvMetas.Name = "dgvMetas";
            dgvMetas.Size = new Size(498, 130);
            dgvMetas.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(252, 203);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar Meta";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(126, 203);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(88, 23);
            btnListar.TabIndex = 10;
            btnListar.Text = "Listar Metas";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // FormMetasFinanceiras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(544, 403);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(dgvMetas);
            Controls.Add(txtUsuarioId);
            Controls.Add(lblUsuarioId);
            Controls.Add(lblDataLimite);
            Controls.Add(lblValor);
            Controls.Add(lblDescricao);
            Controls.Add(dtpLimite);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMetasFinanceiras";
            Text = "Metas Financeiras";
            Load += FormMetasFinanceiras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMetas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescricao;
        private TextBox txtValor;
        private DateTimePicker dtpLimite;
        private Label lblDescricao;
        private Label lblValor;
        private Label lblDataLimite;
        private Label lblUsuarioId;
        private TextBox txtUsuarioId;
        private DataGridView dgvMetas;
        private Button btnSalvar;
        private Button btnListar;
    }
}