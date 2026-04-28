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
    public partial class FormContasPagar : Form
    {
        public FormContasPagar()
        {
            InitializeComponent();
        }

        private void Carregar()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                var cmd = new SqliteCommand("SELECT * FROM ContasPagar", conn);
                var reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvPagar.DataSource = dt;
            }
        }
        private void FormContasPagar_Load(object sender, EventArgs e)
        {
            Carregar();

            cbStatus.Items.Add("Pendente");
            cbStatus.Items.Add("Pago");
        }

        private void dgvPagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFornecedor.Text))
                {
                    MessageBox.Show("Informe o fornecedor.");
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

                    //  SALVA CONTA
                    string sql = @"INSERT INTO ContasPagar 
                (Fornecedor, Valor, Data, Status)
                VALUES (@f, @v, @d, @s)";

                    var cmd = new SqliteCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@f", txtFornecedor.Text);
                    cmd.Parameters.AddWithValue("@v", valor);
                    cmd.Parameters.AddWithValue("@d", data);
                    cmd.Parameters.AddWithValue("@s", status);
                    cmd.ExecuteNonQuery();

                    //  SE FOR PAGO → REGISTRA NO CAIXA
                    if (status == "Pago")
                    {
                        string sqlCaixa = @"INSERT INTO Caixa 
                (Tipo, Valor, Descricao, DataMovimento, MetodoPagamento)
                VALUES (@tipo, @valor, @desc, @data, @metodo)";

                        var cmdCaixa = new SqliteCommand(sqlCaixa, conn);
                        cmdCaixa.Parameters.AddWithValue("@tipo", "Saida");
                        cmdCaixa.Parameters.AddWithValue("@valor", valor);
                        cmdCaixa.Parameters.AddWithValue("@desc", "Pagamento - " + txtFornecedor.Text);
                        cmdCaixa.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmdCaixa.Parameters.AddWithValue("@metodo", "Manual");
                        cmdCaixa.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Conta salva com sucesso!");
                Carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPagar.CurrentRow == null)
                {
                    MessageBox.Show("Selecione uma conta.");
                    return;
                }

                int id = Convert.ToInt32(dgvPagar.CurrentRow.Cells["Id"].Value);
                decimal valor = Convert.ToDecimal(dgvPagar.CurrentRow.Cells["Valor"].Value);
                string fornecedor = dgvPagar.CurrentRow.Cells["Fornecedor"].Value.ToString();
                string status = dgvPagar.CurrentRow.Cells["Status"].Value.ToString();

                if (status == "Pago")
                {
                    MessageBox.Show("Essa conta já está paga.");
                    return;
                }

                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    // 🔹 ATUALIZA STATUS PARA PAGO
                    string sqlUpdate = "UPDATE ContasPagar SET Status = 'Pago' WHERE Id = @id";
                    var cmdUpdate = new SqliteCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@id", id);
                    cmdUpdate.ExecuteNonQuery();

                    // 🔥 REGISTRA SAÍDA NO CAIXA
                    string sqlCaixa = @"INSERT INTO Caixa 
            (Tipo, Valor, Descricao, DataMovimento, MetodoPagamento)
            VALUES (@tipo, @valor, @desc, @data, @metodo)";

                    var cmdCaixa = new SqliteCommand(sqlCaixa, conn);
                    cmdCaixa.Parameters.AddWithValue("@tipo", "Saida");
                    cmdCaixa.Parameters.AddWithValue("@valor", valor);
                    cmdCaixa.Parameters.AddWithValue("@desc", "Pagamento - " + fornecedor);
                    cmdCaixa.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdCaixa.Parameters.AddWithValue("@metodo", "Manual");
                    cmdCaixa.ExecuteNonQuery();
                    string sqlDelete = "DELETE FROM ContasPagar WHERE Id = @id";
                    var cmdDelete = new SqliteCommand(sqlDelete, conn);
                    cmdDelete.Parameters.AddWithValue("@id", id);
                    cmdDelete.ExecuteNonQuery();
                }

                MessageBox.Show("Conta paga com sucesso!");
                Carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
