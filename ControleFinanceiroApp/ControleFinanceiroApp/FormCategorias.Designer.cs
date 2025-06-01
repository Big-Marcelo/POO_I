namespace ControleFinanceiroApp
{
    partial class FormCategorias
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvCategorias;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            lblNome = new Label();
            txtNome = new TextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnSalvar = new Button();
            btnListar = new Button();
            btnRemover = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(30, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(113, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome da Categoria:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(150, 17);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(30, 55);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(150, 52);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(200, 23);
            cmbTipo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(30, 90);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar Categoria";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(140, 90);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(100, 30);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listar Categorias";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(250, 90);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 30);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover Categoria";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(30, 140);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(440, 200);
            dgvCategorias.TabIndex = 7;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(504, 361);
            Controls.Add(dgvCategorias);
            Controls.Add(btnRemover);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormCategorias";
            Text = "Categorias";
            Load += FormCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
