using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace SistemaComercial.Forms
{
    public partial class FormMenu : Form
    {
        private int sidebarRecolhida = 70;
        private int sidebarExpandida = 200;
        private System.Windows.Forms.Timer timerSidebar = new System.Windows.Forms.Timer();
        private bool expandindo = false;

        private void InicializarSidebar()
        {
            timerSidebar.Interval = 10;
            timerSidebar.Tick += TimerSidebar_Tick;

            panel1.MouseEnter += (s, e) => { expandindo = true; timerSidebar.Start(); };
            panel1.MouseLeave += (s, e) =>
            {
                // Só recolhe se o mouse saiu do panel e de todos os filhos
                if (!panel1.ClientRectangle.Contains(panel1.PointToClient(Cursor.Position)))
                {
                    expandindo = false;
                    timerSidebar.Start();
                }
            };

            // Aplica o mesmo evento em todos os botões dentro do panel1
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.MouseEnter += (s, e) => { expandindo = true; timerSidebar.Start(); };
                ctrl.MouseLeave += (s, e) =>
                {
                    if (!panel1.ClientRectangle.Contains(panel1.PointToClient(Cursor.Position)))
                    {
                        expandindo = false;
                        timerSidebar.Start();
                    }
                };
            }
        }
        private void AjustarPosicaoCards()
        {
            int x = panel1.Width + 20;
            int larguraCard = (this.ClientSize.Width - x - 60) / 3;

            cardVendas.Location = new Point(x, 90);
            cardVendas.Width = larguraCard;

            cardProdutos.Location = new Point(x + larguraCard + 20, 90);
            cardProdutos.Width = larguraCard;

            cardClientes.Location = new Point(x + (larguraCard + 20) * 2, 90);
            cardClientes.Width = larguraCard;

            dgvUltimasVendas.Location = new Point(x, 210);
            dgvUltimasVendas.Width = this.ClientSize.Width - x - 20;
        }
        private void CarregarResumo()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                var cmdVendas = new SqliteCommand(
                    "SELECT IFNULL(SUM(v.Quantidade * p.Preco), 0) FROM Vendas v JOIN Produtos p ON v.ProdutoId = p.Id WHERE DATE(v.DataVenda) = DATE('now')", conn);
                decimal totalVendas = Convert.ToDecimal(cmdVendas.ExecuteScalar());
                lblVendas.Text = totalVendas.ToString("C2");

                var cmdProdutos = new SqliteCommand("SELECT COUNT(*) FROM Produtos", conn);
                lblProdutos.Text = cmdProdutos.ExecuteScalar().ToString();

                var cmdClientes = new SqliteCommand("SELECT COUNT(*) FROM Clientes", conn);
                lblClientes.Text = cmdClientes.ExecuteScalar().ToString();

                var cmdGrid = new SqliteCommand(@"
            SELECT c.Nome AS Cliente, p.Nome AS Produto, v.Quantidade, 
                   v.DataVenda AS Data, v.MetodoPagamento AS Pagamento
            FROM Vendas v
            JOIN Produtos p ON v.ProdutoId = p.Id
            LEFT JOIN Clientes c ON v.ClienteId = c.Id
            ORDER BY v.DataVenda DESC LIMIT 20", conn);

                var reader = cmdGrid.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                dgvUltimasVendas.DataSource = dt;

                dgvUltimasVendas.DataSource = dt;

                // Ajusta colunas para preencher largura
                dgvUltimasVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Peso de cada coluna (proporção)
                dgvUltimasVendas.Columns["Cliente"].FillWeight = 25;
                dgvUltimasVendas.Columns["Produto"].FillWeight = 25;
                dgvUltimasVendas.Columns["Quantidade"].FillWeight = 10;
                dgvUltimasVendas.Columns["Data"].FillWeight = 25;
                dgvUltimasVendas.Columns["Pagamento"].FillWeight = 15;
            }
        }

        private void TimerSidebar_Tick(object sender, EventArgs e)
        {
            if (expandindo)
            {
                if (panel1.Width < sidebarExpandida)
                    panel1.Width += 10;
                else
                {
                    panel1.Width = sidebarExpandida;
                    timerSidebar.Stop();
                    MostrarTextosBotoes(true);
                }
            }
            else
            {
                MostrarTextosBotoes(false);
                if (panel1.Width > sidebarRecolhida)
                    panel1.Width -= 10;
                else
                {
                    panel1.Width = sidebarRecolhida;
                    timerSidebar.Stop();
                }

            }
            panel2.Width = this.ClientSize.Width - panel1.Width;
            panel2.Left = panel1.Width;
            AjustarPosicaoCards();
        }

        private void MostrarTextosBotoes(bool mostrar)
        {
            btnProdutos.Text = mostrar ? "  Produtos" : "";
            btnVendas.Text = mostrar ? "  Vendas" : "";
            btnCaixa.Text = mostrar ? "  Caixa" : "";
            btnContasReceber.Text = mostrar ? "  Contas a Receber" : "";
            btnContasPagar.Text = mostrar ? "  Contas a Pagar" : "";
            button1.Text = mostrar ? "  Clientes" : "";
            btnFornecedor.Text = mostrar ? "  Fornecedores" : "";
            btnSair.Text = mostrar ? "  Sair" : "";

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.ImageAlign = mostrar
                        ? ContentAlignment.MiddleLeft
                        : ContentAlignment.MiddleCenter;
                }
            }
        }
        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }

        int fadeAlpha = 0;
        System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();

        public FormMenu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos tela = new FormProdutos();
            tela.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVenda tela = new FormVenda();
            tela.ShowDialog();
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

        private void btnCaixa_Click_1(object sender, EventArgs e)
        {
            FormCaixa tela = new FormCaixa();
            tela.ShowDialog();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e) { }
        private void FormMenu_Paint(object sender, PaintEventArgs e) { }
        private void btnFornecedor_Click(object sender, EventArgs e) { }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            FormContasPagar tela = new FormContasPagar();
            tela.Show();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            FormContasReceber tela = new FormContasReceber();
            tela.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            InicializarSidebar();
            AjustarPosicaoCards();
            CarregarResumo();
            panel2.Width = this.ClientSize.Width - panel1.Width;
            panel2.Left = panel1.Width;
            MostrarTextosBotoes(false);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AjustarPosicaoCards();
            panel2.Width = this.ClientSize.Width - panel1.Width;
            panel2.Left = panel1.Width;
        }

        private void btnFornecedor_Click_1(object sender, EventArgs e)
        {
            FormCadastroFornecedores tela = new FormCadastroFornecedores();
            tela.ShowDialog();
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientes tela = new FormClientes();
            tela.Show();
        }
    }
}