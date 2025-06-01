using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiroApp
{
    public partial class FormMetasFinanceiras : Form
    {
        string connStr = "Host=localhost;Port=5432;Username=postgres;Password=M3698520;Database=controle_financeiro";
        public FormMetasFinanceiras()
        {
            InitializeComponent();
        }

        private void dtpLimite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormMetasFinanceiras_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open(); // Open the connection
            string sql = "INSERT INTO metafinanceira (id_usuario, descricao, valor_objetivo, data_limite) VALUES (@id_usuario, @descricao, @valor, @data)";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("id_usuario", int.Parse(txtUsuarioId.Text));
                cmd.Parameters.AddWithValue("descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("valor", decimal.Parse(txtValor.Text));
                cmd.Parameters.AddWithValue("data", dtpLimite.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Meta salva com sucesso!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(txtUsuarioId.Text, out int idUsuario))
            {
                MessageBox.Show("Informe um ID de usuário válido!", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new NpgsqlConnection(connStr);
                {
                    string sql = "SELECT id_meta, descricao, valor_objetivo, data_limite FROM metafinanceira WHERE id_usuario = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", idUsuario);

                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvMetas.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar metas:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
