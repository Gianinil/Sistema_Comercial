using SistemaComercial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SistemaComercial.Forms
{
    public partial class FormCadastroProduto : Form
    {
        private Produto produtoEdicao;

        // 🔹 Construtor para NOVO produto
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        // 🔹 Construtor para EDITAR produto
        public FormCadastroProduto(Produto p)
        {
            InitializeComponent();

            produtoEdicao = p;

            txtNome.Text = p.Nome;
            txtPreco.Text = p.Preco.ToString();
            txtQuantidade.Text = p.Quantidade.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime validade = dtValidade.Value;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite o nome do produto.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            if (produtoEdicao == null)
            {
                Produto p = new Produto
                {
                    Nome = txtNome.Text,
                    Preco = preco,
                    Quantidade = quantidade,
                    Validade = validade
                };

                ProdutoRepository.Inserir(p);
            }
            else
            {
                produtoEdicao.Nome = txtNome.Text;
                produtoEdicao.Preco = preco;
                produtoEdicao.Quantidade = quantidade;
                produtoEdicao.Validade = validade;

                ProdutoRepository.Atualizar(produtoEdicao);
            }

            this.Close();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
