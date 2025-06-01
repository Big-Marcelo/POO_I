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
    public partial class FormAlertas : Form
    {
        public FormAlertas()
        {
            InitializeComponent();
        }
        string connStr = "Host=localhost;Port=5432;Username=postgres;Password=M3698520;Database=controle_financeiro";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUsuarioId.Text, out int idUsuario))
            {
                MessageBox.Show("ID do usuário inválido!");
                return;
            }

            using var conn = new NpgsqlConnection(connStr);
            conn.Open(); // Open the connection
            {
                string sql = "INSERT INTO alerta (id_usuario, descricao, condicao, ativo) VALUES (@id, @desc, @cond, @ativo)";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", idUsuario);
                    cmd.Parameters.AddWithValue("desc", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("cond", txtCondicao.Text);
                    cmd.Parameters.AddWithValue("ativo", chkAtivo.Checked);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Alerta criado com sucesso!");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUsuarioId.Text, out int idUsuario))
            {
                MessageBox.Show("ID do usuário inválido!");
                return;
            }

            using var conn = new NpgsqlConnection(connStr);
            {
                string sql = "SELECT id_alerta, descricao, condicao, ativo FROM alerta WHERE id_usuario = @id";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", idUsuario);
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvAlertas.DataSource = dt;
                    }
                }
            }
        }
    }
}
