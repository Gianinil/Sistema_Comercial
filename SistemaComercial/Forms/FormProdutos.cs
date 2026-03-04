using SistemaComercial.Forms;
using SistemaComercial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace SistemaComercial.Forms
{
    public partial class FormProdutos : Form
    {

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

            Database.CriarTabela();
            AtualizarGrid();

        }
        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = ProdutoRepository.Listar();

            dgvProdutos.Columns["Id"].Visible = false;

            dgvProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";

            dgvProdutos.Columns["Validade"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Novo_Click(object sender, EventArgs e)
        {

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroProduto tela = new FormCadastroProduto();
            tela.ShowDialog();

            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                Produto p = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

                ProdutoRepository.Excluir(p.Id);

                AtualizarGrid();
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                Produto p = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

                FormCadastroProduto tela = new FormCadastroProduto(p);
                tela.ShowDialog();

                AtualizarGrid();
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );


        private void panelBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = ProdutoRepository.Buscar(txtBuscar.Text);

            dgvProdutos.Columns["Id"].Visible = false;
            dgvProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
            dgvProdutos.Columns["Validade"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

    }


}

