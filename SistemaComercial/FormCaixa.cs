using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaComercial
{
    public partial class FormCaixa : Form
    {
        public FormCaixa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            CarregarCaixa();
        }

        private void CarregarCaixa()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = "SELECT Tipo, Valor, Descricao, DataMovimento, MetodoPagamento FROM Caixa ORDER BY DataMovimento DESC";

                var cmd = new SqliteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);

                dgvCaixa.DataSource = dt;

                // Calcular totais
                string sqlEntrada = "SELECT IFNULL(SUM(Valor),0) FROM Caixa WHERE Tipo = 'Entrada'";
                string sqlSaida = "SELECT IFNULL(SUM(Valor),0) FROM Caixa WHERE Tipo = 'Saida'";

                var cmdEntrada = new SqliteCommand(sqlEntrada, conn);
                var cmdSaida = new SqliteCommand(sqlSaida, conn);

                decimal totalEntradas = Convert.ToDecimal(cmdEntrada.ExecuteScalar());
                decimal totalSaidas = Convert.ToDecimal(cmdSaida.ExecuteScalar());

                lblEntradas.Text = "Entradas: R$ " + totalEntradas.ToString("N2");
                lblSaidas.Text = "Saídas: R$ " + totalSaidas.ToString("N2");
                lblSaldo.Text = "Saldo: R$ " + (totalEntradas - totalSaidas).ToString("N2");
            }
        }

        private void dgvCaixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
