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
    public partial class FormContasReceber : Form
    {
        public FormContasReceber()
        {
            InitializeComponent();
        }

        private void dgvReceber_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Pendente");
            cbStatus.Items.Add("Pago");
            cbStatus.SelectedIndex = 0;
        }

        private void Carregar()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                var cmd = new SqliteCommand("SELECT * FROM ContasReceber", conn);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvReceber.DataSource = dt;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO ContasReceber 
        (Cliente, Valor, Data, Status)
        VALUES (@c, @v, @d, @s)";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@c", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@v", Convert.ToDouble(txtValor.Text));
                    cmd.Parameters.AddWithValue("@d", dtData.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@s", cbStatus.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            Carregar();
        }

        private void dgvReceber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
