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
    public partial class FormTransacoes : Form
    {
        string connStr = "Host=localhost;Port=5432;Username=postgres;Password=M3698520;Database=controle_financeiro";

        public FormTransacoes()
        {
            InitializeComponent();
        }

        private void FormTransacoes_Load(object sender, EventArgs e)
        {
            cmbTipoTransacao.Items.AddRange(new string[] { "receita", "despesa" });
            cmbTipoTransacao.SelectedIndex = 0;
            CarregarTransacoes();
        }

        private void CarregarTransacoes()
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var da = new NpgsqlDataAdapter("SELECT * FROM transacao ORDER BY id_transacao", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridViewTransacoes.DataSource = dt;
        }

        private void AdicionarTransacao()
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var cmd = new NpgsqlCommand(@"
        INSERT INTO transacao (id_conta, id_categoria, tipo, valor, data, descricao) 
        VALUES (@conta, @categoria, @tipo, @valor, @data, @descricao)", conn);

            cmd.Parameters.AddWithValue("conta", int.Parse(txtIdConta.Text));
            cmd.Parameters.AddWithValue("categoria", int.Parse(txtIdCategoria.Text));

            var tipoTransacao = cmbTipoTransacao.SelectedItem?.ToString() ?? string.Empty;
            cmd.Parameters.AddWithValue("tipo", tipoTransacao);

            cmd.Parameters.AddWithValue("valor", decimal.Parse(txtValor.Text));
            cmd.Parameters.AddWithValue("data", dtpDataTransacao.Value.Date);
            cmd.Parameters.AddWithValue("descricao", txtDescricao.Text);

            cmd.ExecuteNonQuery();
        }

        private void RemoverTransacao(int idTransacao)
        {
            using var conn = new NpgsqlConnection(connStr);
            conn.Open();
            var cmd = new NpgsqlCommand("DELETE FROM transacao WHERE id_transacao = @id", conn);
            cmd.Parameters.AddWithValue("id", idTransacao);
            cmd.ExecuteNonQuery();
        }

        private void btnAdicionarTransacao_Click(object sender, EventArgs e)
        {
            AdicionarTransacao();
            CarregarTransacoes();
        }

        private void btnRemoverTransacao_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransacoes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewTransacoes.SelectedRows[0].Cells["id_transacao"].Value);
                RemoverTransacao(id);
                CarregarTransacoes();
            }
        }

        private void btnCarregarTransacoes_Click(object sender, EventArgs e)
        {
            CarregarTransacoes();
        }

        private void cmbTipoTransacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarTransacao_Click_1(object sender, EventArgs e)
        {
            AdicionarTransacao();
        }
    }
}