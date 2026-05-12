using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace SistemaComercial
{
    public partial class FormCadastroFornecedores : Form
    {
        public FormCadastroFornecedores()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = @"
        INSERT INTO Fornecedor
        (Nome, Cnpj, Telefone, Email, Endereco)
        VALUES (@nome, @cnpj, @telefone, @email, @endereco)";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Fornecedor cadastrado com sucesso!");

            // Limpar campos
            txtNome.Clear();
            txtCnpj.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
        }

        private void FormClientes_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(9, 3, 90),
                Color.FromArgb(0, 0, 23),
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
