using System;
using System.Windows.Forms;
using Npgsql;
namespace WinFormsPostgres
{
    public partial class Form1 : Form
    {
        private string connString =
        "Host=localhost;Username=postgres;Password=M3698520;Database=RO_09";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Código a ser executado quando o formulário for carregado
            MessageBox.Show("Formulário carregado com sucesso!");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string sobrenome = txtSobrenome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
            {
                MessageBox.Show("Digite nome e sobrenome.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open(); // Aqui pode dar erro se a conexão falhar

                    string insertSql = "INSERT INTO usuarios (nome, sobrenome) VALUES (@nome, @sobrenome)";
                    using (var cmd = new NpgsqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("sobrenome", sobrenome);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuário salvo com sucesso!");
                txtNome.Clear();
                txtSobrenome.Clear();
                btnListar_Click(sender, e); // Atualiza a lista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT id, nome, sobrenome FROM usuarios";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nomeCompleto = reader.GetString(1) + " " + reader.GetString(2);
                        listUsuarios.Items.Add($"{id}: {nomeCompleto}");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            string selecionado = listUsuarios.SelectedItem.ToString();
            int id = int.Parse(selecionado.Split(':')[0]);

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string deleteSql = "DELETE FROM usuarios WHERE id = @id";
                using (var cmd = new NpgsqlCommand(deleteSql, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuário excluído com sucesso!");
            btnListar_Click(sender, e); // Atualiza lista
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string sobrenome = txtSobrenome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
            {
                MessageBox.Show("Digite nome e sobrenome.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open(); // Aqui pode dar erro se a conexão falhar

                    string insertSql = "INSERT INTO usuarios (nome, sobrenome) VALUES (@nome, @sobrenome)";
                    using (var cmd = new NpgsqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("sobrenome", sobrenome);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuário salvo com sucesso!");
                txtNome.Clear();
                txtSobrenome.Clear();
                btnListar_Click(sender, e); // Atualiza a lista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT id, nome, sobrenome FROM usuarios";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nomeCompleto = reader.GetString(1) + " " + reader.GetString(2);
                        listUsuarios.Items.Add($"{id}: {nomeCompleto}");
                    }
                }
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            string selecionado = listUsuarios.SelectedItem.ToString();
            int id = int.Parse(selecionado.Split(':')[0]);

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string deleteSql = "DELETE FROM usuarios WHERE id = @id";
                using (var cmd = new NpgsqlCommand(deleteSql, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuário excluído com sucesso!");
            btnListar_Click(sender, e); // Atualiza lista
        }
    }
}