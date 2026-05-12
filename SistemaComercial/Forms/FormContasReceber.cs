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

            Carregar();
        }

        private void Carregar()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM ContasReceber";

                var cmd = new SqliteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvReceber.DataSource = dt;
            }
        }



        private void dgvReceber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    MessageBox.Show("Informe o cliente.");
                    return;
                }

                if (!decimal.TryParse(txtValor.Text, out decimal valor))
                {
                    MessageBox.Show("Valor inválido.");
                    return;
                }

                if (cbStatus.SelectedItem == null)
                {
                    MessageBox.Show("Selecione o status.");
                    return;
                }

                string status = cbStatus.Text;
                string data = dtData.Value.ToString("yyyy-MM-dd");

                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO ContasReceber 
                (Cliente, Valor, Data, Status)
                VALUES (@c, @v, @d, @s)";

                    var cmd = new SqliteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@c", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@v", valor);
                    cmd.Parameters.AddWithValue("@d", data);
                    cmd.Parameters.AddWithValue("@s", status);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Conta registrada!");
                Carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnReceber_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvReceber.CurrentRow == null)
                {
                    MessageBox.Show("Selecione uma conta.");
                    return;
                }

                int id = Convert.ToInt32(dgvReceber.CurrentRow.Cells["Id"].Value);
                decimal valor = Convert.ToDecimal(dgvReceber.CurrentRow.Cells["Valor"].Value);
                string cliente = dgvReceber.CurrentRow.Cells["Cliente"].Value.ToString();

                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    //  ENTRADA NO CAIXA
                    string sqlCaixa = @"INSERT INTO Caixa 
            (Tipo, Valor, Descricao, DataMovimento, MetodoPagamento, Cliente/Fornecedor)
            VALUES (@tipo, @valor, @desc, @data, @metodo, @cliente)";

                    var cmdCaixa = new SqliteCommand(sqlCaixa, conn);
                    cmdCaixa.Parameters.AddWithValue("@tipo", "Entrada");
                    cmdCaixa.Parameters.AddWithValue("@valor", valor);
                    cmdCaixa.Parameters.AddWithValue("@desc", "Recebimento - " + cliente);
                    cmdCaixa.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdCaixa.Parameters.AddWithValue("@metodo", "Manual");
                    cmdCaixa.Parameters.AddWithValue("@cliente", cliente);
                    cmdCaixa.ExecuteNonQuery();

                    //  REMOVE DA LISTA
                    string sqlDelete = "DELETE FROM ContasReceber WHERE Id = @id";
                    var cmdDelete = new SqliteCommand(sqlDelete, conn);
                    cmdDelete.Parameters.AddWithValue("@id", id);
                    cmdDelete.ExecuteNonQuery();
                }

                MessageBox.Show("Pagamento recebido!");
                Carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
