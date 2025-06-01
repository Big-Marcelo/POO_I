namespace ControleFinanceiroApp
{
    partial class FormAlertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlertas));
            lblUsuarioId = new Label();
            txtUsuarioId = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblCondicao = new Label();
            txtCondicao = new TextBox();
            chkAtivo = new CheckBox();
            btnCriar = new Button();
            btnListar = new Button();
            dgvAlertas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).BeginInit();
            SuspendLayout();
            // 
            // lblUsuarioId
            // 
            lblUsuarioId.AutoSize = true;
            lblUsuarioId.Location = new Point(12, 21);
            lblUsuarioId.Name = "lblUsuarioId";
            lblUsuarioId.Size = new Size(81, 15);
            lblUsuarioId.TabIndex = 0;
            lblUsuarioId.Text = "ID do Usuário:";
            // 
            // txtUsuarioId
            // 
            txtUsuarioId.Location = new Point(99, 18);
            txtUsuarioId.Name = "txtUsuarioId";
            txtUsuarioId.Size = new Size(100, 23);
            txtUsuarioId.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 60);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(79, 57);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 3;
            // 
            // lblCondicao
            // 
            lblCondicao.AutoSize = true;
            lblCondicao.Location = new Point(12, 102);
            lblCondicao.Name = "lblCondicao";
            lblCondicao.Size = new Size(61, 15);
            lblCondicao.TabIndex = 4;
            lblCondicao.Text = "Condição:";
            // 
            // txtCondicao
            // 
            txtCondicao.Location = new Point(79, 99);
            txtCondicao.Name = "txtCondicao";
            txtCondicao.Size = new Size(100, 23);
            txtCondicao.TabIndex = 5;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(12, 146);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 6;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(88, 176);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 7;
            btnCriar.Text = "Criar Alerta";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(196, 176);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(82, 23);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar Alertas";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvAlertas
            // 
            dgvAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertas.Location = new Point(12, 263);
            dgvAlertas.Name = "dgvAlertas";
            dgvAlertas.Size = new Size(574, 121);
            dgvAlertas.TabIndex = 9;
            dgvAlertas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormAlertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(598, 396);
            Controls.Add(dgvAlertas);
            Controls.Add(btnListar);
            Controls.Add(btnCriar);
            Controls.Add(chkAtivo);
            Controls.Add(txtCondicao);
            Controls.Add(lblCondicao);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtUsuarioId);
            Controls.Add(lblUsuarioId);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAlertas";
            Text = "Alertas";
            Load += FormAlertas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlertas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioId;
        private TextBox txtUsuarioId;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblCondicao;
        private TextBox txtCondicao;
        private CheckBox chkAtivo;
        private Button btnCriar;
        private Button btnListar;
        private DataGridView dgvAlertas;
    }
}