using Microsoft.Data.Sqlite;
using SistemaComercial.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SistemaComercial
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            CarregarClientes();

            cbMetodoPagamento.Items.Add("Dinheiro");
            cbMetodoPagamento.Items.Add("Cartão Débito");
            cbMetodoPagamento.Items.Add("Cartão Crédito");
            cbMetodoPagamento.Items.Add("Pix");
            cbMetodoPagamento.SelectedIndex = 0;
            cmbCliente.SelectedIndex = -1;
            cmbProduto.SelectedIndex = -1;


        }
        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        private void CarregarClientes()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = "SELECT Id, Nome FROM Clientes";
                var cmd = new SqliteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                var lista = new List<Cliente>();

                while (reader.Read())
                {
                    lista.Add(new Cliente
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1)
                    });
                }

                cmbCliente.DataSource = lista;
                cmbCliente.DisplayMember = "Nome";
                cmbCliente.ValueMember = "Id";
            }
        }

        private void CarregarProdutos()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string sql = "SELECT Id, Nome FROM Produtos WHERE Quantidade > 0";
                var cmd = new SqliteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                var lista = new List<Produto>();

                while (reader.Read())
                {
                    lista.Add(new Produto
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1)
                    });
                }

                cmbProduto.DataSource = lista;
                cmbProduto.DisplayMember = "Nome";
                cmbProduto.ValueMember = "Id";
            }
        }



        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduto.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um produto.");
                    return;
                }

                if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("Quantidade inválida.");
                    return;
                }

                if (cbMetodoPagamento.SelectedItem == null)
                {
                    MessageBox.Show("Selecione o método de pagamento.");
                    return;
                }

                string metodo = cbMetodoPagamento.SelectedItem.ToString();
                int produtoId = (int)cmbProduto.SelectedValue;

                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sqlEstoque = "SELECT Quantidade FROM Produtos WHERE Id = @id";
                    var cmdEstoque = new SqliteCommand(sqlEstoque, conn);
                    cmdEstoque.Parameters.AddWithValue("@id", produtoId);

                    int estoqueAtual = Convert.ToInt32(cmdEstoque.ExecuteScalar());

                    if (quantidade > estoqueAtual)
                    {
                        MessageBox.Show("Estoque insuficiente.");
                        return;
                    }

                    string sqlAtualizar = "UPDATE Produtos SET Quantidade = Quantidade - @qtd WHERE Id = @id";
                    var cmdAtualizar = new SqliteCommand(sqlAtualizar, conn);
                    cmdAtualizar.Parameters.AddWithValue("@qtd", quantidade);
                    cmdAtualizar.Parameters.AddWithValue("@id", produtoId);
                    cmdAtualizar.ExecuteNonQuery();

                    string sqlVenda = @"INSERT INTO Vendas 
                        (ProdutoId, Quantidade, DataVenda, MetodoPagamento) 
                        VALUES (@produtoId, @quantidade, @data, @metodo)";

                    var cmdVenda = new SqliteCommand(sqlVenda, conn);
                    cmdVenda.Parameters.AddWithValue("@produtoId", produtoId);
                    cmdVenda.Parameters.AddWithValue("@quantidade", quantidade);
                    cmdVenda.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdVenda.Parameters.AddWithValue("@metodo", metodo);
                    cmdVenda.ExecuteNonQuery();

                    string sqlPreco = "SELECT Preco FROM Produtos WHERE Id = @id";
                    var cmdPreco = new SqliteCommand(sqlPreco, conn);
                    cmdPreco.Parameters.AddWithValue("@id", produtoId);

                    decimal precoUnitario = Convert.ToDecimal(cmdPreco.ExecuteScalar());
                    decimal totalVenda = precoUnitario * quantidade;

                    string sqlCaixa = @"INSERT INTO Caixa 
                        (Tipo, Valor, Descricao, DataMovimento, MetodoPagamento)
                        VALUES (@tipo, @valor, @descricao, @data, @metodo)";

                    var cmdCaixa = new SqliteCommand(sqlCaixa, conn);
                    cmdCaixa.Parameters.AddWithValue("@tipo", "Entrada");
                    cmdCaixa.Parameters.AddWithValue("@valor", totalVenda);
                    cmdCaixa.Parameters.AddWithValue("@descricao", "Venda de produto");
                    cmdCaixa.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdCaixa.Parameters.AddWithValue("@metodo", metodo);
                    cmdCaixa.ExecuteNonQuery();
                }

                MessageBox.Show("Venda realizada com sucesso!");
                CarregarProdutos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
