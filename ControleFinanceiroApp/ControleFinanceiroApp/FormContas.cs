using System;
using System.Collections.Generic;
using System.ComponentModel;
using Npgsql;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiroApp
{
    public partial class FormContas : Form
    {
        public FormContas()
        {
            InitializeComponent();
        }
        string connStr = "Host=localhost;Port=5432;Username=postgres;Password=M3698520;Database=controle_financeiro";

        private void CarregarContas()
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM conta ORDER BY id_conta", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridViewContas.DataSource = dt;
        }

        private void AdicionarConta(int idUsuario, string tipo, string banco, string numero)
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var cmd = new NpgsqlCommand("INSERT INTO conta (id_usuario, tipo, banco, numero) VALUES (@u, @t, @b, @n)", conn);
            cmd.Parameters.AddWithValue("u", idUsuario);
            cmd.Parameters.AddWithValue("t", tipo);
            cmd.Parameters.AddWithValue("b", banco);
            cmd.Parameters.AddWithValue("n", numero);
            cmd.ExecuteNonQuery();
        }

        private void RemoverConta(int id)
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var cmd = new NpgsqlCommand("DELETE FROM conta WHERE id_conta = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }

        private void FormContas_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregarContas_Click(object sender, EventArgs e)
        {
            CarregarContas();
        }

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuarioConta.Text, out int idUsuario))
            {
                MessageBox.Show("ID de usuário inválido.");
                return;
            }

            string banco = txtBanco.Text;
            string numero = txtNumero.Text;
            string? tipoSelecionado = cmbTipoConta.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tipoSelecionado))
            {
                MessageBox.Show("Selecione um tipo de conta.");
                return;
            }

            AdicionarConta(idUsuario, tipoSelecionado, banco, numero);
            CarregarContas();
        }

        private void btnRemoverConta_Click(object sender, EventArgs e)
        {
            if (dataGridViewContas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewContas.SelectedRows[0].Cells["id_conta"].Value);
                RemoverConta(id);
                CarregarContas();
            }
        }

        private void txtIdUsuarioConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
