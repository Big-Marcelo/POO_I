namespace ControleFinanceiroApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            dtpNascimento = new DateTimePicker();
            btnAdicionarUsuario = new Button();
            btnRemoverUsuario = new Button();
            btnCarregarUsuarios = new Button();
            dataGridViewUsuarios = new DataGridView();
            btnContas = new Button();
            btnTransacoes = new Button();
            btnCategorias = new Button();
            btnMetasFinanceiras = new Button();
            btnAlertas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 14;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 13;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(58, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 10;
            label3.Text = "Data de Nascimento:";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(135, 97);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(248, 23);
            dtpNascimento.TabIndex = 9;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Location = new Point(12, 148);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(100, 25);
            btnAdicionarUsuario.TabIndex = 8;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.Click += btnAdicionarUsuario_Click;
            // 
            // btnRemoverUsuario
            // 
            btnRemoverUsuario.Location = new Point(12, 181);
            btnRemoverUsuario.Name = "btnRemoverUsuario";
            btnRemoverUsuario.Size = new Size(100, 25);
            btnRemoverUsuario.TabIndex = 7;
            btnRemoverUsuario.Text = "Remover";
            btnRemoverUsuario.Click += btnRemoverUsuario_Click;
            // 
            // btnCarregarUsuarios
            // 
            btnCarregarUsuarios.Location = new Point(12, 213);
            btnCarregarUsuarios.Name = "btnCarregarUsuarios";
            btnCarregarUsuarios.Size = new Size(100, 25);
            btnCarregarUsuarios.TabIndex = 6;
            btnCarregarUsuarios.Text = "Carregar";
            btnCarregarUsuarios.Click += btnCarregarUsuarios_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(24, 260);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.Size = new Size(723, 129);
            dataGridViewUsuarios.TabIndex = 5;
            // 
            // btnContas
            // 
            btnContas.BackColor = Color.FromArgb(33, 150, 243);
            btnContas.FlatStyle = FlatStyle.Flat;
            btnContas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnContas.ForeColor = Color.White;
            btnContas.Location = new Point(130, 150);
            btnContas.Name = "btnContas";
            btnContas.Size = new Size(100, 80);
            btnContas.TabIndex = 4;
            btnContas.Text = "Contas";
            btnContas.UseVisualStyleBackColor = false;
            btnContas.Click += btnContas_Click;
            // 
            // btnTransacoes
            // 
            btnTransacoes.BackColor = Color.FromArgb(76, 175, 80);
            btnTransacoes.FlatStyle = FlatStyle.Flat;
            btnTransacoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransacoes.ForeColor = Color.White;
            btnTransacoes.Location = new Point(240, 150);
            btnTransacoes.Name = "btnTransacoes";
            btnTransacoes.Size = new Size(100, 80);
            btnTransacoes.TabIndex = 3;
            btnTransacoes.Text = "Transações";
            btnTransacoes.UseVisualStyleBackColor = false;
            btnTransacoes.Click += btnTransacoes_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.Goldenrod;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(350, 150);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(100, 80);
            btnCategorias.TabIndex = 2;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnMetasFinanceiras
            // 
            btnMetasFinanceiras.BackColor = Color.FromArgb(255, 152, 0);
            btnMetasFinanceiras.FlatStyle = FlatStyle.Flat;
            btnMetasFinanceiras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMetasFinanceiras.ForeColor = Color.White;
            btnMetasFinanceiras.Location = new Point(460, 150);
            btnMetasFinanceiras.Name = "btnMetasFinanceiras";
            btnMetasFinanceiras.Size = new Size(100, 80);
            btnMetasFinanceiras.TabIndex = 1;
            btnMetasFinanceiras.Text = "Metas";
            btnMetasFinanceiras.UseVisualStyleBackColor = false;
            btnMetasFinanceiras.Click += btnMetasFinanceiras_Click;
            // 
            // btnAlertas
            // 
            btnAlertas.BackColor = Color.FromArgb(244, 67, 54);
            btnAlertas.FlatStyle = FlatStyle.Flat;
            btnAlertas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlertas.ForeColor = Color.White;
            btnAlertas.Location = new Point(570, 150);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.Size = new Size(100, 80);
            btnAlertas.TabIndex = 0;
            btnAlertas.Text = "Alertas";
            btnAlertas.UseVisualStyleBackColor = false;
            btnAlertas.Click += btnAlertas_Click;
            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(772, 410);
            Controls.Add(btnAlertas);
            Controls.Add(btnMetasFinanceiras);
            Controls.Add(btnCategorias);
            Controls.Add(btnTransacoes);
            Controls.Add(btnContas);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(btnCarregarUsuarios);
            Controls.Add(btnRemoverUsuario);
            Controls.Add(btnAdicionarUsuario);
            Controls.Add(dtpNascimento);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Usuários";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.Button btnRemoverUsuario;
        private System.Windows.Forms.Button btnCarregarUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnTransacoes;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMetasFinanceiras;
        private System.Windows.Forms.Button btnAlertas;
    }
}
