using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ControleFinanceiroApp
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        string connStr = "Host=localhost;Port=5432;Username=postgres;Password=M3698520;Database=controle_financeiro";

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Receita");
            cmbTipo.Items.Add("Despesa");
            cmbTipo.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da categoria.");
                return;
            }

            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Selecione o tipo da categoria.");
                return;
            }

            using var conn = new NpgsqlConnection(connStr);
            conn.Open();

            string sql = "INSERT INTO categoria (nome, tipo) VALUES (@nome, @tipo)";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("tipo", cmbTipo.SelectedItem?.ToString() ?? string.Empty);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Categoria cadastrada com sucesso!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using var conn = new NpgsqlConnection(connStr);
            string sql = "SELECT id_categoria, nome, tipo FROM categoria ORDER BY id_categoria";
            using (var da = new NpgsqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategorias.DataSource = dt;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma categoria na tabela.");
                return;
            }

            int idCategoria = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["id_categoria"].Value);

            var confirm = MessageBox.Show("Tem certeza que deseja remover essa categoria?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            using var conn = new NpgsqlConnection(connStr);
            string sql = "DELETE FROM categoria WHERE id_categoria = @id";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("id", idCategoria);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Categoria removida com sucesso!");
        }
    }
}
