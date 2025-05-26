namespace WinFormsPostgres
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            btnSalvar = new Button();
            btnListar = new Button();
            listUsuarios = new ListBox();
            txtSobrenome = new TextBox();
            btnExcluir = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Info;
            txtNome.Location = new Point(55, 0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(218, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 68);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(93, 68);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click_1;
            // 
            // listUsuarios
            // 
            listUsuarios.BackColor = SystemColors.InactiveCaption;
            listUsuarios.Dock = DockStyle.Bottom;
            listUsuarios.FormattingEnabled = true;
            listUsuarios.ItemHeight = 15;
            listUsuarios.Location = new Point(0, 109);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(273, 94);
            listUsuarios.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            txtSobrenome.BackColor = SystemColors.Info;
            txtSobrenome.Location = new Point(85, 29);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(188, 23);
            txtSobrenome.TabIndex = 4;
            txtSobrenome.TextChanged += txtSobrenome_TextChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(174, 68);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 32);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 7;
            label2.Text = "Sobrenome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 203);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(txtSobrenome);
            Controls.Add(listUsuarios);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnSalvar;
        private Button btnListar;
        private ListBox listUsuarios;
        private TextBox txtSobrenome;
        private Button btnExcluir;
        private Label label1;
        private Label label2;
    }
}
