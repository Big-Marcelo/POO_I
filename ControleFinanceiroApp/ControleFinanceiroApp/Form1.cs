using Npgsql;
using System.Data;

namespace ControleFinanceiroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connStr = "Host=localhost;Port=5432;Username=postgres;Password=M3698520;Database=controle_financeiro";

        private void CarregarUsuarios()
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM usuario ORDER BY id_usuario", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridViewUsuarios.DataSource = dt;
        }

        private void AdicionarUsuario(string nome, string email, DateTime nascimento)
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var cmd = new NpgsqlCommand("INSERT INTO usuario (nome, email, data_nascimento) VALUES (@n, @e, @d)", conn);
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("e", email);
            cmd.Parameters.AddWithValue("d", nascimento);
            cmd.ExecuteNonQuery();
        }

        private void RemoverUsuario(int id)
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var cmd = new NpgsqlCommand("DELETE FROM usuario WHERE id_usuario = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
        private void btnCarregarUsuarios_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            DateTime dataNasc = dtpNascimento.Value;

            AdicionarUsuario(nome, email, dataNasc);
            CarregarUsuarios();
        }

        private void btnRemoverUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["id_usuario"].Value);
                RemoverUsuario(id);
                CarregarUsuarios();
            }
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            var formContas = new FormContas();
            formContas.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTransacoes_Click(object sender, EventArgs e)
        {
            var formTransacoes = new FormTransacoes();
            formTransacoes.ShowDialog();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMetasFinanceiras_Click(object sender, EventArgs e)
        {
            var formMetasFinanceiras = new FormMetasFinanceiras();
            formMetasFinanceiras.ShowDialog();
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            var formAlertas = new FormAlertas();
            formAlertas.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var formCategorias = new FormCategorias();
            formCategorias.ShowDialog();
        }
    }
}
